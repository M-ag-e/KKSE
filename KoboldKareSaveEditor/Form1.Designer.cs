namespace KoboldKareSaveEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ms_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_OpenSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_ExportSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_RenameSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_QuitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_WhatToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_WhoMade = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updn_Bri = new System.Windows.Forms.NumericUpDown();
            this.updn_Sat = new System.Windows.Forms.NumericUpDown();
            this.updn_Hue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.updn_KoboldGrabCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.updn_KoboldBellySize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.updn_KoboldBreastSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.updn_KoboldDickSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.updn_KoboldBallSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updn_KoboldFatSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.updn_KoboldBaseSize = new System.Windows.Forms.NumericUpDown();
            this.lbl_KoboldMaxEnergy = new System.Windows.Forms.Label();
            this.updn_KoboldMaxEnergy = new System.Windows.Forms.NumericUpDown();
            this.cbx_KoboldSelection = new System.Windows.Forms.ComboBox();
            this.ColourPickDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_PlayerControlled = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updn_KoboldMoney = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.updn_KoboldDickEquip = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.updn_KoboldMetabolizeCapacity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updn_Bri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_Sat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldGrabCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBellySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBreastSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldDickSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldFatSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBaseSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMaxEnergy)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldDickEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMetabolizeCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(549, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ms_File
            // 
            this.ms_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_OpenSave,
            this.ms_ExportSave,
            this.ms_RenameSave,
            this.toolStripMenuItem1,
            this.ms_QuitApplication});
            this.ms_File.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(37, 20);
            this.ms_File.Text = "&File";
            // 
            // ms_OpenSave
            // 
            this.ms_OpenSave.BackColor = System.Drawing.SystemColors.Control;
            this.ms_OpenSave.Name = "ms_OpenSave";
            this.ms_OpenSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ms_OpenSave.Size = new System.Drawing.Size(185, 22);
            this.ms_OpenSave.Text = "Open Save";
            this.ms_OpenSave.Click += new System.EventHandler(this.ms_OpenSave_Click);
            // 
            // ms_ExportSave
            // 
            this.ms_ExportSave.Name = "ms_ExportSave";
            this.ms_ExportSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ms_ExportSave.Size = new System.Drawing.Size(185, 22);
            this.ms_ExportSave.Text = "Export Save";
            this.ms_ExportSave.Click += new System.EventHandler(this.ms_ExportSave_Click);
            // 
            // ms_RenameSave
            // 
            this.ms_RenameSave.Name = "ms_RenameSave";
            this.ms_RenameSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ms_RenameSave.Size = new System.Drawing.Size(185, 22);
            this.ms_RenameSave.Text = "Rename Save";
            this.ms_RenameSave.Click += new System.EventHandler(this.ms_RenameSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // ms_QuitApplication
            // 
            this.ms_QuitApplication.Name = "ms_QuitApplication";
            this.ms_QuitApplication.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.ms_QuitApplication.Size = new System.Drawing.Size(185, 22);
            this.ms_QuitApplication.Text = "Quit";
            this.ms_QuitApplication.Click += new System.EventHandler(this.ms_QuitApplication_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Checked = true;
            this.darkModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_WhatToDo,
            this.ms_WhoMade});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ms_WhatToDo
            // 
            this.ms_WhatToDo.Name = "ms_WhatToDo";
            this.ms_WhatToDo.Size = new System.Drawing.Size(137, 22);
            this.ms_WhatToDo.Text = "What do?";
            this.ms_WhatToDo.Click += new System.EventHandler(this.ms_WhatToDo_Click);
            // 
            // ms_WhoMade
            // 
            this.ms_WhoMade.Name = "ms_WhoMade";
            this.ms_WhoMade.Size = new System.Drawing.Size(137, 22);
            this.ms_WhoMade.Text = "Who made?";
            this.ms_WhoMade.Click += new System.EventHandler(this.ms_WhoMade_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "SAVENAME.sav";
            this.OpenFileDialog.Filter = ".sav Files|*.sav";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.updn_Bri);
            this.groupBox1.Controls.Add(this.updn_Sat);
            this.groupBox1.Controls.Add(this.updn_Hue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.updn_KoboldGrabCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updn_KoboldBellySize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.updn_KoboldBreastSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.updn_KoboldDickSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updn_KoboldBallSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.updn_KoboldFatSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updn_KoboldBaseSize);
            this.groupBox1.Controls.Add(this.lbl_KoboldMaxEnergy);
            this.groupBox1.Controls.Add(this.updn_KoboldMaxEnergy);
            this.groupBox1.Controls.Add(this.cbx_KoboldSelection);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Kobold Stats";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "HSB :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_Bri
            // 
            this.updn_Bri.DecimalPlaces = 2;
            this.updn_Bri.Location = new System.Drawing.Point(198, 51);
            this.updn_Bri.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updn_Bri.Name = "updn_Bri";
            this.updn_Bri.Size = new System.Drawing.Size(57, 23);
            this.updn_Bri.TabIndex = 22;
            this.updn_Bri.ValueChanged += new System.EventHandler(this.updn_Bri_ValueChanged);
            // 
            // updn_Sat
            // 
            this.updn_Sat.DecimalPlaces = 2;
            this.updn_Sat.Location = new System.Drawing.Point(135, 51);
            this.updn_Sat.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updn_Sat.Name = "updn_Sat";
            this.updn_Sat.Size = new System.Drawing.Size(57, 23);
            this.updn_Sat.TabIndex = 21;
            this.updn_Sat.ValueChanged += new System.EventHandler(this.updn_Sat_ValueChanged);
            // 
            // updn_Hue
            // 
            this.updn_Hue.DecimalPlaces = 2;
            this.updn_Hue.Location = new System.Drawing.Point(72, 51);
            this.updn_Hue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updn_Hue.Name = "updn_Hue";
            this.updn_Hue.Size = new System.Drawing.Size(57, 23);
            this.updn_Hue.TabIndex = 20;
            this.updn_Hue.ValueChanged += new System.EventHandler(this.updn_Hue_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Grab Count :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldGrabCount
            // 
            this.updn_KoboldGrabCount.DecimalPlaces = 5;
            this.updn_KoboldGrabCount.Location = new System.Drawing.Point(135, 283);
            this.updn_KoboldGrabCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldGrabCount.Name = "updn_KoboldGrabCount";
            this.updn_KoboldGrabCount.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldGrabCount.TabIndex = 18;
            this.updn_KoboldGrabCount.ValueChanged += new System.EventHandler(this.updn_KoboldGrabCount_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Belly Size :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldBellySize
            // 
            this.updn_KoboldBellySize.DecimalPlaces = 5;
            this.updn_KoboldBellySize.Location = new System.Drawing.Point(135, 254);
            this.updn_KoboldBellySize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldBellySize.Name = "updn_KoboldBellySize";
            this.updn_KoboldBellySize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldBellySize.TabIndex = 16;
            this.updn_KoboldBellySize.ValueChanged += new System.EventHandler(this.updn_KoboldBellySize_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Breast Size :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldBreastSize
            // 
            this.updn_KoboldBreastSize.DecimalPlaces = 5;
            this.updn_KoboldBreastSize.Location = new System.Drawing.Point(135, 225);
            this.updn_KoboldBreastSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldBreastSize.Name = "updn_KoboldBreastSize";
            this.updn_KoboldBreastSize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldBreastSize.TabIndex = 14;
            this.updn_KoboldBreastSize.ValueChanged += new System.EventHandler(this.updn_KoboldBreastSize_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dick Size :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldDickSize
            // 
            this.updn_KoboldDickSize.DecimalPlaces = 5;
            this.updn_KoboldDickSize.Location = new System.Drawing.Point(135, 196);
            this.updn_KoboldDickSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldDickSize.Name = "updn_KoboldDickSize";
            this.updn_KoboldDickSize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldDickSize.TabIndex = 12;
            this.updn_KoboldDickSize.ValueChanged += new System.EventHandler(this.updn_KoboldDickSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Balls Size :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldBallSize
            // 
            this.updn_KoboldBallSize.DecimalPlaces = 5;
            this.updn_KoboldBallSize.Location = new System.Drawing.Point(135, 167);
            this.updn_KoboldBallSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldBallSize.Name = "updn_KoboldBallSize";
            this.updn_KoboldBallSize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldBallSize.TabIndex = 10;
            this.updn_KoboldBallSize.ValueChanged += new System.EventHandler(this.updn_KoboldBallSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fat Size :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldFatSize
            // 
            this.updn_KoboldFatSize.DecimalPlaces = 5;
            this.updn_KoboldFatSize.Location = new System.Drawing.Point(135, 138);
            this.updn_KoboldFatSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldFatSize.Name = "updn_KoboldFatSize";
            this.updn_KoboldFatSize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldFatSize.TabIndex = 8;
            this.updn_KoboldFatSize.ValueChanged += new System.EventHandler(this.updn_KoboldFatSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Base Size :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldBaseSize
            // 
            this.updn_KoboldBaseSize.DecimalPlaces = 5;
            this.updn_KoboldBaseSize.Location = new System.Drawing.Point(135, 109);
            this.updn_KoboldBaseSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldBaseSize.Name = "updn_KoboldBaseSize";
            this.updn_KoboldBaseSize.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldBaseSize.TabIndex = 6;
            this.updn_KoboldBaseSize.ValueChanged += new System.EventHandler(this.updn_KoboldBaseSize_ValueChanged);
            // 
            // lbl_KoboldMaxEnergy
            // 
            this.lbl_KoboldMaxEnergy.Location = new System.Drawing.Point(6, 80);
            this.lbl_KoboldMaxEnergy.Name = "lbl_KoboldMaxEnergy";
            this.lbl_KoboldMaxEnergy.Size = new System.Drawing.Size(123, 23);
            this.lbl_KoboldMaxEnergy.TabIndex = 5;
            this.lbl_KoboldMaxEnergy.Text = "Max Energy :";
            this.lbl_KoboldMaxEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldMaxEnergy
            // 
            this.updn_KoboldMaxEnergy.DecimalPlaces = 5;
            this.updn_KoboldMaxEnergy.Location = new System.Drawing.Point(135, 80);
            this.updn_KoboldMaxEnergy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldMaxEnergy.Name = "updn_KoboldMaxEnergy";
            this.updn_KoboldMaxEnergy.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldMaxEnergy.TabIndex = 4;
            this.updn_KoboldMaxEnergy.ValueChanged += new System.EventHandler(this.updn_KoboldMaxEnergy_ValueChanged);
            // 
            // cbx_KoboldSelection
            // 
            this.cbx_KoboldSelection.FormattingEnabled = true;
            this.cbx_KoboldSelection.Location = new System.Drawing.Point(6, 22);
            this.cbx_KoboldSelection.Name = "cbx_KoboldSelection";
            this.cbx_KoboldSelection.Size = new System.Drawing.Size(249, 23);
            this.cbx_KoboldSelection.TabIndex = 2;
            this.cbx_KoboldSelection.Text = "Please Select A Kobold";
            this.cbx_KoboldSelection.SelectedIndexChanged += new System.EventHandler(this.cbx_KoboldSelection_SelectedIndexChanged);
            // 
            // ColourPickDialog
            // 
            this.ColourPickDialog.AnyColor = true;
            this.ColourPickDialog.Color = System.Drawing.Color.Red;
            this.ColourPickDialog.FullOpen = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_PlayerControlled);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.updn_KoboldMoney);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.updn_KoboldDickEquip);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.updn_KoboldMetabolizeCapacity);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(279, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 321);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Kobold Stats";
            // 
            // cbx_PlayerControlled
            // 
            this.cbx_PlayerControlled.Enabled = false;
            this.cbx_PlayerControlled.Location = new System.Drawing.Point(6, 111);
            this.cbx_PlayerControlled.Name = "cbx_PlayerControlled";
            this.cbx_PlayerControlled.Size = new System.Drawing.Size(249, 24);
            this.cbx_PlayerControlled.TabIndex = 24;
            this.cbx_PlayerControlled.Text = "Is Player Controlled";
            this.cbx_PlayerControlled.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kobold Money :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldMoney
            // 
            this.updn_KoboldMoney.Location = new System.Drawing.Point(135, 82);
            this.updn_KoboldMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldMoney.Name = "updn_KoboldMoney";
            this.updn_KoboldMoney.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldMoney.TabIndex = 21;
            this.updn_KoboldMoney.ValueChanged += new System.EventHandler(this.updn_KoboldMoney_ValueChanged);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(6, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 52);
            this.label16.TabIndex = 20;
            this.label16.Text = "!!WARNING!! Messing with thease can cause your Kobold to be deleted from exsistan" +
    "ce if not done right, please back up your save before doing proceding! ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Dick Equip :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldDickEquip
            // 
            this.updn_KoboldDickEquip.Location = new System.Drawing.Point(135, 53);
            this.updn_KoboldDickEquip.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updn_KoboldDickEquip.Name = "updn_KoboldDickEquip";
            this.updn_KoboldDickEquip.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldDickEquip.TabIndex = 6;
            this.updn_KoboldDickEquip.ValueChanged += new System.EventHandler(this.updn_KoboldDickEquip_ValueChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "Metabloize Capacity :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updn_KoboldMetabolizeCapacity
            // 
            this.updn_KoboldMetabolizeCapacity.DecimalPlaces = 5;
            this.updn_KoboldMetabolizeCapacity.Location = new System.Drawing.Point(135, 24);
            this.updn_KoboldMetabolizeCapacity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updn_KoboldMetabolizeCapacity.Name = "updn_KoboldMetabolizeCapacity";
            this.updn_KoboldMetabolizeCapacity.Size = new System.Drawing.Size(120, 23);
            this.updn_KoboldMetabolizeCapacity.TabIndex = 4;
            this.updn_KoboldMetabolizeCapacity.ValueChanged += new System.EventHandler(this.updn_KoboldMetabolizeCapacity_ValueChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(0, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "v0.0.1";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = ".sav Files|*.sav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 407);
            this.MinimumSize = new System.Drawing.Size(565, 407);
            this.Name = "Form1";
            this.Text = "KKSE - ";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updn_Bri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_Sat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldGrabCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBellySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBreastSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldDickSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldFatSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldBaseSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMaxEnergy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldDickEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_KoboldMetabolizeCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem ms_File;
        private ToolStripMenuItem ms_OpenSave;
        private ToolStripMenuItem ms_ExportSave;
        private ToolStripMenuItem ms_RenameSave;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ms_QuitApplication;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem ms_WhatToDo;
        private ToolStripMenuItem ms_WhoMade;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private OpenFileDialog OpenFileDialog;
        private GroupBox groupBox1;
        private ComboBox cbx_KoboldSelection;
        private ColorDialog ColourPickDialog;
        private NumericUpDown updn_KoboldMaxEnergy;
        private Label lbl_KoboldMaxEnergy;
        private Label label2;
        private NumericUpDown updn_KoboldFatSize;
        private Label label1;
        private NumericUpDown updn_KoboldBaseSize;
        private Label label7;
        private NumericUpDown updn_KoboldGrabCount;
        private Label label6;
        private NumericUpDown updn_KoboldBellySize;
        private Label label5;
        private NumericUpDown updn_KoboldBreastSize;
        private Label label4;
        private NumericUpDown updn_KoboldDickSize;
        private Label label3;
        private NumericUpDown updn_KoboldBallSize;
        private GroupBox groupBox2;
        private Label label8;
        private NumericUpDown updn_KoboldMoney;
        private Label label16;
        private Label label14;
        private NumericUpDown updn_KoboldDickEquip;
        private Label label15;
        private NumericUpDown updn_KoboldMetabolizeCapacity;
        private CheckBox cbx_PlayerControlled;
        private Label label9;
        private NumericUpDown updn_Bri;
        private NumericUpDown updn_Sat;
        private NumericUpDown updn_Hue;
        private Label label11;
        private SaveFileDialog SaveFileDialog;
    }
}