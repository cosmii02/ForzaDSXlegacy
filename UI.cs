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
		protected IConfiguration config;
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

			this.mainTabControl.Visible = false;
			this.connectionPanel.Visible = true;

			// Starts the background Worker
			this.connectionWorker.RunWorkerAsync();
        }

		public void LoadSettings()
		{
			// Build a config object, using env vars and JSON providers.
			config = new ConfigurationBuilder()
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

			SetupUI();
		}

		#region Workers
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
				this.mainTabControl.Visible = true;
				this.connectionPanel.Visible = false;
			}
			else
			{
				//MessageBox.Show(
				//	$"The Program is running. Please set the Forza data out to 127.0.0.1, port {Program.settings.FORZA_PORT} and verify the DualSenseX UDP Port is set to {Program.settings.DSX_PORT}",
				//	"Check Ports",
				//	MessageBoxButtons.OK);

				this.mainTabControl.Visible = true;
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
		#endregion

		#region UI Forms control
		void SetupUI()
		{
			// Misc panel
			this.rpmTrackBar.Value = DenormalizeValue(currentSettings.RPM_REDLINE_RATIO);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;

			this.appCheckBox.Checked = currentSettings.DISABLE_APP_CHECK;
			this.dsxNumericUpDown.Value = currentSettings.DSX_PORT;
			this.forzaPortNumericUpDown.Value = currentSettings.FORZA_PORT;

			// Brake Panel
			this.brakeEffectIntensityTrackBar.Value = DenormalizeValue(currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY);
			this.gripLossTrackBar.Value = DenormalizeValue(currentSettings.GRIP_LOSS_VAL);
			this.brakeVibrationStartTrackBar.Value = currentSettings.BRAKE_VIBRATION_START;
			this.brakeVibrationModeTrackBar.Value = currentSettings.BRAKE_VIBRATION__MODE_START;
			this.minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_VIBRATION;
			this.maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_VIBRATION;
			this.vibrationSmoothingTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_BRAKE_FREQ, 500.0f);
			this.minBrakeStiffnessTrackBar.Value = currentSettings.MIN_BRAKE_STIFFNESS;
			this.maxBrakeStiffnessTrackBar.Value = currentSettings.MAX_BRAKE_STIFFNESS;
			this.minBrakeResistanceTrackBar.Value = currentSettings.MIN_BRAKE_RESISTANCE;
			this.maxBrakeResistanceTrackBar.Value = currentSettings.MAX_BRAKE_RESISTANCE;
			this.brakeResistanceSmoothingTrackBar.Value = DenormalizeValue(currentSettings.EWMA_ALPHA_BRAKE, 500.0f);

			this.brakeEffectNumericUpDown.Value = this.brakeEffectIntensityTrackBar.Value;
			this.gripLossNumericUpDown.Value = this.gripLossTrackBar.Value;
			this.brakeVibrationStartNumericUpDown.Value = this.brakeVibrationStartTrackBar.Value;
			this.brakeVibrationModeNumericUpDown.Value = this.brakeVibrationModeTrackBar.Value;
			this.minBrakeVibrationNumericUpDown.Value = this.minBrakeVibrationTrackBar.Value;
			this.maxBrakeVibrationNumericUpDown.Value = this.maxBrakeVibrationTrackBar.Value;
			this.brakeVibrationSmoothNumericUpDown.Value = this.vibrationSmoothingTrackBar.Value;
			this.minBrakeStifnessNumericUpDown.Value = this.minBrakeStiffnessTrackBar.Value;
			this.maxBrakeStifnessNumericUpDown.Value = this.maxBrakeStiffnessTrackBar.Value;
			this.minBrakeResistanceNumericUpDown.Value = this.minBrakeResistanceTrackBar.Value;
			this.maxBrakeResistanceNumericUpDown.Value = this.maxBrakeResistanceTrackBar.Value;
			this.brakeResistanceSmoothNumericUpDown.Value = this.brakeResistanceSmoothingTrackBar.Value;

			// Throttle Panel
		}

		static int DenormalizeValue(float normalizedValue, float scale = 100.0f)
		{
			return (int)Math.Floor(normalizedValue * scale);
		}

		static float NormalizeValue(float value, float scale = 100.0f)
		{
			if (scale == 0)
				return value;

			return value / scale;
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

		#region Misc
		private void rpmTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.RPM_REDLINE_RATIO = NormalizeValue(this.rpmTrackBar.Value);
			rpmValueNumericUpDown.Value = rpmTrackBar.Value;
		}

		private void rpmValueNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.RPM_REDLINE_RATIO = NormalizeValue((float)this.rpmValueNumericUpDown.Value);
			rpmTrackBar.Value = (int)Math.Floor(rpmValueNumericUpDown.Value);
		}

		private void appCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			currentSettings.DISABLE_APP_CHECK = this.appCheckBox.Checked;
		}

		private void dsxNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.DSX_PORT = (int)Math.Floor(this.dsxNumericUpDown.Value);
		}

		private void forzaPortNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.FORZA_PORT = (int)Math.Floor(this.forzaPortNumericUpDown.Value);
		}
		#endregion

		#region Brake
		private void brakeEffectIntensityTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = NormalizeValue(brakeEffectIntensityTrackBar.Value);
			this.brakeEffectNumericUpDown.Value = brakeEffectIntensityTrackBar.Value;
		}

		private void brakeEffectNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.LEFT_TRIGGER_EFFECT_INTENSITY = NormalizeValue((float)brakeEffectNumericUpDown.Value);
			brakeEffectIntensityTrackBar.Value = (int)Math.Floor(brakeEffectNumericUpDown.Value);
		}

		private void gripLossTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.GRIP_LOSS_VAL = NormalizeValue(this.gripLossTrackBar.Value);
			gripLossNumericUpDown.Value = gripLossTrackBar.Value;
		}

		private void gripLossNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.GRIP_LOSS_VAL = NormalizeValue((float)gripLossNumericUpDown.Value);
			gripLossTrackBar.Value = (int)Math.Floor(gripLossNumericUpDown.Value);
		}

		private void brakeVibrationStartTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION_START = this.brakeVibrationStartTrackBar.Value;
			brakeVibrationStartNumericUpDown.Value = brakeVibrationStartTrackBar.Value;
		}

		private void brakeVibrationStartNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION_START = (int)Math.Floor(brakeVibrationStartNumericUpDown.Value);
			brakeVibrationStartTrackBar.Value = currentSettings.BRAKE_VIBRATION_START;
		}

		private void brakeVibrationModeTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION__MODE_START = this.brakeVibrationModeTrackBar.Value;
			brakeVibrationModeNumericUpDown.Value = brakeVibrationModeTrackBar.Value;
		}

		private void brakeVibrationModeNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.BRAKE_VIBRATION__MODE_START = (int)Math.Floor(brakeVibrationModeNumericUpDown.Value);
			brakeVibrationModeTrackBar.Value = currentSettings.BRAKE_VIBRATION__MODE_START;
		}

		private void minBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_VIBRATION = minBrakeVibrationTrackBar.Value;
			minBrakeVibrationNumericUpDown.Value = minBrakeVibrationTrackBar.Value;
		}

		private void minBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_VIBRATION = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_VIBRATION;
		}

		private void maxBrakeVibrationTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_VIBRATION = maxBrakeVibrationTrackBar.Value;
			maxBrakeVibrationNumericUpDown.Value = maxBrakeVibrationTrackBar.Value;
		}

		private void maxBrakeVibrationNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_VIBRATION = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_VIBRATION;
		}

		private void vibrationSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE_FREQ = NormalizeValue(vibrationSmoothingTrackBar.Value, 500);
			brakeVibrationSmoothNumericUpDown.Value = vibrationSmoothingTrackBar.Value;
		}

		private void brakeVibrationSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE_FREQ = NormalizeValue((float)brakeVibrationSmoothNumericUpDown.Value, 500);
			vibrationSmoothingTrackBar.Value = (int)Math.Floor(brakeVibrationSmoothNumericUpDown.Value);
		}

		private void minBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_STIFFNESS = minBrakeStiffnessTrackBar.Value;
			minBrakeStifnessNumericUpDown.Value = minBrakeStiffnessTrackBar.Value;
		}

		private void minBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MIN_BRAKE_STIFFNESS = (int)Math.Floor(minBrakeVibrationNumericUpDown.Value);
			minBrakeVibrationTrackBar.Value = currentSettings.MIN_BRAKE_STIFFNESS;
		}

		private void maxBrakeStiffnessTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_STIFFNESS = maxBrakeStiffnessTrackBar.Value;
			maxBrakeStifnessNumericUpDown.Value = maxBrakeStiffnessTrackBar.Value;
		}

		private void maxBrakeStifnessNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.MAX_BRAKE_STIFFNESS = (int)Math.Floor(maxBrakeVibrationNumericUpDown.Value);
			maxBrakeVibrationTrackBar.Value = currentSettings.MAX_BRAKE_STIFFNESS;
		}

		private void minBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = minBrakeResistanceTrackBar.Value;
			if (value > currentSettings.MAX_BRAKE_RESISTANCE)
				value = currentSettings.MAX_BRAKE_RESISTANCE;

			currentSettings.MIN_BRAKE_RESISTANCE = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void minBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(minBrakeResistanceNumericUpDown.Value);
			if (value > currentSettings.MAX_BRAKE_RESISTANCE)
				value = currentSettings.MAX_BRAKE_RESISTANCE;

			currentSettings.MIN_BRAKE_RESISTANCE = value;

			minBrakeResistanceTrackBar.Value = value;
			minBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceTrackBar_Scroll(object sender, EventArgs e)
		{
			int value = maxBrakeResistanceTrackBar.Value;
			if (value < currentSettings.MIN_BRAKE_RESISTANCE)
				value = currentSettings.MIN_BRAKE_RESISTANCE;

			currentSettings.MAX_BRAKE_RESISTANCE = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void maxBrakeResistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)Math.Floor(maxBrakeResistanceNumericUpDown.Value);
			if (value < currentSettings.MIN_BRAKE_RESISTANCE)
				value = currentSettings.MIN_BRAKE_RESISTANCE;

			currentSettings.MAX_BRAKE_RESISTANCE = value;

			maxBrakeResistanceTrackBar.Value = value;
			maxBrakeResistanceNumericUpDown.Value = value;
		}

		private void brakeResistanceSmoothingTrackBar_Scroll(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE = NormalizeValue(brakeResistanceSmoothingTrackBar.Value, 500);
			brakeResistanceSmoothNumericUpDown.Value = brakeResistanceSmoothingTrackBar.Value;
		}

		private void brakeResistanceSmoothNumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			currentSettings.EWMA_ALPHA_BRAKE = NormalizeValue((float)brakeResistanceSmoothNumericUpDown.Value, 500);
			brakeResistanceSmoothingTrackBar.Value = (int)Math.Floor(brakeResistanceSmoothNumericUpDown.Value);
		}
		#endregion

		#region Throttle
		#endregion

		#endregion
	}
}
