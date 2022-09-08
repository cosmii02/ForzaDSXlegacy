using ForzaDSX.Properties;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ForzaDSX
{
	public partial class UI : Form
    {
        protected ForzaDSXWorker forzaDSXWorker;
		protected Settings currentSettings;
		public Settings CurrentSettings { get => currentSettings; set => currentSettings = value; }

		public UI()
        {
            InitializeComponent();

			forzaDSXWorker = new ForzaDSXWorker(this);
		}
		
		void UpdateDSXConnectionStatus(bool bConnected)
		{
			toolStripStatusDSX.Image = bConnected ? Resources.greenBtn : Resources.redBtn;
		}

		void UpdateForzaConnectionStatus(bool bConnected)
		{
			toolStripStatusForza.Image = bConnected ? Resources.greenBtn : Resources.redBtn;
		}

		public void Output(string Text, bool bShowMessageBox = false)
		{
			outputListBox.Items.Insert(0, Text);

			if(outputListBox.Items.Count > 50)
			{
				outputListBox.Items.RemoveAt(50);
			}

			if(bShowMessageBox)
			{
				MessageBox.Show(Text);
			}
		}

		private void UI_Load(object sender, EventArgs e)
        {
			this.Text = "ForzaDSX version: " + Program.VERSION;

			LoadSettings();

			this.tabControl1.Visible = false;
			this.connectionPanel.Visible = true;

			// Starts the background Worker
			this.connectionWorker.RunWorkerAsync();
        }

		public void LoadSettings()
		{
			// Build a config object, using env vars and JSON providers.
			IConfiguration config = new ConfigurationBuilder()
				.AddIniFile("appsettings.ini")
				.Build();

			try
			{
				// Get values from the config given their key and their target type.
				currentSettings = new Settings();
				currentSettings = config.Get<Settings>();

				currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = Math.Clamp(currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY, 0.0f, 1.0f);
				currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY = Math.Clamp(currentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY, 0.0f, 1.0f);

				verboseModeOffToolStripMenuItem.Checked = !currentSettings.Verbose;
				verboseModeOnToolStripMenuItem.Checked = currentSettings.Verbose;
			}
			catch (Exception e)
			{
				Output("Invalid Configuration File!\n" + e.Message, true);
			}
		}


		private void connectionWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			// Start connection to DSX and Forza
			e.Result = forzaDSXWorker.ConnectToProcesses(sender as BackgroundWorker);
		}

		private void connectionWorker_ReportProgress(object sender, ProgressChangedEventArgs e)
		{
			object[] param = (object[])e.UserState;
			if ((int)param[0] == 0)
			{
				Output((string)param[1]);
			}
			else if((int)param[0] == 1)
			{
				UpdateDSXConnectionStatus((bool)param[1]);
			}
			else
			{
				UpdateForzaConnectionStatus((bool)param[1]);
			}
		}

		private void connectionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show(e.Error.Message);
			}
			else if((int)e.Result > 0)
			{
				this.tabControl1.Visible = true;
				this.connectionPanel.Visible = false;
			}
			else
			{
				//MessageBox.Show(
				//	$"The Program is running. Please set the Forza data out to 127.0.0.1, port {Program.settings.FORZA_PORT} and verify the DualSenseX UDP Port is set to {Program.settings.DSX_PORT}",
				//	"Check Ports",
				//	MessageBoxButtons.OK);

				this.tabControl1.Visible = true;
				this.connectionPanel.Visible = false;

				// Start the main worker
				mainWorker.RunWorkerAsync();
			}
		}

		private void forzaDSXWorker_DoWork(object sender, DoWorkEventArgs e)
        {
			try
			{
				forzaDSXWorker.Run(sender as BackgroundWorker);
			}
			catch (Exception exception)
			{
				e.Result = exception;

				Output("Invalid Configuration File!\n" + exception.Message, true);

				throw;
			}
        }

		private void forzaDSXWorker_ReportProgress(object sender, ProgressChangedEventArgs e)
		{
			object[] param = (object[])e.UserState;
			if ((int)param[0] == 0)
			{
				Output((string)param[1]);
			}
			// more params?
		}

		private void forzaDSXWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			if (e.Cancelled)
			{
				// The user canceled the operation.
				MessageBox.Show("Operation was canceled");
			}
			else if (e.Error != null)
			{
				// There was an error during the operation.
				string msg = String.Format("An error occurred: {0}", e.Error.Message);
				MessageBox.Show(msg);
			}
		}

		private void verboseModeOnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings.Verbose = true;
			verboseModeOffToolStripMenuItem.Checked = false;
			verboseModeOnToolStripMenuItem.Checked = true;
		}

		private void verboseModeOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			currentSettings.Verbose = false;
			verboseModeOffToolStripMenuItem.Checked = true;
			verboseModeOnToolStripMenuItem.Checked = false;
		}
	}
}
