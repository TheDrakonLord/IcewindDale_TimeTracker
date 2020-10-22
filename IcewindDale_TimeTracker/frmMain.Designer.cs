namespace IcewindDale_TimeTracker
{
    partial class frmMain
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
            this.pbxMoonPhase = new System.Windows.Forms.PictureBox();
            this.gbxClock = new System.Windows.Forms.GroupBox();
            this.txtHoliday = new System.Windows.Forms.TextBox();
            this.lblHoliday = new System.Windows.Forms.Label();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.txtCurSecond = new System.Windows.Forms.TextBox();
            this.lblCurSecond = new System.Windows.Forms.Label();
            this.txtCurMinute = new System.Windows.Forms.TextBox();
            this.lblCurMinute = new System.Windows.Forms.Label();
            this.txtCurHour = new System.Windows.Forms.TextBox();
            this.lblCurHour = new System.Windows.Forms.Label();
            this.txtCurDay = new System.Windows.Forms.TextBox();
            this.lblCurDay = new System.Windows.Forms.Label();
            this.txtCurMonth = new System.Windows.Forms.TextBox();
            this.lblCurMonth = new System.Windows.Forms.Label();
            this.txtCurYear = new System.Windows.Forms.TextBox();
            this.lblCurYear = new System.Windows.Forms.Label();
            this.txtMoonPhase = new System.Windows.Forms.TextBox();
            this.gbxAddTime = new System.Windows.Forms.GroupBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.txtAddSecond = new System.Windows.Forms.TextBox();
            this.txtAddMinute = new System.Windows.Forms.TextBox();
            this.txtAddHour = new System.Windows.Forms.TextBox();
            this.txtAddDay = new System.Windows.Forms.TextBox();
            this.txtAddMonth = new System.Windows.Forms.TextBox();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.lblAddSecond = new System.Windows.Forms.Label();
            this.lblAddMinute = new System.Windows.Forms.Label();
            this.lblAddHour = new System.Windows.Forms.Label();
            this.lblAddDay = new System.Windows.Forms.Label();
            this.lblAddMonth = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.gbxEnvironment = new System.Windows.Forms.GroupBox();
            this.txtSacrifices = new System.Windows.Forms.TextBox();
            this.txtDim = new System.Windows.Forms.TextBox();
            this.txtDark = new System.Windows.Forms.TextBox();
            this.txtBlizzard = new System.Windows.Forms.TextBox();
            this.txtAurora = new System.Windows.Forms.TextBox();
            this.gbxBlizzard = new System.Windows.Forms.GroupBox();
            this.txtBlizzDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtBlizzMin = new System.Windows.Forms.TextBox();
            this.txtBlizzHour = new System.Windows.Forms.TextBox();
            this.txtBlizzDay = new System.Windows.Forms.TextBox();
            this.txtBlizzMonth = new System.Windows.Forms.TextBox();
            this.btnAddBlizz = new System.Windows.Forms.Button();
            this.lblBlizzMin = new System.Windows.Forms.Label();
            this.lblBlizzHour = new System.Windows.Forms.Label();
            this.lblBlizzDay = new System.Windows.Forms.Label();
            this.lblBlizzMonth = new System.Windows.Forms.Label();
            this.gbxTimer = new System.Windows.Forms.GroupBox();
            this.gbxRounds = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddIRL = new System.Windows.Forms.Button();
            this.tmrIRL = new System.Windows.Forms.Timer(this.components);
            this.lblNumRounds = new System.Windows.Forms.Label();
            this.txtNumRounds = new System.Windows.Forms.TextBox();
            this.btnAddRounds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoonPhase)).BeginInit();
            this.gbxClock.SuspendLayout();
            this.gbxAddTime.SuspendLayout();
            this.gbxEnvironment.SuspendLayout();
            this.gbxBlizzard.SuspendLayout();
            this.gbxTimer.SuspendLayout();
            this.gbxRounds.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxMoonPhase
            // 
            this.pbxMoonPhase.Image = global::IcewindDale_TimeTracker.Properties.Resources.full_moon_icon;
            this.pbxMoonPhase.Location = new System.Drawing.Point(6, 19);
            this.pbxMoonPhase.Name = "pbxMoonPhase";
            this.pbxMoonPhase.Size = new System.Drawing.Size(153, 127);
            this.pbxMoonPhase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMoonPhase.TabIndex = 0;
            this.pbxMoonPhase.TabStop = false;
            // 
            // gbxClock
            // 
            this.gbxClock.Controls.Add(this.txtHoliday);
            this.gbxClock.Controls.Add(this.lblHoliday);
            this.gbxClock.Controls.Add(this.lblSeparator2);
            this.gbxClock.Controls.Add(this.lblSeparator1);
            this.gbxClock.Controls.Add(this.txtCurSecond);
            this.gbxClock.Controls.Add(this.lblCurSecond);
            this.gbxClock.Controls.Add(this.txtCurMinute);
            this.gbxClock.Controls.Add(this.lblCurMinute);
            this.gbxClock.Controls.Add(this.txtCurHour);
            this.gbxClock.Controls.Add(this.lblCurHour);
            this.gbxClock.Controls.Add(this.txtCurDay);
            this.gbxClock.Controls.Add(this.lblCurDay);
            this.gbxClock.Controls.Add(this.txtCurMonth);
            this.gbxClock.Controls.Add(this.lblCurMonth);
            this.gbxClock.Controls.Add(this.txtCurYear);
            this.gbxClock.Controls.Add(this.lblCurYear);
            this.gbxClock.Location = new System.Drawing.Point(13, 2);
            this.gbxClock.Name = "gbxClock";
            this.gbxClock.Size = new System.Drawing.Size(355, 146);
            this.gbxClock.TabIndex = 1;
            this.gbxClock.TabStop = false;
            this.gbxClock.Text = "Clock and Calendar";
            // 
            // txtHoliday
            // 
            this.txtHoliday.Location = new System.Drawing.Point(180, 102);
            this.txtHoliday.Name = "txtHoliday";
            this.txtHoliday.ReadOnly = true;
            this.txtHoliday.Size = new System.Drawing.Size(167, 20);
            this.txtHoliday.TabIndex = 15;
            // 
            // lblHoliday
            // 
            this.lblHoliday.AutoSize = true;
            this.lblHoliday.Location = new System.Drawing.Point(177, 86);
            this.lblHoliday.Name = "lblHoliday";
            this.lblHoliday.Size = new System.Drawing.Size(42, 13);
            this.lblHoliday.TabIndex = 14;
            this.lblHoliday.Text = "Holiday";
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.AutoSize = true;
            this.lblSeparator2.Location = new System.Drawing.Point(97, 105);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(10, 13);
            this.lblSeparator2.TabIndex = 13;
            this.lblSeparator2.Text = ":";
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.AutoSize = true;
            this.lblSeparator1.Location = new System.Drawing.Point(48, 105);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(10, 13);
            this.lblSeparator1.TabIndex = 12;
            this.lblSeparator1.Text = ":";
            // 
            // txtCurSecond
            // 
            this.txtCurSecond.Location = new System.Drawing.Point(113, 102);
            this.txtCurSecond.Name = "txtCurSecond";
            this.txtCurSecond.ReadOnly = true;
            this.txtCurSecond.Size = new System.Drawing.Size(41, 20);
            this.txtCurSecond.TabIndex = 11;
            // 
            // lblCurSecond
            // 
            this.lblCurSecond.AutoSize = true;
            this.lblCurSecond.Location = new System.Drawing.Point(110, 86);
            this.lblCurSecond.Name = "lblCurSecond";
            this.lblCurSecond.Size = new System.Drawing.Size(44, 13);
            this.lblCurSecond.TabIndex = 10;
            this.lblCurSecond.Text = "Second";
            // 
            // txtCurMinute
            // 
            this.txtCurMinute.Location = new System.Drawing.Point(60, 102);
            this.txtCurMinute.Name = "txtCurMinute";
            this.txtCurMinute.ReadOnly = true;
            this.txtCurMinute.Size = new System.Drawing.Size(36, 20);
            this.txtCurMinute.TabIndex = 9;
            // 
            // lblCurMinute
            // 
            this.lblCurMinute.AutoSize = true;
            this.lblCurMinute.Location = new System.Drawing.Point(57, 86);
            this.lblCurMinute.Name = "lblCurMinute";
            this.lblCurMinute.Size = new System.Drawing.Size(39, 13);
            this.lblCurMinute.TabIndex = 8;
            this.lblCurMinute.Text = "Minute";
            // 
            // txtCurHour
            // 
            this.txtCurHour.Location = new System.Drawing.Point(13, 102);
            this.txtCurHour.Name = "txtCurHour";
            this.txtCurHour.ReadOnly = true;
            this.txtCurHour.Size = new System.Drawing.Size(29, 20);
            this.txtCurHour.TabIndex = 7;
            // 
            // lblCurHour
            // 
            this.lblCurHour.AutoSize = true;
            this.lblCurHour.Location = new System.Drawing.Point(10, 86);
            this.lblCurHour.Name = "lblCurHour";
            this.lblCurHour.Size = new System.Drawing.Size(30, 13);
            this.lblCurHour.TabIndex = 6;
            this.lblCurHour.Text = "Hour";
            // 
            // txtCurDay
            // 
            this.txtCurDay.Location = new System.Drawing.Point(247, 47);
            this.txtCurDay.Name = "txtCurDay";
            this.txtCurDay.ReadOnly = true;
            this.txtCurDay.Size = new System.Drawing.Size(100, 20);
            this.txtCurDay.TabIndex = 5;
            // 
            // lblCurDay
            // 
            this.lblCurDay.AutoSize = true;
            this.lblCurDay.Location = new System.Drawing.Point(244, 31);
            this.lblCurDay.Name = "lblCurDay";
            this.lblCurDay.Size = new System.Drawing.Size(26, 13);
            this.lblCurDay.TabIndex = 4;
            this.lblCurDay.Text = "Day";
            // 
            // txtCurMonth
            // 
            this.txtCurMonth.Location = new System.Drawing.Point(128, 47);
            this.txtCurMonth.Name = "txtCurMonth";
            this.txtCurMonth.ReadOnly = true;
            this.txtCurMonth.Size = new System.Drawing.Size(100, 20);
            this.txtCurMonth.TabIndex = 3;
            // 
            // lblCurMonth
            // 
            this.lblCurMonth.AutoSize = true;
            this.lblCurMonth.Location = new System.Drawing.Point(125, 31);
            this.lblCurMonth.Name = "lblCurMonth";
            this.lblCurMonth.Size = new System.Drawing.Size(37, 13);
            this.lblCurMonth.TabIndex = 2;
            this.lblCurMonth.Text = "Month";
            // 
            // txtCurYear
            // 
            this.txtCurYear.Location = new System.Drawing.Point(7, 48);
            this.txtCurYear.Name = "txtCurYear";
            this.txtCurYear.ReadOnly = true;
            this.txtCurYear.Size = new System.Drawing.Size(100, 20);
            this.txtCurYear.TabIndex = 1;
            // 
            // lblCurYear
            // 
            this.lblCurYear.AutoSize = true;
            this.lblCurYear.Location = new System.Drawing.Point(7, 31);
            this.lblCurYear.Name = "lblCurYear";
            this.lblCurYear.Size = new System.Drawing.Size(29, 13);
            this.lblCurYear.TabIndex = 0;
            this.lblCurYear.Text = "Year";
            // 
            // txtMoonPhase
            // 
            this.txtMoonPhase.Location = new System.Drawing.Point(30, 152);
            this.txtMoonPhase.Name = "txtMoonPhase";
            this.txtMoonPhase.ReadOnly = true;
            this.txtMoonPhase.Size = new System.Drawing.Size(100, 20);
            this.txtMoonPhase.TabIndex = 2;
            // 
            // gbxAddTime
            // 
            this.gbxAddTime.Controls.Add(this.btnAddTime);
            this.gbxAddTime.Controls.Add(this.txtAddSecond);
            this.gbxAddTime.Controls.Add(this.txtAddMinute);
            this.gbxAddTime.Controls.Add(this.txtAddHour);
            this.gbxAddTime.Controls.Add(this.txtAddDay);
            this.gbxAddTime.Controls.Add(this.txtAddMonth);
            this.gbxAddTime.Controls.Add(this.txtAddYear);
            this.gbxAddTime.Controls.Add(this.lblAddSecond);
            this.gbxAddTime.Controls.Add(this.lblAddMinute);
            this.gbxAddTime.Controls.Add(this.lblAddHour);
            this.gbxAddTime.Controls.Add(this.lblAddDay);
            this.gbxAddTime.Controls.Add(this.lblAddMonth);
            this.gbxAddTime.Controls.Add(this.lblAddYear);
            this.gbxAddTime.Location = new System.Drawing.Point(14, 154);
            this.gbxAddTime.Name = "gbxAddTime";
            this.gbxAddTime.Size = new System.Drawing.Size(355, 150);
            this.gbxAddTime.TabIndex = 3;
            this.gbxAddTime.TabStop = false;
            this.gbxAddTime.Text = "Add Time";
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(16, 109);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(309, 23);
            this.btnAddTime.TabIndex = 12;
            this.btnAddTime.Text = "Add Time";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // txtAddSecond
            // 
            this.txtAddSecond.Location = new System.Drawing.Point(225, 82);
            this.txtAddSecond.Name = "txtAddSecond";
            this.txtAddSecond.Size = new System.Drawing.Size(100, 20);
            this.txtAddSecond.TabIndex = 11;
            // 
            // txtAddMinute
            // 
            this.txtAddMinute.Location = new System.Drawing.Point(119, 82);
            this.txtAddMinute.Name = "txtAddMinute";
            this.txtAddMinute.Size = new System.Drawing.Size(100, 20);
            this.txtAddMinute.TabIndex = 10;
            // 
            // txtAddHour
            // 
            this.txtAddHour.Location = new System.Drawing.Point(10, 82);
            this.txtAddHour.Name = "txtAddHour";
            this.txtAddHour.Size = new System.Drawing.Size(100, 20);
            this.txtAddHour.TabIndex = 9;
            // 
            // txtAddDay
            // 
            this.txtAddDay.Location = new System.Drawing.Point(225, 37);
            this.txtAddDay.Name = "txtAddDay";
            this.txtAddDay.Size = new System.Drawing.Size(100, 20);
            this.txtAddDay.TabIndex = 8;
            // 
            // txtAddMonth
            // 
            this.txtAddMonth.Location = new System.Drawing.Point(119, 36);
            this.txtAddMonth.Name = "txtAddMonth";
            this.txtAddMonth.Size = new System.Drawing.Size(100, 20);
            this.txtAddMonth.TabIndex = 7;
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(10, 37);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(100, 20);
            this.txtAddYear.TabIndex = 6;
            // 
            // lblAddSecond
            // 
            this.lblAddSecond.AutoSize = true;
            this.lblAddSecond.Location = new System.Drawing.Point(226, 65);
            this.lblAddSecond.Name = "lblAddSecond";
            this.lblAddSecond.Size = new System.Drawing.Size(44, 13);
            this.lblAddSecond.TabIndex = 5;
            this.lblAddSecond.Text = "Second";
            // 
            // lblAddMinute
            // 
            this.lblAddMinute.AutoSize = true;
            this.lblAddMinute.Location = new System.Drawing.Point(123, 66);
            this.lblAddMinute.Name = "lblAddMinute";
            this.lblAddMinute.Size = new System.Drawing.Size(39, 13);
            this.lblAddMinute.TabIndex = 4;
            this.lblAddMinute.Text = "Minute";
            // 
            // lblAddHour
            // 
            this.lblAddHour.AutoSize = true;
            this.lblAddHour.Location = new System.Drawing.Point(13, 66);
            this.lblAddHour.Name = "lblAddHour";
            this.lblAddHour.Size = new System.Drawing.Size(30, 13);
            this.lblAddHour.TabIndex = 3;
            this.lblAddHour.Text = "Hour";
            // 
            // lblAddDay
            // 
            this.lblAddDay.AutoSize = true;
            this.lblAddDay.Location = new System.Drawing.Point(226, 20);
            this.lblAddDay.Name = "lblAddDay";
            this.lblAddDay.Size = new System.Drawing.Size(26, 13);
            this.lblAddDay.TabIndex = 2;
            this.lblAddDay.Text = "Day";
            // 
            // lblAddMonth
            // 
            this.lblAddMonth.AutoSize = true;
            this.lblAddMonth.Location = new System.Drawing.Point(125, 20);
            this.lblAddMonth.Name = "lblAddMonth";
            this.lblAddMonth.Size = new System.Drawing.Size(37, 13);
            this.lblAddMonth.TabIndex = 1;
            this.lblAddMonth.Text = "Month";
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Location = new System.Drawing.Point(10, 20);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(29, 13);
            this.lblAddYear.TabIndex = 0;
            this.lblAddYear.Text = "Year";
            // 
            // gbxEnvironment
            // 
            this.gbxEnvironment.Controls.Add(this.txtSacrifices);
            this.gbxEnvironment.Controls.Add(this.txtDim);
            this.gbxEnvironment.Controls.Add(this.txtDark);
            this.gbxEnvironment.Controls.Add(this.txtBlizzard);
            this.gbxEnvironment.Controls.Add(this.txtAurora);
            this.gbxEnvironment.Controls.Add(this.pbxMoonPhase);
            this.gbxEnvironment.Controls.Add(this.txtMoonPhase);
            this.gbxEnvironment.Location = new System.Drawing.Point(375, 2);
            this.gbxEnvironment.Name = "gbxEnvironment";
            this.gbxEnvironment.Size = new System.Drawing.Size(275, 190);
            this.gbxEnvironment.TabIndex = 4;
            this.gbxEnvironment.TabStop = false;
            this.gbxEnvironment.Text = "Environment";
            // 
            // txtSacrifices
            // 
            this.txtSacrifices.Location = new System.Drawing.Point(166, 127);
            this.txtSacrifices.Name = "txtSacrifices";
            this.txtSacrifices.ReadOnly = true;
            this.txtSacrifices.Size = new System.Drawing.Size(100, 20);
            this.txtSacrifices.TabIndex = 7;
            this.txtSacrifices.Text = "Sacrifices";
            // 
            // txtDim
            // 
            this.txtDim.Location = new System.Drawing.Point(166, 100);
            this.txtDim.Name = "txtDim";
            this.txtDim.ReadOnly = true;
            this.txtDim.Size = new System.Drawing.Size(100, 20);
            this.txtDim.TabIndex = 6;
            this.txtDim.Text = "Dim Light";
            // 
            // txtDark
            // 
            this.txtDark.Location = new System.Drawing.Point(166, 73);
            this.txtDark.Name = "txtDark";
            this.txtDark.ReadOnly = true;
            this.txtDark.Size = new System.Drawing.Size(100, 20);
            this.txtDark.TabIndex = 5;
            this.txtDark.Text = "No Light";
            // 
            // txtBlizzard
            // 
            this.txtBlizzard.Location = new System.Drawing.Point(166, 46);
            this.txtBlizzard.Name = "txtBlizzard";
            this.txtBlizzard.ReadOnly = true;
            this.txtBlizzard.Size = new System.Drawing.Size(100, 20);
            this.txtBlizzard.TabIndex = 4;
            this.txtBlizzard.Text = "Blizzard";
            // 
            // txtAurora
            // 
            this.txtAurora.Location = new System.Drawing.Point(166, 19);
            this.txtAurora.Name = "txtAurora";
            this.txtAurora.ReadOnly = true;
            this.txtAurora.Size = new System.Drawing.Size(100, 20);
            this.txtAurora.TabIndex = 3;
            this.txtAurora.Text = "Aurora";
            // 
            // gbxBlizzard
            // 
            this.gbxBlizzard.Controls.Add(this.txtBlizzDuration);
            this.gbxBlizzard.Controls.Add(this.lblDuration);
            this.gbxBlizzard.Controls.Add(this.txtBlizzMin);
            this.gbxBlizzard.Controls.Add(this.txtBlizzHour);
            this.gbxBlizzard.Controls.Add(this.txtBlizzDay);
            this.gbxBlizzard.Controls.Add(this.txtBlizzMonth);
            this.gbxBlizzard.Controls.Add(this.btnAddBlizz);
            this.gbxBlizzard.Controls.Add(this.lblBlizzMin);
            this.gbxBlizzard.Controls.Add(this.lblBlizzHour);
            this.gbxBlizzard.Controls.Add(this.lblBlizzDay);
            this.gbxBlizzard.Controls.Add(this.lblBlizzMonth);
            this.gbxBlizzard.Location = new System.Drawing.Point(375, 199);
            this.gbxBlizzard.Name = "gbxBlizzard";
            this.gbxBlizzard.Size = new System.Drawing.Size(275, 100);
            this.gbxBlizzard.TabIndex = 5;
            this.gbxBlizzard.TabStop = false;
            this.gbxBlizzard.Text = "Add Blizzard";
            // 
            // txtBlizzDuration
            // 
            this.txtBlizzDuration.Location = new System.Drawing.Point(192, 38);
            this.txtBlizzDuration.Name = "txtBlizzDuration";
            this.txtBlizzDuration.Size = new System.Drawing.Size(77, 20);
            this.txtBlizzDuration.TabIndex = 12;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(193, 20);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(83, 13);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Duration (in Hrs)";
            // 
            // txtBlizzMin
            // 
            this.txtBlizzMin.Location = new System.Drawing.Point(147, 38);
            this.txtBlizzMin.Name = "txtBlizzMin";
            this.txtBlizzMin.Size = new System.Drawing.Size(40, 20);
            this.txtBlizzMin.TabIndex = 10;
            // 
            // txtBlizzHour
            // 
            this.txtBlizzHour.Location = new System.Drawing.Point(101, 37);
            this.txtBlizzHour.Name = "txtBlizzHour";
            this.txtBlizzHour.Size = new System.Drawing.Size(40, 20);
            this.txtBlizzHour.TabIndex = 9;
            // 
            // txtBlizzDay
            // 
            this.txtBlizzDay.Location = new System.Drawing.Point(55, 38);
            this.txtBlizzDay.Name = "txtBlizzDay";
            this.txtBlizzDay.Size = new System.Drawing.Size(40, 20);
            this.txtBlizzDay.TabIndex = 7;
            // 
            // txtBlizzMonth
            // 
            this.txtBlizzMonth.Location = new System.Drawing.Point(9, 38);
            this.txtBlizzMonth.Name = "txtBlizzMonth";
            this.txtBlizzMonth.Size = new System.Drawing.Size(40, 20);
            this.txtBlizzMonth.TabIndex = 6;
            // 
            // btnAddBlizz
            // 
            this.btnAddBlizz.Location = new System.Drawing.Point(9, 71);
            this.btnAddBlizz.Name = "btnAddBlizz";
            this.btnAddBlizz.Size = new System.Drawing.Size(257, 23);
            this.btnAddBlizz.TabIndex = 5;
            this.btnAddBlizz.Text = "Add Blizzard";
            this.btnAddBlizz.UseVisualStyleBackColor = true;
            this.btnAddBlizz.Click += new System.EventHandler(this.btnAddBlizz_Click);
            // 
            // lblBlizzMin
            // 
            this.lblBlizzMin.AutoSize = true;
            this.lblBlizzMin.Location = new System.Drawing.Point(148, 20);
            this.lblBlizzMin.Name = "lblBlizzMin";
            this.lblBlizzMin.Size = new System.Drawing.Size(39, 13);
            this.lblBlizzMin.TabIndex = 4;
            this.lblBlizzMin.Text = "Minute";
            // 
            // lblBlizzHour
            // 
            this.lblBlizzHour.AutoSize = true;
            this.lblBlizzHour.Location = new System.Drawing.Point(100, 21);
            this.lblBlizzHour.Name = "lblBlizzHour";
            this.lblBlizzHour.Size = new System.Drawing.Size(30, 13);
            this.lblBlizzHour.TabIndex = 3;
            this.lblBlizzHour.Text = "Hour";
            // 
            // lblBlizzDay
            // 
            this.lblBlizzDay.AutoSize = true;
            this.lblBlizzDay.Location = new System.Drawing.Point(52, 20);
            this.lblBlizzDay.Name = "lblBlizzDay";
            this.lblBlizzDay.Size = new System.Drawing.Size(26, 13);
            this.lblBlizzDay.TabIndex = 2;
            this.lblBlizzDay.Text = "Day";
            // 
            // lblBlizzMonth
            // 
            this.lblBlizzMonth.AutoSize = true;
            this.lblBlizzMonth.Location = new System.Drawing.Point(6, 21);
            this.lblBlizzMonth.Name = "lblBlizzMonth";
            this.lblBlizzMonth.Size = new System.Drawing.Size(37, 13);
            this.lblBlizzMonth.TabIndex = 1;
            this.lblBlizzMonth.Text = "Month";
            // 
            // gbxTimer
            // 
            this.gbxTimer.Controls.Add(this.btnAddIRL);
            this.gbxTimer.Controls.Add(this.btnReset);
            this.gbxTimer.Controls.Add(this.btnPause);
            this.gbxTimer.Controls.Add(this.btnStart);
            this.gbxTimer.Controls.Add(this.lblTimer);
            this.gbxTimer.Location = new System.Drawing.Point(14, 311);
            this.gbxTimer.Name = "gbxTimer";
            this.gbxTimer.Size = new System.Drawing.Size(354, 100);
            this.gbxTimer.TabIndex = 6;
            this.gbxTimer.TabStop = false;
            this.gbxTimer.Text = "Add IRL Time";
            // 
            // gbxRounds
            // 
            this.gbxRounds.Controls.Add(this.btnAddRounds);
            this.gbxRounds.Controls.Add(this.txtNumRounds);
            this.gbxRounds.Controls.Add(this.lblNumRounds);
            this.gbxRounds.Location = new System.Drawing.Point(375, 311);
            this.gbxRounds.Name = "gbxRounds";
            this.gbxRounds.Size = new System.Drawing.Size(275, 100);
            this.gbxRounds.TabIndex = 7;
            this.gbxRounds.TabStop = false;
            this.gbxRounds.Text = "Add Rounds";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(59, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(211, 37);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "HH : MM : SS";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(87, 71);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(271, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddIRL
            // 
            this.btnAddIRL.Location = new System.Drawing.Point(190, 71);
            this.btnAddIRL.Name = "btnAddIRL";
            this.btnAddIRL.Size = new System.Drawing.Size(75, 23);
            this.btnAddIRL.TabIndex = 4;
            this.btnAddIRL.Text = "Add Time";
            this.btnAddIRL.UseVisualStyleBackColor = true;
            this.btnAddIRL.Click += new System.EventHandler(this.btnAddIRL_Click);
            // 
            // tmrIRL
            // 
            this.tmrIRL.Interval = 1000;
            this.tmrIRL.Tick += new System.EventHandler(this.tmrIRL_Tick);
            // 
            // lblNumRounds
            // 
            this.lblNumRounds.AutoSize = true;
            this.lblNumRounds.Location = new System.Drawing.Point(6, 34);
            this.lblNumRounds.Name = "lblNumRounds";
            this.lblNumRounds.Size = new System.Drawing.Size(66, 13);
            this.lblNumRounds.TabIndex = 0;
            this.lblNumRounds.Text = "# of Rounds";
            // 
            // txtNumRounds
            // 
            this.txtNumRounds.Location = new System.Drawing.Point(6, 60);
            this.txtNumRounds.Name = "txtNumRounds";
            this.txtNumRounds.Size = new System.Drawing.Size(100, 20);
            this.txtNumRounds.TabIndex = 1;
            // 
            // btnAddRounds
            // 
            this.btnAddRounds.Location = new System.Drawing.Point(191, 60);
            this.btnAddRounds.Name = "btnAddRounds";
            this.btnAddRounds.Size = new System.Drawing.Size(75, 23);
            this.btnAddRounds.TabIndex = 2;
            this.btnAddRounds.Text = "Add Rounds";
            this.btnAddRounds.UseVisualStyleBackColor = true;
            this.btnAddRounds.Click += new System.EventHandler(this.btnAddRounds_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 419);
            this.Controls.Add(this.gbxRounds);
            this.Controls.Add(this.gbxTimer);
            this.Controls.Add(this.gbxBlizzard);
            this.Controls.Add(this.gbxEnvironment);
            this.Controls.Add(this.gbxAddTime);
            this.Controls.Add(this.gbxClock);
            this.Name = "frmMain";
            this.Text = "Icewind Dale Time Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoonPhase)).EndInit();
            this.gbxClock.ResumeLayout(false);
            this.gbxClock.PerformLayout();
            this.gbxAddTime.ResumeLayout(false);
            this.gbxAddTime.PerformLayout();
            this.gbxEnvironment.ResumeLayout(false);
            this.gbxEnvironment.PerformLayout();
            this.gbxBlizzard.ResumeLayout(false);
            this.gbxBlizzard.PerformLayout();
            this.gbxTimer.ResumeLayout(false);
            this.gbxTimer.PerformLayout();
            this.gbxRounds.ResumeLayout(false);
            this.gbxRounds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMoonPhase;
        private System.Windows.Forms.GroupBox gbxClock;
        private System.Windows.Forms.Label lblSeparator2;
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.TextBox txtCurSecond;
        private System.Windows.Forms.Label lblCurSecond;
        private System.Windows.Forms.TextBox txtCurMinute;
        private System.Windows.Forms.Label lblCurMinute;
        private System.Windows.Forms.TextBox txtCurHour;
        private System.Windows.Forms.Label lblCurHour;
        private System.Windows.Forms.TextBox txtCurDay;
        private System.Windows.Forms.Label lblCurDay;
        private System.Windows.Forms.TextBox txtCurMonth;
        private System.Windows.Forms.Label lblCurMonth;
        private System.Windows.Forms.TextBox txtCurYear;
        private System.Windows.Forms.Label lblCurYear;
        private System.Windows.Forms.TextBox txtHoliday;
        private System.Windows.Forms.Label lblHoliday;
        private System.Windows.Forms.TextBox txtMoonPhase;
        private System.Windows.Forms.GroupBox gbxAddTime;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.TextBox txtAddSecond;
        private System.Windows.Forms.TextBox txtAddMinute;
        private System.Windows.Forms.TextBox txtAddHour;
        private System.Windows.Forms.TextBox txtAddDay;
        private System.Windows.Forms.TextBox txtAddMonth;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.Label lblAddSecond;
        private System.Windows.Forms.Label lblAddMinute;
        private System.Windows.Forms.Label lblAddHour;
        private System.Windows.Forms.Label lblAddDay;
        private System.Windows.Forms.Label lblAddMonth;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.GroupBox gbxEnvironment;
        private System.Windows.Forms.TextBox txtDim;
        private System.Windows.Forms.TextBox txtDark;
        private System.Windows.Forms.TextBox txtBlizzard;
        private System.Windows.Forms.TextBox txtAurora;
        private System.Windows.Forms.GroupBox gbxBlizzard;
        private System.Windows.Forms.TextBox txtBlizzDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtBlizzMin;
        private System.Windows.Forms.TextBox txtBlizzHour;
        private System.Windows.Forms.TextBox txtBlizzDay;
        private System.Windows.Forms.TextBox txtBlizzMonth;
        private System.Windows.Forms.Button btnAddBlizz;
        private System.Windows.Forms.Label lblBlizzMin;
        private System.Windows.Forms.Label lblBlizzHour;
        private System.Windows.Forms.Label lblBlizzDay;
        private System.Windows.Forms.Label lblBlizzMonth;
        private System.Windows.Forms.TextBox txtSacrifices;
        private System.Windows.Forms.GroupBox gbxTimer;
        private System.Windows.Forms.Button btnAddIRL;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox gbxRounds;
        private System.Windows.Forms.Timer tmrIRL;
        private System.Windows.Forms.Button btnAddRounds;
        private System.Windows.Forms.TextBox txtNumRounds;
        private System.Windows.Forms.Label lblNumRounds;
    }
}

