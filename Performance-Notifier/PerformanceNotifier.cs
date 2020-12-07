// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
using System;
using System.Windows.Forms;

namespace Performance_Notifier
{
    public partial class PerformanceNotifierSettings : Form
    {
        AppContext parent;

        public PerformanceNotifierSettings(AppContext parent, bool cpuNotifications, bool memoryNotifications, int cpuThreshold, int memoryThreshold)
        {
            InitializeComponent();

            this.parent = parent;
            cpuToggle.Checked = cpuNotifications;
            memoryToggle.Checked = memoryNotifications;
            cpuSlider.Value = cpuThreshold / 5;
            cpuNumUpDown.Value = cpuThreshold;
            memorySlider.Value = memoryThreshold / 5;
            memoryNumUpDown.Value = memoryThreshold;
        }

        public void SetCurrentResourceUsage(int cpuUsage, int memoryUsage)
        {
            Invoke(new MethodInvoker(delegate
            {
                cpuBar.Value = cpuUsage;
                cpuUsageLabel.Text = cpuUsage.ToString() + "%";
                memoryBar.Value = memoryUsage;
                memoryUsageLabel.Text = memoryUsage.ToString() + "%";
            }));
        }

        private void cpuToggle_CheckedChanged(object sender, EventArgs e)
        {
            parent.cpuNotifications = cpuToggle.Checked;
            cpuSlider.Enabled = cpuToggle.Checked;
            cpuNumUpDown.Enabled = cpuToggle.Checked;
        }

        private void memoryToggle_CheckedChanged(object sender, EventArgs e)
        {
            parent.memoryNotifications = memoryToggle.Checked;
            memorySlider.Enabled = memoryToggle.Checked;
            memoryNumUpDown.Enabled = memoryToggle.Checked;
        }

        private void cpuSlider_Scroll(object sender, EventArgs e)
        {
            parent.cpuThreshold = cpuSlider.Value * 5;
            cpuNumUpDown.Value = cpuSlider.Value * 5;
        }

        private void cpuNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            parent.cpuThreshold = (int)cpuNumUpDown.Value;
            cpuSlider.Value = (int)cpuNumUpDown.Value / 5;
        }

        private void memorySlider_Scroll(object sender, EventArgs e)
        {
            parent.memoryThreshold = memorySlider.Value * 5;
            memoryNumUpDown.Value = memorySlider.Value * 5;
        }

        private void memoryNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            parent.memoryThreshold = (int)memoryNumUpDown.Value;
            memorySlider.Value = (int)memoryNumUpDown.Value / 5;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            parent.CloseApplication();
        }
    }
}
