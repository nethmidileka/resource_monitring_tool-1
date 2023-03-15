namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cpbCPU = new CircularProgressBar.CircularProgressBar();
            this.cpbRAM = new CircularProgressBar.CircularProgressBar();
            this.cpbHD = new CircularProgressBar.CircularProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblHD = new System.Windows.Forms.Label();
            this.pfcCPU = new System.Diagnostics.PerformanceCounter();
            this.pfcRAM = new System.Diagnostics.PerformanceCounter();
            this.pfcHD = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pfcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcHD)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbCPU
            // 
            this.cpbCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCPU.AnimationSpeed = 500;
            this.cpbCPU.BackColor = System.Drawing.Color.Transparent;
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbCPU.InnerMargin = 2;
            this.cpbCPU.InnerWidth = -1;
            this.cpbCPU.Location = new System.Drawing.Point(12, 12);
            this.cpbCPU.MarqueeAnimationSpeed = 2000;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.OuterColor = System.Drawing.Color.Gray;
            this.cpbCPU.OuterMargin = -25;
            this.cpbCPU.OuterWidth = 26;
            this.cpbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbCPU.ProgressWidth = 25;
            this.cpbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbCPU.Size = new System.Drawing.Size(190, 191);
            this.cpbCPU.StartAngle = 270;
            this.cpbCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCPU.SubscriptText = ".23";
            this.cpbCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCPU.SuperscriptText = "°C";
            this.cpbCPU.TabIndex = 0;
            this.cpbCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // cpbRAM
            // 
            this.cpbRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbRAM.AnimationSpeed = 500;
            this.cpbRAM.BackColor = System.Drawing.Color.Transparent;
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbRAM.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbRAM.InnerMargin = 2;
            this.cpbRAM.InnerWidth = -1;
            this.cpbRAM.Location = new System.Drawing.Point(275, 12);
            this.cpbRAM.MarqueeAnimationSpeed = 2000;
            this.cpbRAM.Maximum = 12288;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.OuterColor = System.Drawing.Color.Gray;
            this.cpbRAM.OuterMargin = -25;
            this.cpbRAM.OuterWidth = 26;
            this.cpbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbRAM.ProgressWidth = 25;
            this.cpbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbRAM.Size = new System.Drawing.Size(190, 191);
            this.cpbRAM.StartAngle = 270;
            this.cpbRAM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbRAM.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbRAM.SubscriptText = ".23";
            this.cpbRAM.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbRAM.SuperscriptText = "°C";
            this.cpbRAM.TabIndex = 1;
            this.cpbRAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // cpbHD
            // 
            this.cpbHD.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbHD.AnimationSpeed = 500;
            this.cpbHD.BackColor = System.Drawing.Color.Transparent;
            this.cpbHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbHD.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbHD.InnerMargin = 2;
            this.cpbHD.InnerWidth = -1;
            this.cpbHD.Location = new System.Drawing.Point(562, 12);
            this.cpbHD.MarqueeAnimationSpeed = 2000;
            this.cpbHD.Maximum = 930;
            this.cpbHD.Name = "cpbHD";
            this.cpbHD.OuterColor = System.Drawing.Color.Gray;
            this.cpbHD.OuterMargin = -25;
            this.cpbHD.OuterWidth = 26;
            this.cpbHD.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbHD.ProgressWidth = 25;
            this.cpbHD.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbHD.Size = new System.Drawing.Size(190, 191);
            this.cpbHD.StartAngle = 270;
            this.cpbHD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbHD.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbHD.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbHD.SubscriptText = ".23";
            this.cpbHD.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbHD.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbHD.SuperscriptText = "°C";
            this.cpbHD.TabIndex = 2;
            this.cpbHD.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(55, 98);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(35, 16);
            this.lblCPU.TabIndex = 3;
            this.lblCPU.Text = "CPU";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(361, 98);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(37, 16);
            this.lblRAM.TabIndex = 4;
            this.lblRAM.Text = "RAM";
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Location = new System.Drawing.Point(603, 98);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(27, 16);
            this.lblHD.TabIndex = 5;
            this.lblHD.Text = "HD";
            // 
            // pfcCPU
            // 
            this.pfcCPU.CategoryName = "Processor";
            this.pfcCPU.CounterName = "% Processor Time";
            this.pfcCPU.InstanceName = "_Total";
            // 
            // pfcRAM
            // 
            this.pfcRAM.CategoryName = "Memory";
            this.pfcRAM.CounterName = "Available MBytes";
            // 
            // pfcHD
            // 
            this.pfcHD.CategoryName = "LogicalDisk";
            this.pfcHD.CounterName = "% Free Space";
            this.pfcHD.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.lblHD);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.cpbHD);
            this.Controls.Add(this.cpbRAM);
            this.Controls.Add(this.cpbCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pfcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfcHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpbCPU;
        private CircularProgressBar.CircularProgressBar cpbRAM;
        private CircularProgressBar.CircularProgressBar cpbHD;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblHD;
        private System.Diagnostics.PerformanceCounter pfcCPU;
        private System.Diagnostics.PerformanceCounter pfcRAM;
        private System.Diagnostics.PerformanceCounter pfcHD;
        private System.Windows.Forms.Timer timer1;
    }
}

