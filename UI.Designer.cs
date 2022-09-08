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
			this.mainWorker = new System.ComponentModel.BackgroundWorker();
			this.connectionWorker = new System.ComponentModel.BackgroundWorker();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusDSX = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusForza = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripVerboseMode = new System.Windows.Forms.ToolStripDropDownButton();
			this.verboseModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verboseModeOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.outputListBox = new System.Windows.Forms.ListBox();
			this.connectionPanel = new System.Windows.Forms.Panel();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.connectionPanel.SuspendLayout();
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
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusDSX,
            this.toolStripStatusForza,
            this.toolStripVerboseMode});
			this.statusStrip1.Location = new System.Drawing.Point(0, 481);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(616, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
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
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(616, 481);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(616, 481);
			this.panel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ForzaDSX.Properties.Resources.SpinnerGif;
			this.pictureBox1.Location = new System.Drawing.Point(174, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Connecting to Forza and DSX";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(616, 475);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Visible = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.flowLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(608, 447);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Configuration";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 441);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.outputListBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(608, 447);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Output";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// outputListBox
			// 
			this.outputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputListBox.FormattingEnabled = true;
			this.outputListBox.ItemHeight = 15;
			this.outputListBox.Location = new System.Drawing.Point(3, 10);
			this.outputListBox.Name = "outputListBox";
			this.outputListBox.Size = new System.Drawing.Size(599, 424);
			this.outputListBox.TabIndex = 0;
			// 
			// connectionPanel
			// 
			this.connectionPanel.Controls.Add(this.panel2);
			this.connectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.connectionPanel.Location = new System.Drawing.Point(0, 0);
			this.connectionPanel.Name = "connectionPanel";
			this.connectionPanel.Size = new System.Drawing.Size(616, 481);
			this.connectionPanel.TabIndex = 2;
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 503);
			this.Controls.Add(this.connectionPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "UI";
			this.Text = "UI";
			this.Load += new System.EventHandler(this.UI_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.connectionPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.ComponentModel.BackgroundWorker mainWorker;
        private System.ComponentModel.BackgroundWorker connectionWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDSX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusForza;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListBox outputListBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel connectionPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripVerboseMode;
		private System.Windows.Forms.ToolStripMenuItem verboseModeOffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verboseModeOnToolStripMenuItem;
	}
}