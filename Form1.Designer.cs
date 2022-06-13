namespace simpleDesktopClock
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timeDisplay = new System.Windows.Forms.Label();
            this.time24 = new System.Windows.Forms.RadioButton();
            this.time12 = new System.Windows.Forms.RadioButton();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.dateDisplay = new System.Windows.Forms.Label();
            this.linksite = new System.Windows.Forms.LinkLabel();
            this.settings = new System.Windows.Forms.GroupBox();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.setOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblCurOpacity = new System.Windows.Forms.Label();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoSize = true;
            this.timeDisplay.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.Location = new System.Drawing.Point(12, 9);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(450, 73);
            this.timeDisplay.TabIndex = 0;
            this.timeDisplay.Text = "00:00:00 AM";
            // 
            // time24
            // 
            this.time24.AutoSize = true;
            this.time24.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time24.Location = new System.Drawing.Point(310, 20);
            this.time24.Name = "time24";
            this.time24.Size = new System.Drawing.Size(43, 16);
            this.time24.TabIndex = 2;
            this.time24.Text = "24H";
            this.time24.UseVisualStyleBackColor = true;
            this.time24.CheckedChanged += new System.EventHandler(this.time24_CheckedChanged);
            // 
            // time12
            // 
            this.time12.AutoSize = true;
            this.time12.Checked = true;
            this.time12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time12.Location = new System.Drawing.Point(369, 20);
            this.time12.Name = "time12";
            this.time12.Size = new System.Drawing.Size(43, 16);
            this.time12.TabIndex = 3;
            this.time12.TabStop = true;
            this.time12.Text = "12H";
            this.time12.UseVisualStyleBackColor = true;
            this.time12.CheckedChanged += new System.EventHandler(this.time12_CheckedChanged);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 50;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // dateDisplay
            // 
            this.dateDisplay.AutoSize = true;
            this.dateDisplay.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateDisplay.Location = new System.Drawing.Point(20, 99);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(117, 21);
            this.dateDisplay.TabIndex = 0;
            this.dateDisplay.Text = "2020 Jan 1";
            // 
            // linksite
            // 
            this.linksite.AutoSize = true;
            this.linksite.Location = new System.Drawing.Point(22, 129);
            this.linksite.Name = "linksite";
            this.linksite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linksite.Size = new System.Drawing.Size(134, 12);
            this.linksite.TabIndex = 4;
            this.linksite.TabStop = true;
            this.linksite.Text = "Visit GitHub Repository";
            this.linksite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linksite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksite_LinkClicked);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.lblCurOpacity);
            this.settings.Controls.Add(this.lblOpacity);
            this.settings.Controls.Add(this.setOpacity);
            this.settings.Controls.Add(this.button1);
            this.settings.Controls.Add(this.alwaysOnTop);
            this.settings.Controls.Add(this.time24);
            this.settings.Controls.Add(this.time12);
            this.settings.Location = new System.Drawing.Point(26, 166);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(436, 98);
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            this.settings.Text = "설정";
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.AutoSize = true;
            this.alwaysOnTop.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alwaysOnTop.Location = new System.Drawing.Point(17, 20);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(156, 16);
            this.alwaysOnTop.TabIndex = 4;
            this.alwaysOnTop.Text = "다른 프로그램 앞에 표시";
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.alwaysOnTop_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSettings.Location = new System.Drawing.Point(329, 91);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(134, 35);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "설정...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(340, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "완료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setOpacity
            // 
            this.setOpacity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.setOpacity.Cursor = System.Windows.Forms.Cursors.Default;
            this.setOpacity.Location = new System.Drawing.Point(64, 46);
            this.setOpacity.Maximum = 100;
            this.setOpacity.Minimum = 50;
            this.setOpacity.Name = "setOpacity";
            this.setOpacity.Size = new System.Drawing.Size(104, 45);
            this.setOpacity.TabIndex = 7;
            this.setOpacity.TickFrequency = 5;
            this.setOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.setOpacity.Value = 100;
            this.setOpacity.Scroll += new System.EventHandler(this.setOpacity_Scroll);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOpacity.Location = new System.Drawing.Point(17, 54);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(41, 12);
            this.lblOpacity.TabIndex = 8;
            this.lblOpacity.Text = "투명도";
            // 
            // lblCurOpacity
            // 
            this.lblCurOpacity.AutoSize = true;
            this.lblCurOpacity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurOpacity.Location = new System.Drawing.Point(174, 54);
            this.lblCurOpacity.Name = "lblCurOpacity";
            this.lblCurOpacity.Size = new System.Drawing.Size(37, 12);
            this.lblCurOpacity.TabIndex = 9;
            this.lblCurOpacity.Text = "100%";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.linksite);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.timeDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Clock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.RadioButton time24;
        private System.Windows.Forms.RadioButton time12;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.LinkLabel linksite;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TrackBar setOpacity;
        private System.Windows.Forms.Label lblCurOpacity;
        private System.Windows.Forms.Label lblOpacity;
    }
}

