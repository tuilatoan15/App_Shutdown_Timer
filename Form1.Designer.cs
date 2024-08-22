namespace Stopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHours = new System.Windows.Forms.Label();
            this.nmHour = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nmMinute = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nmSecond = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblHours);
            this.flowLayoutPanel1.Controls.Add(this.nmHour);
            this.flowLayoutPanel1.Controls.Add(this.lblMinutes);
            this.flowLayoutPanel1.Controls.Add(this.nmMinute);
            this.flowLayoutPanel1.Controls.Add(this.lblSeconds);
            this.flowLayoutPanel1.Controls.Add(this.nmSecond);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 47);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(13, 10);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(65, 25);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Hour";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmHour
            // 
            this.nmHour.Location = new System.Drawing.Point(84, 13);
            this.nmHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmHour.Name = "nmHour";
            this.nmHour.Size = new System.Drawing.Size(44, 20);
            this.nmHour.TabIndex = 1;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Location = new System.Drawing.Point(134, 10);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(65, 25);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Minutes";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmMinute
            // 
            this.nmMinute.Location = new System.Drawing.Point(205, 13);
            this.nmMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmMinute.Name = "nmMinute";
            this.nmMinute.Size = new System.Drawing.Size(44, 20);
            this.nmMinute.TabIndex = 3;
            this.nmMinute.ValueChanged += new System.EventHandler(this.nmMinute_ValueChanged);
            // 
            // lblSeconds
            // 
            this.lblSeconds.Location = new System.Drawing.Point(255, 10);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(65, 25);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "Second";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmSecond
            // 
            this.nmSecond.Location = new System.Drawing.Point(326, 13);
            this.nmSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmSecond.Name = "nmSecond";
            this.nmSecond.Size = new System.Drawing.Size(44, 20);
            this.nmSecond.TabIndex = 5;
            this.nmSecond.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnOpen);
            this.flowLayoutPanel2.Controls.Add(this.btnStart);
            this.flowLayoutPanel2.Controls.Add(this.btnStop);
            this.flowLayoutPanel2.Controls.Add(this.btnReset);
            this.flowLayoutPanel2.Controls.Add(this.btnHelp);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(383, 43);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 3);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 36);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(83, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(156, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(229, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 36);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(302, 3);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(67, 36);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(407, 145);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Shutdown Timer";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown nmHour;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nmMinute;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nmSecond;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timer1;
    }
}

