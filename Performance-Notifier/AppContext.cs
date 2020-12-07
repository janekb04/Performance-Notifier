// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Threading;
using IWshRuntimeLibrary;
using System.ComponentModel;

namespace Performance_Notifier
{
    public class AppContext : ApplicationContext
    {
        //Settings
        public bool cpuNotifications;
        public bool memoryNotifications;
        public int cpuThreshold;
        public int memoryThreshold;

        //File IO
        readonly string settingsFilePath = Application.LocalUserAppDataPath + "\\settings.txt";
        readonly string autorunPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

        //Notifications
        bool displayCpuNotifications = true;
        bool displayMemoryNotifications = true;
        int cpuPassedSamples = 0;
        int memoryPassedSamples = 0;

        //Other members
        PerformanceNotifierSettings form;
        NotifyIcon notifyIcon = new NotifyIcon();
        ComputerInfo computerInfo = new ComputerInfo();
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        bool updateForm = false;
        Thread worker;

        Process taskmgr = new Process();
        bool taskmgrIsOpen = false;

        public AppContext()
        {
            Application.ApplicationExit += OnApplicationExit;
            notifyIcon.Text = "Performance Notifier (running in background)";
            notifyIcon.Icon = Properties.Resources.Icon;
            notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;
            notifyIcon.Click += BackgroundNotification_Click;
            notifyIcon.Visible = true;

            CreateShortcut("Performance-Notifier", autorunPath, Application.ExecutablePath);

            //Read current settings
            try
            {
                using (StreamReader settingsFile = new StreamReader(settingsFilePath))
                {
                    cpuNotifications = Convert.ToBoolean(settingsFile.ReadLine());
                    memoryNotifications = Convert.ToBoolean(settingsFile.ReadLine());
                    cpuThreshold = Convert.ToInt32(settingsFile.ReadLine());
                    memoryThreshold = Convert.ToInt32(settingsFile.ReadLine());
                }    
            }
            catch (Exception)
            {
                cpuNotifications = true;
                memoryNotifications = true;
                cpuThreshold = 80;
                memoryThreshold = 80;
            }

            taskmgr.StartInfo.FileName = "taskmgr.exe";
            taskmgr.EnableRaisingEvents = true;
            taskmgr.Exited += Taskmgr_Exited;

            form = new PerformanceNotifierSettings(this, cpuNotifications, memoryNotifications, cpuThreshold, memoryThreshold);
            form.Closing += new CancelEventHandler(OnFormClosing);

            cpuCounter.NextValue();
            Thread.Sleep(1000);

            worker = new Thread(Timer_Elapsed);
            worker.Start();
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            if (!taskmgrIsOpen)
                taskmgr.Start();
            taskmgrIsOpen = true;
            displayCpuNotifications = false;
            displayMemoryNotifications = false;
        }

        private void Taskmgr_Exited(object sender, EventArgs e)
        {
            displayCpuNotifications = true;
            displayMemoryNotifications = true;
            memoryPassedSamples = 0;
            cpuPassedSamples = 0;
            taskmgrIsOpen = false;
        }

        public void CloseApplication()
        {
            notifyIcon.Visible = false;
            worker.Abort();
            ExitThread();
        }
	
        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "My shortcut description";   // The description of the shortcut
            shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        private void Timer_Elapsed()
        {
            int iteration = 0;
            while (true)
            {
                ++iteration;
                if (iteration >= 1200)
                {
                    displayCpuNotifications = true;
                    displayMemoryNotifications = true;
                    iteration -= 1200;
                }

                float cpuUsage = cpuCounter.NextValue();
                int memoryUsage = 100 - (int)(((float)computerInfo.AvailablePhysicalMemory / computerInfo.TotalPhysicalMemory) * 100);

                if (cpuNotifications && cpuUsage > cpuThreshold)
                {
                    if (cpuPassedSamples < 10)
                        ++cpuPassedSamples;
                    if (displayCpuNotifications && cpuPassedSamples >= 10)
                    {
                        notifyIcon.ShowBalloonTip(1000, "Detected high CPU usage.", "Detected processor usage above the specified threshold.", ToolTipIcon.Warning);
                        displayCpuNotifications = false;
                    }
                }
                else
                {
                    cpuPassedSamples = 0;
                }

                if (memoryNotifications && memoryUsage > memoryThreshold)
                {
                    if (memoryPassedSamples < 10)
                        ++memoryPassedSamples;
                    if (displayMemoryNotifications && memoryPassedSamples >= 10)
                    {
                        notifyIcon.ShowBalloonTip(1000, "Detected high memory usage.", "Detected memory usage above the specified threshold.", ToolTipIcon.Warning);
                        displayMemoryNotifications = false;
                    }
                }
                else
                {
                    memoryPassedSamples = 0;
                }

                try
                {
                    if (updateForm)
                        form.SetCurrentResourceUsage((int)cpuUsage, memoryUsage);
                }
                catch (Exception)
                {
                    //I don't care!
                }

                Thread.Sleep(500);
            }
        }

        private void BackgroundNotification_Click(object sender, EventArgs e)
        {
            if (updateForm == false)
            {
                form.Show();
                updateForm = true;
            }
        }

        private void SaveSettings()
        {
            using (StreamWriter settingsFile = new StreamWriter(settingsFilePath))
            {
                settingsFile.WriteLine(cpuNotifications);
                settingsFile.WriteLine(memoryNotifications);
                settingsFile.WriteLine(cpuThreshold);
                settingsFile.WriteLine(memoryThreshold);
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void OnFormClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            form.Hide();

            updateForm = false;

            SaveSettings();
            notifyIcon.Visible = true;
        }
    }
}
