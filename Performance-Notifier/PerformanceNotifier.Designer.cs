namespace Performance_Notifier
{
    partial class PerformanceNotifierSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceNotifierSettings));
            this.cpuToggle = new System.Windows.Forms.CheckBox();
            this.cpuSlider = new System.Windows.Forms.TrackBar();
            this.cpuBox = new System.Windows.Forms.GroupBox();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.cpuNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.memoryBox = new System.Windows.Forms.GroupBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.memoryNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.memoryToggle = new System.Windows.Forms.CheckBox();
            this.memorySlider = new System.Windows.Forms.TrackBar();
            this.cpuMonitor = new System.Diagnostics.PerformanceCounter();
            this.memoryMonitor = new System.Diagnostics.PerformanceCounter();
            this.monitorBox = new System.Windows.Forms.GroupBox();
            this.memoryUsageLabel = new System.Windows.Forms.Label();
            this.memoryBar = new System.Windows.Forms.ProgressBar();
            this.memoryMonitorLabel = new System.Windows.Forms.Label();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.cpuMonitorLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpuSlider)).BeginInit();
            this.cpuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuNumUpDown)).BeginInit();
            this.memoryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryMonitor)).BeginInit();
            this.monitorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuToggle
            // 
            this.cpuToggle.AutoSize = true;
            this.cpuToggle.Checked = true;
            this.cpuToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cpuToggle.Location = new System.Drawing.Point(6, 19);
            this.cpuToggle.Name = "cpuToggle";
            this.cpuToggle.Size = new System.Drawing.Size(175, 17);
            this.cpuToggle.TabIndex = 1;
            this.cpuToggle.Text = "Enable CPU usage notifications";
            this.cpuToggle.UseVisualStyleBackColor = true;
            this.cpuToggle.CheckedChanged += new System.EventHandler(this.cpuToggle_CheckedChanged);
            // 
            // cpuSlider
            // 
            this.cpuSlider.LargeChange = 2;
            this.cpuSlider.Location = new System.Drawing.Point(6, 55);
            this.cpuSlider.Maximum = 20;
            this.cpuSlider.Name = "cpuSlider";
            this.cpuSlider.Size = new System.Drawing.Size(104, 45);
            this.cpuSlider.TabIndex = 3;
            this.cpuSlider.Scroll += new System.EventHandler(this.cpuSlider_Scroll);
            // 
            // cpuBox
            // 
            this.cpuBox.Controls.Add(this.cpuLabel);
            this.cpuBox.Controls.Add(this.cpuNumUpDown);
            this.cpuBox.Controls.Add(this.cpuToggle);
            this.cpuBox.Controls.Add(this.cpuSlider);
            this.cpuBox.Location = new System.Drawing.Point(12, 12);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(264, 104);
            this.cpuBox.TabIndex = 0;
            this.cpuBox.TabStop = false;
            this.cpuBox.Text = "CPU usage notifications";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(6, 39);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(221, 13);
            this.cpuLabel.TabIndex = 2;
            this.cpuLabel.Text = "Set the CPU usage threshold for notifications:";
            // 
            // cpuNumUpDown
            // 
            this.cpuNumUpDown.Location = new System.Drawing.Point(116, 55);
            this.cpuNumUpDown.Name = "cpuNumUpDown";
            this.cpuNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.cpuNumUpDown.TabIndex = 4;
            this.cpuNumUpDown.ValueChanged += new System.EventHandler(this.cpuNumUpDown_ValueChanged);
            // 
            // memoryBox
            // 
            this.memoryBox.Controls.Add(this.memoryLabel);
            this.memoryBox.Controls.Add(this.memoryNumUpDown);
            this.memoryBox.Controls.Add(this.memoryToggle);
            this.memoryBox.Controls.Add(this.memorySlider);
            this.memoryBox.Location = new System.Drawing.Point(12, 122);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(264, 104);
            this.memoryBox.TabIndex = 5;
            this.memoryBox.TabStop = false;
            this.memoryBox.Text = "Memory usage notifications";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(6, 39);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(235, 13);
            this.memoryLabel.TabIndex = 7;
            this.memoryLabel.Text = "Set the memory usage threshold for notifications:";
            // 
            // memoryNumUpDown
            // 
            this.memoryNumUpDown.Location = new System.Drawing.Point(116, 55);
            this.memoryNumUpDown.Name = "memoryNumUpDown";
            this.memoryNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.memoryNumUpDown.TabIndex = 9;
            this.memoryNumUpDown.ValueChanged += new System.EventHandler(this.memoryNumUpDown_ValueChanged);
            // 
            // memoryToggle
            // 
            this.memoryToggle.AutoSize = true;
            this.memoryToggle.Checked = true;
            this.memoryToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.memoryToggle.Location = new System.Drawing.Point(6, 19);
            this.memoryToggle.Name = "memoryToggle";
            this.memoryToggle.Size = new System.Drawing.Size(189, 17);
            this.memoryToggle.TabIndex = 6;
            this.memoryToggle.Text = "Enable memory usage notifications";
            this.memoryToggle.UseVisualStyleBackColor = true;
            this.memoryToggle.CheckedChanged += new System.EventHandler(this.memoryToggle_CheckedChanged);
            // 
            // memorySlider
            // 
            this.memorySlider.LargeChange = 2;
            this.memorySlider.Location = new System.Drawing.Point(6, 55);
            this.memorySlider.Maximum = 20;
            this.memorySlider.Name = "memorySlider";
            this.memorySlider.Size = new System.Drawing.Size(104, 45);
            this.memorySlider.TabIndex = 8;
            this.memorySlider.Scroll += new System.EventHandler(this.memorySlider_Scroll);
            // 
            // cpuMonitor
            // 
            this.cpuMonitor.CategoryName = "Processor";
            this.cpuMonitor.CounterName = "% Processor Time";
            this.cpuMonitor.InstanceName = "_Total";
            // 
            // memoryMonitor
            // 
            this.memoryMonitor.CategoryName = "Memory";
            this.memoryMonitor.CounterName = "Available MBytes";
            // 
            // monitorBox
            // 
            this.monitorBox.Controls.Add(this.memoryUsageLabel);
            this.monitorBox.Controls.Add(this.memoryBar);
            this.monitorBox.Controls.Add(this.memoryMonitorLabel);
            this.monitorBox.Controls.Add(this.cpuUsageLabel);
            this.monitorBox.Controls.Add(this.cpuBar);
            this.monitorBox.Controls.Add(this.cpuMonitorLabel);
            this.monitorBox.Location = new System.Drawing.Point(12, 229);
            this.monitorBox.Name = "monitorBox";
            this.monitorBox.Size = new System.Drawing.Size(264, 89);
            this.monitorBox.TabIndex = 10;
            this.monitorBox.TabStop = false;
            this.monitorBox.Text = "Current resource usage";
            // 
            // memoryUsageLabel
            // 
            this.memoryUsageLabel.AutoSize = true;
            this.memoryUsageLabel.Location = new System.Drawing.Point(201, 64);
            this.memoryUsageLabel.Name = "memoryUsageLabel";
            this.memoryUsageLabel.Size = new System.Drawing.Size(37, 13);
            this.memoryUsageLabel.TabIndex = 16;
            this.memoryUsageLabel.Text = "NaN%";
            // 
            // memoryBar
            // 
            this.memoryBar.Location = new System.Drawing.Point(10, 64);
            this.memoryBar.Name = "memoryBar";
            this.memoryBar.Size = new System.Drawing.Size(185, 13);
            this.memoryBar.Step = 1;
            this.memoryBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.memoryBar.TabIndex = 15;
            // 
            // memoryMonitorLabel
            // 
            this.memoryMonitorLabel.AutoSize = true;
            this.memoryMonitorLabel.Location = new System.Drawing.Point(6, 48);
            this.memoryMonitorLabel.Name = "memoryMonitorLabel";
            this.memoryMonitorLabel.Size = new System.Drawing.Size(79, 13);
            this.memoryMonitorLabel.TabIndex = 14;
            this.memoryMonitorLabel.Text = "Memory usage:";
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Location = new System.Drawing.Point(201, 32);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(37, 13);
            this.cpuUsageLabel.TabIndex = 13;
            this.cpuUsageLabel.Text = "NaN%";
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(10, 32);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(185, 13);
            this.cpuBar.Step = 1;
            this.cpuBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpuBar.TabIndex = 12;
            // 
            // cpuMonitorLabel
            // 
            this.cpuMonitorLabel.AutoSize = true;
            this.cpuMonitorLabel.Location = new System.Drawing.Point(6, 16);
            this.cpuMonitorLabel.Name = "cpuMonitorLabel";
            this.cpuMonitorLabel.Size = new System.Drawing.Size(89, 13);
            this.cpuMonitorLabel.TabIndex = 11;
            this.cpuMonitorLabel.Text = "Processor usage:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 324);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(264, 34);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit (stop background procces)";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PerformanceNotifierSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(288, 370);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monitorBox);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.cpuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PerformanceNotifierSettings";
            this.Text = "Performance Notifier";
            ((System.ComponentModel.ISupportInitialize)(this.cpuSlider)).EndInit();
            this.cpuBox.ResumeLayout(false);
            this.cpuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuNumUpDown)).EndInit();
            this.memoryBox.ResumeLayout(false);
            this.memoryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryMonitor)).EndInit();
            this.monitorBox.ResumeLayout(false);
            this.monitorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cpuToggle;
        private System.Windows.Forms.TrackBar cpuSlider;
        private System.Windows.Forms.GroupBox cpuBox;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.NumericUpDown cpuNumUpDown;
        private System.Windows.Forms.GroupBox memoryBox;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.NumericUpDown memoryNumUpDown;
        private System.Windows.Forms.CheckBox memoryToggle;
        private System.Windows.Forms.TrackBar memorySlider;
        private System.Diagnostics.PerformanceCounter cpuMonitor;
        private System.Diagnostics.PerformanceCounter memoryMonitor;
        private System.Windows.Forms.GroupBox monitorBox;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Label cpuMonitorLabel;
        private System.Windows.Forms.Label memoryUsageLabel;
        private System.Windows.Forms.ProgressBar memoryBar;
        private System.Windows.Forms.Label memoryMonitorLabel;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.Button exitButton;
    }
}

