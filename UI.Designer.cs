using System;
using System.ComponentModel;

namespace ForzaDSX
{
    partial class UI
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
			this.mainWorker = new System.ComponentModel.BackgroundWorker();
			this.connectionWorker = new System.ComponentModel.BackgroundWorker();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.miscTabPage = new System.Windows.Forms.TabPage();
			this.miscTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.forzaPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.forzaPortLabel = new System.Windows.Forms.Label();
			this.dsxPortLabel = new System.Windows.Forms.Label();
			this.appCheckLabel = new System.Windows.Forms.Label();
			this.rpmLabel = new System.Windows.Forms.Label();
			this.rpmTrackBar = new System.Windows.Forms.TrackBar();
			this.appCheckBox = new System.Windows.Forms.CheckBox();
			this.dsxNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.rpmValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeConfigTabPage = new System.Windows.Forms.TabPage();
			this.brakeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.brakeResistanceSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeResistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeStifnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationSmoothNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.minBrakeVibrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationModeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeVibrationStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.gripLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeEffectNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.brakeResistanceSmoothingTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeResistanceSmoothingLabel = new System.Windows.Forms.Label();
			this.maxBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeResistanceLabel = new System.Windows.Forms.Label();
			this.minBrakeResistanceTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeResistanceLabel = new System.Windows.Forms.Label();
			this.maxBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeStiffnessLabel = new System.Windows.Forms.Label();
			this.minBrakeStiffnessTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeStiffnessLabel = new System.Windows.Forms.Label();
			this.vibrationSmoothingTrackBar = new System.Windows.Forms.TrackBar();
			this.vibrationSmoothingLabel = new System.Windows.Forms.Label();
			this.maxBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.maxBrakeVibrationLabel = new System.Windows.Forms.Label();
			this.minBrakeVibrationTrackBar = new System.Windows.Forms.TrackBar();
			this.minBrakeVibrationLabel = new System.Windows.Forms.Label();
			this.brakeVibrationModeTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeVibrationModeStartLabel = new System.Windows.Forms.Label();
			this.brakeVibrationStartTrackBar = new System.Windows.Forms.TrackBar();
			this.brakeVibrationStartLabel = new System.Windows.Forms.Label();
			this.gripLossTrackBar = new System.Windows.Forms.TrackBar();
			this.gripLossLabel = new System.Windows.Forms.Label();
			this.brakeEffectIntensityLabel = new System.Windows.Forms.Label();
			this.brakeEffectIntensityTrackBar = new System.Windows.Forms.TrackBar();
			this.throttleConfigTabPage = new System.Windows.Forms.TabPage();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.outputListBox = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.connectionPanel = new System.Windows.Forms.Panel();
			this.toolStripStatusDSX = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusForza = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripVerboseMode = new System.Windows.Forms.ToolStripDropDownButton();
			this.verboseModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verboseModeOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.mainPanel.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.miscTabPage.SuspendLayout();
			this.miscTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.forzaPortNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsxNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmValueNumericUpDown)).BeginInit();
			this.brakeConfigTabPage.SuspendLayout();
			this.brakeTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStifnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStifnessNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationSmoothNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothingTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStiffnessTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vibrationSmoothingTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectIntensityTrackBar)).BeginInit();
			this.outputTabPage.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.connectionPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainWorker
			// 
			this.mainWorker.WorkerReportsProgress = true;
			this.mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.forzaDSXWorker_DoWork);
			this.mainWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.forzaDSXWorker_ReportProgress);
			this.mainWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.forzaDSXWorker_RunWorkerCompleted);
			// 
			// connectionWorker
			// 
			this.connectionWorker.WorkerReportsProgress = true;
			this.connectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.connectionWorker_DoWork);
			this.connectionWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.connectionWorker_ReportProgress);
			this.connectionWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.connectionWorker_RunWorkerCompleted);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.mainTabControl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(627, 425);
			this.mainPanel.TabIndex = 0;
			// 
			// mainTabControl
			// 
			this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainTabControl.Controls.Add(this.miscTabPage);
			this.mainTabControl.Controls.Add(this.brakeConfigTabPage);
			this.mainTabControl.Controls.Add(this.throttleConfigTabPage);
			this.mainTabControl.Controls.Add(this.outputTabPage);
			this.mainTabControl.Location = new System.Drawing.Point(0, 3);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(627, 397);
			this.mainTabControl.TabIndex = 0;
			this.mainTabControl.Visible = false;
			// 
			// miscTabPage
			// 
			this.miscTabPage.Controls.Add(this.miscTableLayoutPanel);
			this.miscTabPage.Location = new System.Drawing.Point(4, 24);
			this.miscTabPage.Name = "miscTabPage";
			this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.miscTabPage.Size = new System.Drawing.Size(619, 369);
			this.miscTabPage.TabIndex = 3;
			this.miscTabPage.Text = "Misc";
			this.miscTabPage.UseVisualStyleBackColor = true;
			// 
			// miscTableLayoutPanel
			// 
			this.miscTableLayoutPanel.AutoScroll = true;
			this.miscTableLayoutPanel.AutoSize = true;
			this.miscTableLayoutPanel.ColumnCount = 3;
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.miscTableLayoutPanel.Controls.Add(this.forzaPortNumericUpDown, 1, 3);
			this.miscTableLayoutPanel.Controls.Add(this.forzaPortLabel, 0, 3);
			this.miscTableLayoutPanel.Controls.Add(this.dsxPortLabel, 0, 2);
			this.miscTableLayoutPanel.Controls.Add(this.appCheckLabel, 0, 1);
			this.miscTableLayoutPanel.Controls.Add(this.rpmLabel, 0, 0);
			this.miscTableLayoutPanel.Controls.Add(this.rpmTrackBar, 1, 0);
			this.miscTableLayoutPanel.Controls.Add(this.appCheckBox, 1, 1);
			this.miscTableLayoutPanel.Controls.Add(this.dsxNumericUpDown, 1, 2);
			this.miscTableLayoutPanel.Controls.Add(this.rpmValueNumericUpDown, 2, 0);
			this.miscTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.miscTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.miscTableLayoutPanel.Name = "miscTableLayoutPanel";
			this.miscTableLayoutPanel.RowCount = 5;
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.miscTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.miscTableLayoutPanel.Size = new System.Drawing.Size(613, 363);
			this.miscTableLayoutPanel.TabIndex = 0;
			// 
			// forzaPortNumericUpDown
			// 
			this.forzaPortNumericUpDown.AutoSize = true;
			this.forzaPortNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.forzaPortNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forzaPortNumericUpDown.Location = new System.Drawing.Point(120, 103);
			this.forzaPortNumericUpDown.Maximum = new decimal(new int[] {
            65353,
            0,
            0,
            0});
			this.forzaPortNumericUpDown.MaximumSize = new System.Drawing.Size(100, 0);
			this.forzaPortNumericUpDown.Name = "forzaPortNumericUpDown";
			this.forzaPortNumericUpDown.Size = new System.Drawing.Size(100, 23);
			this.forzaPortNumericUpDown.TabIndex = 7;
			this.toolTip.SetToolTip(this.forzaPortNumericUpDown, "Port for Forza UDP server");
			this.forzaPortNumericUpDown.ValueChanged += new System.EventHandler(this.forzaPortNumericUpDown_ValueChanged);
			// 
			// forzaPortLabel
			// 
			this.forzaPortLabel.AutoSize = true;
			this.forzaPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forzaPortLabel.Location = new System.Drawing.Point(3, 100);
			this.forzaPortLabel.Name = "forzaPortLabel";
			this.forzaPortLabel.Size = new System.Drawing.Size(111, 29);
			this.forzaPortLabel.TabIndex = 6;
			this.forzaPortLabel.Text = "Forza Port";
			this.forzaPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.forzaPortLabel, "Port for Forza UDP server");
			// 
			// dsxPortLabel
			// 
			this.dsxPortLabel.AutoSize = true;
			this.dsxPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dsxPortLabel.Location = new System.Drawing.Point(3, 71);
			this.dsxPortLabel.Name = "dsxPortLabel";
			this.dsxPortLabel.Size = new System.Drawing.Size(111, 29);
			this.dsxPortLabel.TabIndex = 4;
			this.dsxPortLabel.Text = "DSX Port";
			this.dsxPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.dsxPortLabel, "Port for DSX Port Listener");
			// 
			// appCheckLabel
			// 
			this.appCheckLabel.AutoSize = true;
			this.appCheckLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appCheckLabel.Location = new System.Drawing.Point(3, 51);
			this.appCheckLabel.Name = "appCheckLabel";
			this.appCheckLabel.Size = new System.Drawing.Size(111, 20);
			this.appCheckLabel.TabIndex = 2;
			this.appCheckLabel.Text = "Disable App Check?";
			this.appCheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.appCheckLabel, "Should we disable the check for running applications?");
			// 
			// rpmLabel
			// 
			this.rpmLabel.AutoSize = true;
			this.rpmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			this.rpmLabel.Location = new System.Drawing.Point(3, 0);
			this.rpmLabel.Name = "rpmLabel";
			this.rpmLabel.Size = new System.Drawing.Size(111, 51);
			this.rpmLabel.TabIndex = 0;
			this.rpmLabel.Text = "RPM Redline Ratio";
			this.rpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.rpmLabel, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			// 
			// rpmTrackBar
			// 
			this.rpmTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rpmTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
			this.rpmTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmTrackBar.LargeChange = 50;
			this.rpmTrackBar.Location = new System.Drawing.Point(120, 3);
			this.rpmTrackBar.Maximum = 100;
			this.rpmTrackBar.Name = "rpmTrackBar";
			this.rpmTrackBar.Size = new System.Drawing.Size(415, 45);
			this.rpmTrackBar.TabIndex = 1;
			this.rpmTrackBar.TickFrequency = 5;
			this.rpmTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.rpmTrackBar, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.rpmTrackBar.Scroll += new System.EventHandler(this.rpmTrackBar_Scroll);
			// 
			// appCheckBox
			// 
			this.appCheckBox.AutoSize = true;
			this.appCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appCheckBox.Location = new System.Drawing.Point(120, 54);
			this.appCheckBox.Name = "appCheckBox";
			this.appCheckBox.Size = new System.Drawing.Size(415, 14);
			this.appCheckBox.TabIndex = 3;
			this.toolTip.SetToolTip(this.appCheckBox, "Should we disable the check for running applications?");
			this.appCheckBox.UseVisualStyleBackColor = true;
			this.appCheckBox.CheckedChanged += new System.EventHandler(this.appCheckBox_CheckedChanged);
			// 
			// dsxNumericUpDown
			// 
			this.dsxNumericUpDown.AutoSize = true;
			this.dsxNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.dsxNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dsxNumericUpDown.Location = new System.Drawing.Point(120, 74);
			this.dsxNumericUpDown.Maximum = new decimal(new int[] {
            65353,
            0,
            0,
            0});
			this.dsxNumericUpDown.MaximumSize = new System.Drawing.Size(100, 0);
			this.dsxNumericUpDown.Name = "dsxNumericUpDown";
			this.dsxNumericUpDown.Size = new System.Drawing.Size(100, 23);
			this.dsxNumericUpDown.TabIndex = 5;
			this.toolTip.SetToolTip(this.dsxNumericUpDown, "Port for DSX Port Listener");
			this.dsxNumericUpDown.ValueChanged += new System.EventHandler(this.dsxNumericUpDown_ValueChanged);
			// 
			// rpmValueNumericUpDown
			// 
			this.rpmValueNumericUpDown.AutoSize = true;
			this.rpmValueNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.rpmValueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpmValueNumericUpDown.Location = new System.Drawing.Point(541, 3);
			this.rpmValueNumericUpDown.Name = "rpmValueNumericUpDown";
			this.rpmValueNumericUpDown.Size = new System.Drawing.Size(69, 23);
			this.rpmValueNumericUpDown.TabIndex = 8;
			this.toolTip.SetToolTip(this.rpmValueNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.rpmValueNumericUpDown.ValueChanged += new System.EventHandler(this.rpmValueNumericUpDown_ValueChanged);
			// 
			// brakeConfigTabPage
			// 
			this.brakeConfigTabPage.Controls.Add(this.brakeTableLayoutPanel);
			this.brakeConfigTabPage.Location = new System.Drawing.Point(4, 24);
			this.brakeConfigTabPage.Name = "brakeConfigTabPage";
			this.brakeConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.brakeConfigTabPage.Size = new System.Drawing.Size(619, 369);
			this.brakeConfigTabPage.TabIndex = 0;
			this.brakeConfigTabPage.Text = "Brake Trigger";
			this.brakeConfigTabPage.UseVisualStyleBackColor = true;
			// 
			// brakeTableLayoutPanel
			// 
			this.brakeTableLayoutPanel.AutoScroll = true;
			this.brakeTableLayoutPanel.AutoSize = true;
			this.brakeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.brakeTableLayoutPanel.ColumnCount = 3;
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothNumericUpDown, 2, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceNumericUpDown, 2, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceNumericUpDown, 2, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStifnessNumericUpDown, 2, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStifnessNumericUpDown, 2, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationSmoothNumericUpDown, 2, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationNumericUpDown, 2, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationNumericUpDown, 2, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeNumericUpDown, 2, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartNumericUpDown, 2, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossNumericUpDown, 2, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectNumericUpDown, 2, 0);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothingTrackBar, 1, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeResistanceSmoothingLabel, 0, 11);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceTrackBar, 1, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeResistanceLabel, 0, 10);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceTrackBar, 1, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeResistanceLabel, 0, 9);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStiffnessTrackBar, 1, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeStiffnessLabel, 0, 8);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStiffnessTrackBar, 1, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeStiffnessLabel, 0, 7);
			this.brakeTableLayoutPanel.Controls.Add(this.vibrationSmoothingTrackBar, 1, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.vibrationSmoothingLabel, 0, 6);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationTrackBar, 1, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.maxBrakeVibrationLabel, 0, 5);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationTrackBar, 1, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.minBrakeVibrationLabel, 0, 4);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeTrackBar, 1, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationModeStartLabel, 0, 3);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartTrackBar, 1, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeVibrationStartLabel, 0, 2);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossTrackBar, 1, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.gripLossLabel, 0, 1);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectIntensityLabel, 0, 0);
			this.brakeTableLayoutPanel.Controls.Add(this.brakeEffectIntensityTrackBar, 1, 0);
			this.brakeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.brakeTableLayoutPanel.Name = "brakeTableLayoutPanel";
			this.brakeTableLayoutPanel.RowCount = 13;
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.brakeTableLayoutPanel.Size = new System.Drawing.Size(613, 363);
			this.brakeTableLayoutPanel.TabIndex = 0;
			// 
			// brakeResistanceSmoothNumericUpDown
			// 
			this.brakeResistanceSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeResistanceSmoothNumericUpDown.AutoSize = true;
			this.brakeResistanceSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeResistanceSmoothNumericUpDown.Location = new System.Drawing.Point(541, 575);
			this.brakeResistanceSmoothNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.Name = "brakeResistanceSmoothNumericUpDown";
			this.brakeResistanceSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeResistanceSmoothNumericUpDown.TabIndex = 36;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothNumericUpDown, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			this.brakeResistanceSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeResistanceSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.brakeResistanceSmoothNumericUpDown_ValueChanged);
			// 
			// maxBrakeResistanceNumericUpDown
			// 
			this.maxBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeResistanceNumericUpDown.AutoSize = true;
			this.maxBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(541, 524);
			this.maxBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.maxBrakeResistanceNumericUpDown.Name = "maxBrakeResistanceNumericUpDown";
			this.maxBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.maxBrakeResistanceNumericUpDown.TabIndex = 35;
			this.toolTip.SetToolTip(this.maxBrakeResistanceNumericUpDown, "The Maximum resistance on the Brake (0-7)");
			this.maxBrakeResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeResistanceNumericUpDown_ValueChanged);
			// 
			// minBrakeResistanceNumericUpDown
			// 
			this.minBrakeResistanceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeResistanceNumericUpDown.AutoSize = true;
			this.minBrakeResistanceNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeResistanceNumericUpDown.Location = new System.Drawing.Point(541, 473);
			this.minBrakeResistanceNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.minBrakeResistanceNumericUpDown.Name = "minBrakeResistanceNumericUpDown";
			this.minBrakeResistanceNumericUpDown.Size = new System.Drawing.Size(29, 23);
			this.minBrakeResistanceNumericUpDown.TabIndex = 34;
			this.toolTip.SetToolTip(this.minBrakeResistanceNumericUpDown, "The Minimum resistance on the Brake (0-7)");
			this.minBrakeResistanceNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeResistanceNumericUpDown_ValueChanged);
			// 
			// maxBrakeStifnessNumericUpDown
			// 
			this.maxBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeStifnessNumericUpDown.AutoSize = true;
			this.maxBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(541, 422);
			this.maxBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.Name = "maxBrakeStifnessNumericUpDown";
			this.maxBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.maxBrakeStifnessNumericUpDown.TabIndex = 33;
			this.toolTip.SetToolTip(this.maxBrakeStifnessNumericUpDown, "On a scale of 1-200 with 1 being most stiff");
			this.maxBrakeStifnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxBrakeStifnessNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeStifnessNumericUpDown_ValueChanged);
			// 
			// minBrakeStifnessNumericUpDown
			// 
			this.minBrakeStifnessNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeStifnessNumericUpDown.AutoSize = true;
			this.minBrakeStifnessNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeStifnessNumericUpDown.Location = new System.Drawing.Point(541, 371);
			this.minBrakeStifnessNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.Name = "minBrakeStifnessNumericUpDown";
			this.minBrakeStifnessNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.minBrakeStifnessNumericUpDown.TabIndex = 32;
			this.toolTip.SetToolTip(this.minBrakeStifnessNumericUpDown, "On a scale of 1-200 with 1 being most stiff");
			this.minBrakeStifnessNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.minBrakeStifnessNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeStifnessNumericUpDown_ValueChanged);
			// 
			// brakeVibrationSmoothNumericUpDown
			// 
			this.brakeVibrationSmoothNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationSmoothNumericUpDown.AutoSize = true;
			this.brakeVibrationSmoothNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationSmoothNumericUpDown.Location = new System.Drawing.Point(541, 320);
			this.brakeVibrationSmoothNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.Name = "brakeVibrationSmoothNumericUpDown";
			this.brakeVibrationSmoothNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationSmoothNumericUpDown.TabIndex = 31;
			this.toolTip.SetToolTip(this.brakeVibrationSmoothNumericUpDown, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			this.brakeVibrationSmoothNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.brakeVibrationSmoothNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationSmoothNumericUpDown_ValueChanged);
			// 
			// maxBrakeVibrationNumericUpDown
			// 
			this.maxBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maxBrakeVibrationNumericUpDown.AutoSize = true;
			this.maxBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.maxBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(541, 269);
			this.maxBrakeVibrationNumericUpDown.Name = "maxBrakeVibrationNumericUpDown";
			this.maxBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.maxBrakeVibrationNumericUpDown.TabIndex = 30;
			this.toolTip.SetToolTip(this.maxBrakeVibrationNumericUpDown, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			this.maxBrakeVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.maxBrakeVibrationNumericUpDown_ValueChanged);
			// 
			// minBrakeVibrationNumericUpDown
			// 
			this.minBrakeVibrationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.minBrakeVibrationNumericUpDown.AutoSize = true;
			this.minBrakeVibrationNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minBrakeVibrationNumericUpDown.Location = new System.Drawing.Point(541, 218);
			this.minBrakeVibrationNumericUpDown.Name = "minBrakeVibrationNumericUpDown";
			this.minBrakeVibrationNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.minBrakeVibrationNumericUpDown.TabIndex = 29;
			this.toolTip.SetToolTip(this.minBrakeVibrationNumericUpDown, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			this.minBrakeVibrationNumericUpDown.ValueChanged += new System.EventHandler(this.minBrakeVibrationNumericUpDown_ValueChanged);
			// 
			// brakeVibrationModeNumericUpDown
			// 
			this.brakeVibrationModeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationModeNumericUpDown.AutoSize = true;
			this.brakeVibrationModeNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationModeNumericUpDown.Location = new System.Drawing.Point(541, 167);
			this.brakeVibrationModeNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.brakeVibrationModeNumericUpDown.Name = "brakeVibrationModeNumericUpDown";
			this.brakeVibrationModeNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationModeNumericUpDown.TabIndex = 28;
			this.toolTip.SetToolTip(this.brakeVibrationModeNumericUpDown, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			this.brakeVibrationModeNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationModeNumericUpDown_ValueChanged);
			// 
			// brakeVibrationStartNumericUpDown
			// 
			this.brakeVibrationStartNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeVibrationStartNumericUpDown.AutoSize = true;
			this.brakeVibrationStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeVibrationStartNumericUpDown.Location = new System.Drawing.Point(541, 116);
			this.brakeVibrationStartNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.brakeVibrationStartNumericUpDown.Name = "brakeVibrationStartNumericUpDown";
			this.brakeVibrationStartNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeVibrationStartNumericUpDown.TabIndex = 27;
			this.toolTip.SetToolTip(this.brakeVibrationStartNumericUpDown, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			this.brakeVibrationStartNumericUpDown.ValueChanged += new System.EventHandler(this.brakeVibrationStartNumericUpDown_ValueChanged);
			// 
			// gripLossNumericUpDown
			// 
			this.gripLossNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.gripLossNumericUpDown.AutoSize = true;
			this.gripLossNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.gripLossNumericUpDown.Location = new System.Drawing.Point(541, 65);
			this.gripLossNumericUpDown.Name = "gripLossNumericUpDown";
			this.gripLossNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.gripLossNumericUpDown.TabIndex = 26;
			this.toolTip.SetToolTip(this.gripLossNumericUpDown, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			this.gripLossNumericUpDown.ValueChanged += new System.EventHandler(this.gripLossNumericUpDown_ValueChanged);
			// 
			// brakeEffectNumericUpDown
			// 
			this.brakeEffectNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.brakeEffectNumericUpDown.AutoSize = true;
			this.brakeEffectNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.brakeEffectNumericUpDown.Location = new System.Drawing.Point(541, 14);
			this.brakeEffectNumericUpDown.Name = "brakeEffectNumericUpDown";
			this.brakeEffectNumericUpDown.Size = new System.Drawing.Size(41, 23);
			this.brakeEffectNumericUpDown.TabIndex = 2;
			this.toolTip.SetToolTip(this.brakeEffectNumericUpDown, "The percentage of the current RPM when we are in the \"redline\" of the engine");
			this.brakeEffectNumericUpDown.ValueChanged += new System.EventHandler(this.brakeEffectNumericUpDown_ValueChanged);
			// 
			// brakeResistanceSmoothingTrackBar
			// 
			this.brakeResistanceSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeResistanceSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeResistanceSmoothingTrackBar.LargeChange = 50;
			this.brakeResistanceSmoothingTrackBar.Location = new System.Drawing.Point(133, 564);
			this.brakeResistanceSmoothingTrackBar.Maximum = 500;
			this.brakeResistanceSmoothingTrackBar.Minimum = 1;
			this.brakeResistanceSmoothingTrackBar.Name = "brakeResistanceSmoothingTrackBar";
			this.brakeResistanceSmoothingTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeResistanceSmoothingTrackBar.TabIndex = 23;
			this.brakeResistanceSmoothingTrackBar.TickFrequency = 10;
			this.brakeResistanceSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothingTrackBar, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			this.brakeResistanceSmoothingTrackBar.Value = 1;
			this.brakeResistanceSmoothingTrackBar.Scroll += new System.EventHandler(this.brakeResistanceSmoothingTrackBar_Scroll);
			// 
			// brakeResistanceSmoothingLabel
			// 
			this.brakeResistanceSmoothingLabel.AutoSize = true;
			this.brakeResistanceSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeResistanceSmoothingLabel.Location = new System.Drawing.Point(3, 561);
			this.brakeResistanceSmoothingLabel.Name = "brakeResistanceSmoothingLabel";
			this.brakeResistanceSmoothingLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeResistanceSmoothingLabel.TabIndex = 22;
			this.brakeResistanceSmoothingLabel.Text = "Resistance Smoothing";
			this.brakeResistanceSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeResistanceSmoothingLabel, "Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0");
			// 
			// maxBrakeResistanceTrackBar
			// 
			this.maxBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeResistanceTrackBar.LargeChange = 50;
			this.maxBrakeResistanceTrackBar.Location = new System.Drawing.Point(133, 513);
			this.maxBrakeResistanceTrackBar.Maximum = 7;
			this.maxBrakeResistanceTrackBar.Name = "maxBrakeResistanceTrackBar";
			this.maxBrakeResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeResistanceTrackBar.TabIndex = 21;
			this.maxBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeResistanceTrackBar, "The Maximum resistance on the Brake (0-7)");
			this.maxBrakeResistanceTrackBar.Scroll += new System.EventHandler(this.maxBrakeResistanceTrackBar_Scroll);
			// 
			// maxBrakeResistanceLabel
			// 
			this.maxBrakeResistanceLabel.AutoSize = true;
			this.maxBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeResistanceLabel.Location = new System.Drawing.Point(3, 510);
			this.maxBrakeResistanceLabel.Name = "maxBrakeResistanceLabel";
			this.maxBrakeResistanceLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeResistanceLabel.TabIndex = 20;
			this.maxBrakeResistanceLabel.Text = "Max Resistance";
			this.maxBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeResistanceLabel, "The Maximum resistance on the Brake (0-7)");
			// 
			// minBrakeResistanceTrackBar
			// 
			this.minBrakeResistanceTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeResistanceTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeResistanceTrackBar.LargeChange = 50;
			this.minBrakeResistanceTrackBar.Location = new System.Drawing.Point(133, 462);
			this.minBrakeResistanceTrackBar.Maximum = 7;
			this.minBrakeResistanceTrackBar.Name = "minBrakeResistanceTrackBar";
			this.minBrakeResistanceTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeResistanceTrackBar.TabIndex = 19;
			this.minBrakeResistanceTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeResistanceTrackBar, "The Minimum resistance on the Brake (0-7)");
			this.minBrakeResistanceTrackBar.Scroll += new System.EventHandler(this.minBrakeResistanceTrackBar_Scroll);
			// 
			// minBrakeResistanceLabel
			// 
			this.minBrakeResistanceLabel.AutoSize = true;
			this.minBrakeResistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeResistanceLabel.Location = new System.Drawing.Point(3, 459);
			this.minBrakeResistanceLabel.Name = "minBrakeResistanceLabel";
			this.minBrakeResistanceLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeResistanceLabel.TabIndex = 18;
			this.minBrakeResistanceLabel.Text = "Min Resistance";
			this.minBrakeResistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeResistanceLabel, "The Minimum resistance on the Brake (0-7)");
			// 
			// maxBrakeStiffnessTrackBar
			// 
			this.maxBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeStiffnessTrackBar.LargeChange = 50;
			this.maxBrakeStiffnessTrackBar.Location = new System.Drawing.Point(133, 411);
			this.maxBrakeStiffnessTrackBar.Maximum = 200;
			this.maxBrakeStiffnessTrackBar.Minimum = 1;
			this.maxBrakeStiffnessTrackBar.Name = "maxBrakeStiffnessTrackBar";
			this.maxBrakeStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeStiffnessTrackBar.TabIndex = 17;
			this.maxBrakeStiffnessTrackBar.TickFrequency = 5;
			this.maxBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeStiffnessTrackBar, "On a scale of 1-200 with 1 being most stiff");
			this.maxBrakeStiffnessTrackBar.Value = 1;
			this.maxBrakeStiffnessTrackBar.Scroll += new System.EventHandler(this.maxBrakeStiffnessTrackBar_Scroll);
			// 
			// maxBrakeStiffnessLabel
			// 
			this.maxBrakeStiffnessLabel.AutoSize = true;
			this.maxBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 408);
			this.maxBrakeStiffnessLabel.Name = "maxBrakeStiffnessLabel";
			this.maxBrakeStiffnessLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeStiffnessLabel.TabIndex = 16;
			this.maxBrakeStiffnessLabel.Text = "Max Stiffness";
			this.maxBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeStiffnessLabel, "On a scale of 1-200 with 1 being most stiff");
			// 
			// minBrakeStiffnessTrackBar
			// 
			this.minBrakeStiffnessTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeStiffnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeStiffnessTrackBar.LargeChange = 50;
			this.minBrakeStiffnessTrackBar.Location = new System.Drawing.Point(133, 360);
			this.minBrakeStiffnessTrackBar.Maximum = 200;
			this.minBrakeStiffnessTrackBar.Minimum = 1;
			this.minBrakeStiffnessTrackBar.Name = "minBrakeStiffnessTrackBar";
			this.minBrakeStiffnessTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeStiffnessTrackBar.TabIndex = 15;
			this.minBrakeStiffnessTrackBar.TickFrequency = 5;
			this.minBrakeStiffnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeStiffnessTrackBar, "On a scale of 1-200 with 1 being most stiff");
			this.minBrakeStiffnessTrackBar.Value = 1;
			this.minBrakeStiffnessTrackBar.Scroll += new System.EventHandler(this.minBrakeStiffnessTrackBar_Scroll);
			// 
			// minBrakeStiffnessLabel
			// 
			this.minBrakeStiffnessLabel.AutoSize = true;
			this.minBrakeStiffnessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeStiffnessLabel.Location = new System.Drawing.Point(3, 357);
			this.minBrakeStiffnessLabel.Name = "minBrakeStiffnessLabel";
			this.minBrakeStiffnessLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeStiffnessLabel.TabIndex = 14;
			this.minBrakeStiffnessLabel.Text = "Min Stifness";
			this.minBrakeStiffnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeStiffnessLabel, "On a scale of 1-200 with 1 being most stiff");
			// 
			// vibrationSmoothingTrackBar
			// 
			this.vibrationSmoothingTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.vibrationSmoothingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vibrationSmoothingTrackBar.LargeChange = 50;
			this.vibrationSmoothingTrackBar.Location = new System.Drawing.Point(133, 309);
			this.vibrationSmoothingTrackBar.Maximum = 500;
			this.vibrationSmoothingTrackBar.Minimum = 1;
			this.vibrationSmoothingTrackBar.Name = "vibrationSmoothingTrackBar";
			this.vibrationSmoothingTrackBar.Size = new System.Drawing.Size(402, 45);
			this.vibrationSmoothingTrackBar.TabIndex = 13;
			this.vibrationSmoothingTrackBar.TickFrequency = 10;
			this.vibrationSmoothingTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.vibrationSmoothingTrackBar, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			this.vibrationSmoothingTrackBar.Value = 1;
			this.vibrationSmoothingTrackBar.Scroll += new System.EventHandler(this.vibrationSmoothingTrackBar_Scroll);
			// 
			// vibrationSmoothingLabel
			// 
			this.vibrationSmoothingLabel.AutoSize = true;
			this.vibrationSmoothingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vibrationSmoothingLabel.Location = new System.Drawing.Point(3, 306);
			this.vibrationSmoothingLabel.Name = "vibrationSmoothingLabel";
			this.vibrationSmoothingLabel.Size = new System.Drawing.Size(124, 51);
			this.vibrationSmoothingLabel.TabIndex = 12;
			this.vibrationSmoothingLabel.Text = "Vibration Smoothing";
			this.vibrationSmoothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.vibrationSmoothingLabel, "Smoothing for Brake Frequency output. Lower = smoother. Must be greater than 0");
			// 
			// maxBrakeVibrationTrackBar
			// 
			this.maxBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.maxBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeVibrationTrackBar.LargeChange = 50;
			this.maxBrakeVibrationTrackBar.Location = new System.Drawing.Point(133, 258);
			this.maxBrakeVibrationTrackBar.Maximum = 100;
			this.maxBrakeVibrationTrackBar.Name = "maxBrakeVibrationTrackBar";
			this.maxBrakeVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.maxBrakeVibrationTrackBar.TabIndex = 11;
			this.maxBrakeVibrationTrackBar.TickFrequency = 5;
			this.maxBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.maxBrakeVibrationTrackBar, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			this.maxBrakeVibrationTrackBar.Scroll += new System.EventHandler(this.maxBrakeVibrationTrackBar_Scroll);
			// 
			// maxBrakeVibrationLabel
			// 
			this.maxBrakeVibrationLabel.AutoSize = true;
			this.maxBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maxBrakeVibrationLabel.Location = new System.Drawing.Point(3, 255);
			this.maxBrakeVibrationLabel.Name = "maxBrakeVibrationLabel";
			this.maxBrakeVibrationLabel.Size = new System.Drawing.Size(124, 51);
			this.maxBrakeVibrationLabel.TabIndex = 10;
			this.maxBrakeVibrationLabel.Text = "Max Brake Vibration";
			this.maxBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.maxBrakeVibrationLabel, "The maximum brake frequency in Hz (avoid over 40). Correlates to better grip");
			// 
			// minBrakeVibrationTrackBar
			// 
			this.minBrakeVibrationTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.minBrakeVibrationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeVibrationTrackBar.LargeChange = 50;
			this.minBrakeVibrationTrackBar.Location = new System.Drawing.Point(133, 207);
			this.minBrakeVibrationTrackBar.Maximum = 100;
			this.minBrakeVibrationTrackBar.Name = "minBrakeVibrationTrackBar";
			this.minBrakeVibrationTrackBar.Size = new System.Drawing.Size(402, 45);
			this.minBrakeVibrationTrackBar.TabIndex = 9;
			this.minBrakeVibrationTrackBar.TickFrequency = 5;
			this.minBrakeVibrationTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.minBrakeVibrationTrackBar, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			this.minBrakeVibrationTrackBar.Scroll += new System.EventHandler(this.minBrakeVibrationTrackBar_Scroll);
			// 
			// minBrakeVibrationLabel
			// 
			this.minBrakeVibrationLabel.AutoSize = true;
			this.minBrakeVibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.minBrakeVibrationLabel.Location = new System.Drawing.Point(3, 204);
			this.minBrakeVibrationLabel.Name = "minBrakeVibrationLabel";
			this.minBrakeVibrationLabel.Size = new System.Drawing.Size(124, 51);
			this.minBrakeVibrationLabel.TabIndex = 8;
			this.minBrakeVibrationLabel.Text = "Min Brake Vibration";
			this.minBrakeVibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.minBrakeVibrationLabel, "The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in contro" +
        "ller");
			// 
			// brakeVibrationModeTrackBar
			// 
			this.brakeVibrationModeTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeVibrationModeTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationModeTrackBar.LargeChange = 50;
			this.brakeVibrationModeTrackBar.Location = new System.Drawing.Point(133, 156);
			this.brakeVibrationModeTrackBar.Maximum = 255;
			this.brakeVibrationModeTrackBar.Name = "brakeVibrationModeTrackBar";
			this.brakeVibrationModeTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeVibrationModeTrackBar.TabIndex = 7;
			this.brakeVibrationModeTrackBar.TickFrequency = 5;
			this.brakeVibrationModeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeVibrationModeTrackBar, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			this.brakeVibrationModeTrackBar.Scroll += new System.EventHandler(this.brakeVibrationModeTrackBar_Scroll);
			// 
			// brakeVibrationModeStartLabel
			// 
			this.brakeVibrationModeStartLabel.AutoSize = true;
			this.brakeVibrationModeStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationModeStartLabel.Location = new System.Drawing.Point(3, 153);
			this.brakeVibrationModeStartLabel.Name = "brakeVibrationModeStartLabel";
			this.brakeVibrationModeStartLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeVibrationModeStartLabel.TabIndex = 6;
			this.brakeVibrationModeStartLabel.Text = "Vibration Mode Start";
			this.brakeVibrationModeStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeVibrationModeStartLabel, "The depression of the brake lever at which the program should switch to vibration" +
        " mode rather than smooth resistance. This helps to avoid clicking as vibration m" +
        "ode clicks when no force is applied. ");
			// 
			// brakeVibrationStartTrackBar
			// 
			this.brakeVibrationStartTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeVibrationStartTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationStartTrackBar.LargeChange = 50;
			this.brakeVibrationStartTrackBar.Location = new System.Drawing.Point(133, 105);
			this.brakeVibrationStartTrackBar.Maximum = 255;
			this.brakeVibrationStartTrackBar.Name = "brakeVibrationStartTrackBar";
			this.brakeVibrationStartTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeVibrationStartTrackBar.TabIndex = 5;
			this.brakeVibrationStartTrackBar.TickFrequency = 5;
			this.brakeVibrationStartTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeVibrationStartTrackBar, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			this.brakeVibrationStartTrackBar.Scroll += new System.EventHandler(this.brakeVibrationStartTrackBar_Scroll);
			// 
			// brakeVibrationStartLabel
			// 
			this.brakeVibrationStartLabel.AutoSize = true;
			this.brakeVibrationStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeVibrationStartLabel.Location = new System.Drawing.Point(3, 102);
			this.brakeVibrationStartLabel.Name = "brakeVibrationStartLabel";
			this.brakeVibrationStartLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeVibrationStartLabel.TabIndex = 4;
			this.brakeVibrationStartLabel.Text = "Vibration Start";
			this.brakeVibrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeVibrationStartLabel, "The position in the Trigger (0-255) at which the brake should feel engaged with l" +
        "ow grip surfaces");
			// 
			// gripLossTrackBar
			// 
			this.gripLossTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.gripLossTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gripLossTrackBar.Location = new System.Drawing.Point(133, 54);
			this.gripLossTrackBar.Maximum = 100;
			this.gripLossTrackBar.Name = "gripLossTrackBar";
			this.gripLossTrackBar.Size = new System.Drawing.Size(402, 45);
			this.gripLossTrackBar.TabIndex = 3;
			this.gripLossTrackBar.TickFrequency = 5;
			this.gripLossTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.gripLossTrackBar, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			this.gripLossTrackBar.Value = 50;
			this.gripLossTrackBar.Scroll += new System.EventHandler(this.gripLossTrackBar_Scroll);
			// 
			// gripLossLabel
			// 
			this.gripLossLabel.AutoSize = true;
			this.gripLossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gripLossLabel.Location = new System.Drawing.Point(3, 51);
			this.gripLossLabel.Name = "gripLossLabel";
			this.gripLossLabel.Size = new System.Drawing.Size(124, 51);
			this.gripLossLabel.TabIndex = 2;
			this.gripLossLabel.Text = "Grip Loss Value";
			this.gripLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.gripLossLabel, "The point at which the brake will begin to become choppy (0 = full grip, 100 = no" +
        " grip)");
			// 
			// brakeEffectIntensityLabel
			// 
			this.brakeEffectIntensityLabel.AutoSize = true;
			this.brakeEffectIntensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeEffectIntensityLabel.Location = new System.Drawing.Point(3, 0);
			this.brakeEffectIntensityLabel.Name = "brakeEffectIntensityLabel";
			this.brakeEffectIntensityLabel.Size = new System.Drawing.Size(124, 51);
			this.brakeEffectIntensityLabel.TabIndex = 0;
			this.brakeEffectIntensityLabel.Text = "Effect Intensity";
			this.brakeEffectIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.brakeEffectIntensityLabel, "The percentage of the trigger effects");
			// 
			// brakeEffectIntensityTrackBar
			// 
			this.brakeEffectIntensityTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.brakeEffectIntensityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.brakeEffectIntensityTrackBar.LargeChange = 10;
			this.brakeEffectIntensityTrackBar.Location = new System.Drawing.Point(133, 3);
			this.brakeEffectIntensityTrackBar.Maximum = 100;
			this.brakeEffectIntensityTrackBar.Name = "brakeEffectIntensityTrackBar";
			this.brakeEffectIntensityTrackBar.Size = new System.Drawing.Size(402, 45);
			this.brakeEffectIntensityTrackBar.TabIndex = 1;
			this.brakeEffectIntensityTrackBar.TickFrequency = 5;
			this.brakeEffectIntensityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.toolTip.SetToolTip(this.brakeEffectIntensityTrackBar, "The percentage of the trigger effects");
			this.brakeEffectIntensityTrackBar.Value = 100;
			this.brakeEffectIntensityTrackBar.Scroll += new System.EventHandler(this.brakeEffectIntensityTrackBar_Scroll);
			// 
			// throttleConfigTabPage
			// 
			this.throttleConfigTabPage.Location = new System.Drawing.Point(4, 24);
			this.throttleConfigTabPage.Name = "throttleConfigTabPage";
			this.throttleConfigTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.throttleConfigTabPage.Size = new System.Drawing.Size(619, 369);
			this.throttleConfigTabPage.TabIndex = 2;
			this.throttleConfigTabPage.Text = "Throttle Trigger";
			this.throttleConfigTabPage.UseVisualStyleBackColor = true;
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.outputListBox);
			this.outputTabPage.Location = new System.Drawing.Point(4, 24);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(619, 369);
			this.outputTabPage.TabIndex = 1;
			this.outputTabPage.Text = "Output";
			this.outputTabPage.UseVisualStyleBackColor = true;
			// 
			// outputListBox
			// 
			this.outputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputListBox.FormattingEnabled = true;
			this.outputListBox.ItemHeight = 15;
			this.outputListBox.Location = new System.Drawing.Point(3, 3);
			this.outputListBox.Name = "outputListBox";
			this.outputListBox.Size = new System.Drawing.Size(613, 363);
			this.outputListBox.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(627, 425);
			this.panel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::ForzaDSX.Properties.Resources.SpinnerGif;
			this.pictureBox1.Location = new System.Drawing.Point(201, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Size = new System.Drawing.Size(138, 425);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.MinimumSize = new System.Drawing.Size(200, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
			this.label1.Size = new System.Drawing.Size(201, 85);
			this.label1.TabIndex = 0;
			this.label1.Text = "Connecting to Forza and DSX";
			// 
			// connectionPanel
			// 
			this.connectionPanel.Controls.Add(this.panel2);
			this.connectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.connectionPanel.Location = new System.Drawing.Point(0, 0);
			this.connectionPanel.Name = "connectionPanel";
			this.connectionPanel.Size = new System.Drawing.Size(627, 425);
			this.connectionPanel.TabIndex = 2;
			// 
			// toolStripStatusDSX
			// 
			this.toolStripStatusDSX.Image = global::ForzaDSX.Properties.Resources.redBtn;
			this.toolStripStatusDSX.Name = "toolStripStatusDSX";
			this.toolStripStatusDSX.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusDSX.Text = "DSX Connection:";
			this.toolStripStatusDSX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// toolStripStatusForza
			// 
			this.toolStripStatusForza.Image = global::ForzaDSX.Properties.Resources.redBtn;
			this.toolStripStatusForza.Name = "toolStripStatusForza";
			this.toolStripStatusForza.Size = new System.Drawing.Size(119, 17);
			this.toolStripStatusForza.Text = "Forza Connection:";
			this.toolStripStatusForza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// toolStripVerboseMode
			// 
			this.toolStripVerboseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripVerboseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verboseModeOffToolStripMenuItem,
            this.verboseModeOnToolStripMenuItem});
			this.toolStripVerboseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripVerboseMode.Name = "toolStripVerboseMode";
			this.toolStripVerboseMode.Size = new System.Drawing.Size(95, 20);
			this.toolStripVerboseMode.Text = "Verbose Mode";
			// 
			// verboseModeOffToolStripMenuItem
			// 
			this.verboseModeOffToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.verboseModeOffToolStripMenuItem.Name = "verboseModeOffToolStripMenuItem";
			this.verboseModeOffToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.verboseModeOffToolStripMenuItem.Text = "Verbose Mode Off";
			this.verboseModeOffToolStripMenuItem.Click += new System.EventHandler(this.verboseModeOffToolStripMenuItem_Click);
			// 
			// verboseModeOnToolStripMenuItem
			// 
			this.verboseModeOnToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.verboseModeOnToolStripMenuItem.Name = "verboseModeOnToolStripMenuItem";
			this.verboseModeOnToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.verboseModeOnToolStripMenuItem.Text = "Verbose Mode On";
			this.verboseModeOnToolStripMenuItem.Click += new System.EventHandler(this.verboseModeOnToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDSX,
            this.toolStripStatusForza,
            this.toolStripVerboseMode});
			this.statusStrip1.Location = new System.Drawing.Point(0, 425);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(627, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolTip
			// 
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 447);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.connectionPanel);
			this.Controls.Add(this.statusStrip1);
			this.MinimumSize = new System.Drawing.Size(350, 200);
			this.Name = "UI";
			this.Text = "UI";
			this.Load += new System.EventHandler(this.UI_Load);
			this.mainPanel.ResumeLayout(false);
			this.mainTabControl.ResumeLayout(false);
			this.miscTabPage.ResumeLayout(false);
			this.miscTabPage.PerformLayout();
			this.miscTableLayoutPanel.ResumeLayout(false);
			this.miscTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.forzaPortNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsxNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpmValueNumericUpDown)).EndInit();
			this.brakeConfigTabPage.ResumeLayout(false);
			this.brakeConfigTabPage.PerformLayout();
			this.brakeTableLayoutPanel.ResumeLayout(false);
			this.brakeTableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStifnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStifnessNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationSmoothNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeResistanceSmoothingTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeResistanceTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeStiffnessTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vibrationSmoothingTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxBrakeVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBrakeVibrationTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationModeTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeVibrationStartTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gripLossTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.brakeEffectIntensityTrackBar)).EndInit();
			this.outputTabPage.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.connectionPanel.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.ComponentModel.BackgroundWorker mainWorker;
        private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage brakeConfigTabPage;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.ListBox outputListBox;
		private System.Windows.Forms.Panel connectionPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage throttleConfigTabPage;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDSX;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusForza;
		private System.Windows.Forms.ToolStripDropDownButton toolStripVerboseMode;
		private System.Windows.Forms.ToolStripMenuItem verboseModeOffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verboseModeOnToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TableLayoutPanel brakeTableLayoutPanel;
		private System.Windows.Forms.Label brakeEffectIntensityLabel;
		private System.Windows.Forms.TrackBar brakeEffectIntensityTrackBar;
		private System.Windows.Forms.TabPage miscTabPage;
		private System.Windows.Forms.TableLayoutPanel miscTableLayoutPanel;
		private System.Windows.Forms.NumericUpDown forzaPortNumericUpDown;
		private System.Windows.Forms.Label forzaPortLabel;
		private System.Windows.Forms.Label dsxPortLabel;
		private System.Windows.Forms.Label appCheckLabel;
		private System.Windows.Forms.Label rpmLabel;
		private System.Windows.Forms.TrackBar rpmTrackBar;
		private System.Windows.Forms.CheckBox appCheckBox;
		private System.Windows.Forms.NumericUpDown dsxNumericUpDown;
		private System.Windows.Forms.Label gripLossLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TrackBar gripLossTrackBar;
		private System.Windows.Forms.TrackBar brakeResistanceSmoothingTrackBar;
		private System.Windows.Forms.Label brakeResistanceSmoothingLabel;
		private System.Windows.Forms.TrackBar maxBrakeResistanceTrackBar;
		private System.Windows.Forms.Label maxBrakeResistanceLabel;
		private System.Windows.Forms.TrackBar minBrakeResistanceTrackBar;
		private System.Windows.Forms.Label minBrakeResistanceLabel;
		private System.Windows.Forms.TrackBar maxBrakeStiffnessTrackBar;
		private System.Windows.Forms.Label maxBrakeStiffnessLabel;
		private System.Windows.Forms.TrackBar minBrakeStiffnessTrackBar;
		private System.Windows.Forms.Label minBrakeStiffnessLabel;
		private System.Windows.Forms.TrackBar vibrationSmoothingTrackBar;
		private System.Windows.Forms.Label vibrationSmoothingLabel;
		private System.Windows.Forms.TrackBar maxBrakeVibrationTrackBar;
		private System.Windows.Forms.Label maxBrakeVibrationLabel;
		private System.Windows.Forms.TrackBar minBrakeVibrationTrackBar;
		private System.Windows.Forms.Label minBrakeVibrationLabel;
		private System.Windows.Forms.TrackBar brakeVibrationModeTrackBar;
		private System.Windows.Forms.Label brakeVibrationModeStartLabel;
		private System.Windows.Forms.TrackBar brakeVibrationStartTrackBar;
		private System.Windows.Forms.Label brakeVibrationStartLabel;
		private System.Windows.Forms.NumericUpDown rpmValueNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeResistanceSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeResistanceNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeStifnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeStifnessNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationSmoothNumericUpDown;
		private System.Windows.Forms.NumericUpDown maxBrakeVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown minBrakeVibrationNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationModeNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeVibrationStartNumericUpDown;
		private System.Windows.Forms.NumericUpDown gripLossNumericUpDown;
		private System.Windows.Forms.NumericUpDown brakeEffectNumericUpDown;
	}
}