// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performance_Notifier
{
    static class Program
    {
        private static Mutex instance;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            instance = new Mutex(true, "Performance-Notifier-1034756109586", out createdNew);

            if (!createdNew)
                return;

            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            start:
            try
            {
                Application.Run(new AppContext());
            }
            catch (InvalidOperationException e)
            {
                DialogResult result = MessageBox.Show("Exception occurred: " + e.Message + " Attempt fix (requires administrator rights)?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C cd C:\\Windows\\SysWOW64 && lodctr /r";
                    startInfo.Verb = "runas";
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();

                    goto start;
                }
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Exception occurred: " + e.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    goto start;
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
