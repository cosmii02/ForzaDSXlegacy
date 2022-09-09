using CsvHelper;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ForzaDSX
{
	public class ForzaDSXWorker
	{
		protected UI userInterface;

		int lastThrottleResistance = 1;
		int lastThrottleFreq = 0;
		int lastBrakeResistance = 200;
		int lastBrakeFreq = 0;

		uint LastValidCarClass = 0;
		int LastValidCarCPI = 0;
		float MaxCPI = 255;

		float LastEngineRPM = 0;
		// FH does not always correctly set IsRaceOn, so we must also check if the RPM info is the same for a certain ammount of time
		uint LastRPMAccumulator = 0;
		uint RPMAccumulatorTriggerRaceOff = 200;

		BackgroundWorker currentWorker;

		// Colors for Light Bar while in menus -> using car's PI colors from Forza
		public static readonly uint CarClassD = 0;
		public static readonly int[] ColorClassD = { 107, 185, 236 };
		public static readonly uint CarClassC = 1;
		public static readonly int[] ColorClassC = { 234, 202, 49 };
		public static readonly uint CarClassB = 2;
		public static readonly int[] ColorClassB = { 211, 90, 37 };
		public static readonly uint CarClassA = 3;
		public static readonly int[] ColorClassA = { 187, 59, 34 };
		public static readonly uint CarClassS1 = 4;
		public static readonly int[] ColorClassS1 = { 128, 54, 243 };
		public static readonly uint CarClassS2 = 5;
		public static readonly int[] ColorClassS2 = { 75, 88, 229 };
		public static readonly int[] ColorClassX = { 105, 182, 72 };


		public ForzaDSXWorker(UI uiRef)
		{
			userInterface = uiRef;
		}

		//This sends the data to DSX based on the input parsed data from Forza.
		//See DataPacket.cs for more details about what forza parameters can be accessed.
		//See the Enums at the bottom of this file for details about commands that can be sent to DualSenseX
		//Also see the Test Function below to see examples about those commands
		void SendData(DataPacket data/*, CsvWriter csv*/)
		{
			Packet p = new Packet();
			CsvData csvRecord = new CsvData();
			//Set the controller to do this for
			int controllerIndex = 0;

			//Initialize our array of instructions
			p.instructions = new Instruction[4];

			/* Combined variables */
			int resistance = 0;
			int filteredResistance = 0;
			float avgAccel = 0;
			int freq = 0;
			int filteredFreq = 0;

			bool bInRace = data.IsRaceOn;

			float currentRPM = data.CurrentEngineRpm;

			// FH does not always correctly set IsRaceOn, so we must also check if the RPM info is the same for a certain ammount of time
			// Also check if Power <= 0 (car is really stopped)
			if (currentRPM == LastEngineRPM
				&& data.Power <= 0)
			{
				LastRPMAccumulator++;
				if (LastRPMAccumulator > RPMAccumulatorTriggerRaceOff)
				{
					bInRace = false;
				}
			}
			else
			{
				LastRPMAccumulator = 0;
			}

			LastEngineRPM = currentRPM;

			//Get average tire slippage. This value runs from 0.0 upwards with a value of 1.0 or greater meaning total loss of grip.
			float combinedTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight) + Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 4;
			float combinedFrontTireSlip = (Math.Abs(data.TireCombinedSlipFrontLeft) + Math.Abs(data.TireCombinedSlipFrontRight)) / 2;
			float combinedRearTireSlip = (Math.Abs(data.TireCombinedSlipRearLeft) + Math.Abs(data.TireCombinedSlipRearRight)) / 2;

			uint currentClass = LastValidCarClass;
			if (data.CarClass > 0)
			{
				LastValidCarClass = currentClass = data.CarClass;
			}

			int currentCPI = LastValidCarCPI;
			if (data.CarPerformanceIndex > 0)
			{
				LastValidCarCPI = currentCPI = Math.Min((int)data.CarPerformanceIndex, 255);
			}

			// Right Trigger (index 2)
			p.instructions[2].type = InstructionType.TriggerUpdate;

			// Left Trigger
			p.instructions[0].type = InstructionType.TriggerUpdate;

			// Light Bar
			p.instructions[1].type = InstructionType.RGBUpdate;

			// No race = normal triggers
			if (!bInRace)
			{
				p.instructions[2].parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Normal, 0, 0 };
				p.instructions[0].parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Normal, 0, 0 };

				#region Light Bar color
				int CPIcolorR = 255;
				int CPIcolorG = 255;
				int CPIcolorB = 255;

				float cpiRatio = currentCPI / MaxCPI;

				if (currentClass <= CarClassD)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassD[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassD[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassD[2]);
				}
				else if (currentClass <= CarClassC)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassC[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassC[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassC[2]);
				}
				else if (currentClass <= CarClassB)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassB[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassB[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassB[2]);
				}
				else if (currentClass <= CarClassA)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassA[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassA[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassA[2]);
				}
				else if (currentClass <= CarClassS1)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassS1[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassS1[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassS1[2]);
				}
				else if (currentClass <= CarClassS2)
				{
					CPIcolorR = (int)Math.Floor(cpiRatio * ColorClassS2[0]);
					CPIcolorG = (int)Math.Floor(cpiRatio * ColorClassS2[1]);
					CPIcolorB = (int)Math.Floor(cpiRatio * ColorClassS2[2]);
				}
				else
				{
					CPIcolorR = ColorClassX[0];
					CPIcolorG = ColorClassX[1];
					CPIcolorB = ColorClassX[2];
				}

				p.instructions[1].parameters = new object[] { controllerIndex, CPIcolorR, CPIcolorG, CPIcolorB };
				#endregion

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"No race going on. Normal Triggers. Car's Class = {currentClass}; CPI = {currentCPI}; CPI Ratio = {cpiRatio}; Color [{CPIcolorR}, {CPIcolorG}, {CPIcolorB}]" });
				}
			}
			else
			{
				#region Right Trigger
				//Set the updates for the right Trigger(Throttle)

				avgAccel = (float)Math.Sqrt((userInterface.CurrentSettings.TURN_ACCEL_MOD * (data.AccelerationX * data.AccelerationX)) + (userInterface.CurrentSettings.FORWARD_ACCEL_MOD * (data.AccelerationZ * data.AccelerationZ)));

				// Define losing grip as front tires slipping or rear tires slipping while accelerating a fair ammount
				bool bLosingAccelGrip =
					combinedFrontTireSlip > userInterface.CurrentSettings.THROTTLE_GRIP_LOSS_VAL
				|| (combinedRearTireSlip > userInterface.CurrentSettings.THROTTLE_GRIP_LOSS_VAL && data.Accelerator > 200);

				// If losing grip, start to "vibrate"
				if (bLosingAccelGrip)
				{
					freq = (int)Math.Floor(Map(combinedTireSlip, userInterface.CurrentSettings.THROTTLE_GRIP_LOSS_VAL, 5, 0, userInterface.CurrentSettings.MAX_ACCEL_GRIPLOSS_VIBRATION));
					resistance = (int)Math.Floor(Map(avgAccel, 0, userInterface.CurrentSettings.ACCELRATION_LIMIT, userInterface.CurrentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS, userInterface.CurrentSettings.MAX_ACCEL_GRIPLOSS_STIFFNESS));
					//resistance = userInterface.CurrentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS - (int)Math.Floor(Map(data.Accelerator, 0, 255, userInterface.CurrentSettings.MIN_ACCEL_GRIPLOSS_STIFFNESS, userInterface.CurrentSettings.MAX_ACCEL_GRIPLOSS_STIFFNESS));
					filteredResistance = (int)Math.Floor(EWMA(resistance, lastThrottleResistance, userInterface.CurrentSettings.EWMA_ALPHA_THROTTLE) * userInterface.CurrentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY);
					filteredFreq = (int)Math.Floor(EWMA(freq, lastThrottleFreq, userInterface.CurrentSettings.EWMA_ALPHA_THROTTLE_FREQ) * userInterface.CurrentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY);

					lastThrottleResistance = filteredResistance;
					lastThrottleFreq = filteredFreq;

					if (filteredFreq <= userInterface.CurrentSettings.MIN_ACCEL_GRIPLOSS_VIBRATION
						|| data.Accelerator <= userInterface.CurrentSettings.THROTTLE_VIBRATION_MODE_START)
					{
						p.instructions[2].parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Resistance, 0, filteredResistance };

						filteredFreq = 0;
						filteredResistance = 0;
					}
					else
					{
						p.instructions[2].parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.CustomTriggerValue, CustomTriggerValueMode.VibrateResistance, filteredFreq, filteredResistance, userInterface.CurrentSettings.THROTTLE_VIBRATION_MODE_START, 0, 0, 0, 0 };
					}
					if (userInterface.CurrentSettings.Verbose)
					{
						currentWorker.ReportProgress(0, new object[] { 0, $"Setting Throttle to vibration mode with freq: {filteredFreq}, Resistance: {filteredResistance}" });
					}
				}
				else
				{
					//It should probably always be uniformly stiff
					resistance = (int)Math.Floor(Map(avgAccel, 0, userInterface.CurrentSettings.ACCELRATION_LIMIT, userInterface.CurrentSettings.MIN_THROTTLE_RESISTANCE, userInterface.CurrentSettings.MAX_THROTTLE_RESISTANCE));
					filteredResistance = (int)Math.Floor(EWMA(resistance, lastThrottleResistance, userInterface.CurrentSettings.EWMA_ALPHA_THROTTLE) * userInterface.CurrentSettings.RIGHT_TRIGGER_EFFECT_INTENSITY);

					lastThrottleResistance = filteredResistance;
					p.instructions[2].parameters = new object[] { controllerIndex, Trigger.Right, TriggerMode.Resistance, 0, filteredResistance };
				}

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Average Acceleration: {avgAccel}; Throttle Resistance: {filteredResistance}; Accelerator: {data.Accelerator}" });
				}

				#endregion
				#region Left Trigger
				//Update the left(Brake) trigger

				if (combinedTireSlip < userInterface.CurrentSettings.GRIP_LOSS_VAL && data.Brake < userInterface.CurrentSettings.BRAKE_VIBRATION__MODE_START)
				{
					freq = userInterface.CurrentSettings.MAX_BRAKE_VIBRATION - (int)Math.Floor(Map(combinedTireSlip, userInterface.CurrentSettings.GRIP_LOSS_VAL, 1, 0, userInterface.CurrentSettings.MAX_BRAKE_VIBRATION));
					resistance = userInterface.CurrentSettings.MIN_BRAKE_STIFFNESS - (int)Math.Floor(Map(data.Brake, 0, 255, userInterface.CurrentSettings.MAX_BRAKE_STIFFNESS, userInterface.CurrentSettings.MIN_BRAKE_STIFFNESS));
					filteredResistance = (int)Math.Floor(EWMA(resistance, lastBrakeResistance, userInterface.CurrentSettings.EWMA_ALPHA_BRAKE) * userInterface.CurrentSettings.LEFT_TRIGGER_EFFECT_INTENSITY);
					filteredFreq = (int)Math.Floor(EWMA(freq, lastBrakeFreq, userInterface.CurrentSettings.EWMA_ALPHA_BRAKE_FREQ) * userInterface.CurrentSettings.LEFT_TRIGGER_EFFECT_INTENSITY);
					lastBrakeFreq = filteredFreq;
					lastBrakeResistance = filteredResistance;
					if (filteredFreq <= userInterface.CurrentSettings.MIN_BRAKE_VIBRATION)
					{
						p.instructions[0].parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Resistance, 0, 0 };

					}
					else
					{
						p.instructions[0].parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.CustomTriggerValue, CustomTriggerValueMode.VibrateResistance, filteredFreq, filteredResistance, userInterface.CurrentSettings.BRAKE_VIBRATION_START, 0, 0, 0, 0 };

					}
					//Set left trigger to the custom mode VibrateResitance with values of Frequency = freq, Stiffness = 104, startPostion = 76. 
					if (userInterface.CurrentSettings.Verbose)
					{
						currentWorker.ReportProgress(0, new object[] { 0, $"Setting Brake to vibration mode with freq: {filteredFreq}, Resistance: {filteredResistance}" });
					}
				}
				else
				{
					//By default, Increasingly resistant to force
					resistance = (int)Math.Floor(Map(data.Brake, 0, 255, userInterface.CurrentSettings.MIN_BRAKE_RESISTANCE, userInterface.CurrentSettings.MAX_BRAKE_RESISTANCE));
					filteredResistance = (int)Math.Floor(EWMA(resistance, lastBrakeResistance, userInterface.CurrentSettings.EWMA_ALPHA_BRAKE) * userInterface.CurrentSettings.LEFT_TRIGGER_EFFECT_INTENSITY);
					lastBrakeResistance = filteredResistance;
					p.instructions[0].parameters = new object[] { controllerIndex, Trigger.Left, TriggerMode.Resistance, 0, filteredResistance };
				}
				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Brake: {data.Brake}; Brake Resistance: {filteredResistance}; Tire Slip: {combinedTireSlip}" });
				}
				#endregion

				#region Light Bar
				//Update the light bar
				//Currently registers intensity on the green channel based on engine RPM as a percantage of the maxium. Changes to red if RPM ratio > 80% (usually red line)
				float engineRange = data.EngineMaxRpm - data.EngineIdleRpm;
				float CurrentRPMRatio = (currentRPM - data.EngineIdleRpm) / engineRange;
				int GreenChannel = Math.Max((int)Math.Floor(CurrentRPMRatio * 255), 50);
				int RedChannel = (int)Math.Floor(CurrentRPMRatio * 255);
				if (CurrentRPMRatio >= userInterface.CurrentSettings.RPM_REDLINE_RATIO)
				{
					// Remove Green
					GreenChannel = 255 - GreenChannel;
				}

				p.instructions[1].parameters = new object[] { controllerIndex, RedChannel, GreenChannel, 0 };

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Engine RPM: {data.CurrentEngineRpm}; Engine Max RPM: {data.EngineMaxRpm}; Engine Idle RPM: {data.EngineIdleRpm}" });
				}
				#endregion
			}

			//Send the commands to DualSenseX
			Send(p);
		}

		//Maps floats from one range to another.
		public float Map(float x, float in_min, float in_max, float out_min, float out_max)
		{
			if (x > in_max)
			{
				x = in_max;
			}
			else if (x < in_min)
			{
				x = in_min;
			}
			return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
		}

		private DataPacket data;
		static UdpClient senderClient;
		static IPEndPoint endPoint;

		//Connect to DualSenseX
		void Connect()
		{
			senderClient = new UdpClient();
			var portNumber = File.ReadAllText(@"C:\Temp\DualSenseX\DualSenseX_PortNumber.txt");
			currentWorker.ReportProgress(0, new object[] { 0, "DSX is using port " + portNumber + ". Attempting to connect.." });
			int portNum = userInterface.CurrentSettings.DSX_PORT;
			if (portNumber != null)
			{
				try
				{
					portNum = Convert.ToInt32(portNumber);
				}
				catch (FormatException e)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"DSX provided a non numerical Port! Using configured default({userInterface.CurrentSettings.DSX_PORT})." });
					portNum = userInterface.CurrentSettings.DSX_PORT;
				}
			}
			else
			{
				currentWorker.ReportProgress(0, new object[] { 0, $"DSX did not provided a port value. Using configured default({userInterface.CurrentSettings.DSX_PORT})" });
			}

			endPoint = new IPEndPoint(Triggers.localhost, Convert.ToInt32(portNumber));
			try
			{
				senderClient.Connect(endPoint);
			}
			catch (Exception e)
			{
				currentWorker.ReportProgress(0, new object[] { 0, "Error Connecting: " });

				if (e is SocketException)
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Couldn't Access Port. " + e.Message });
				}
				else if (e is ObjectDisposedException)
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Connection Object Closed. Restart the Application." });
				}
				else
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Unknown Error: " + e.Message });
				}
				throw e;
			}
		}

		//Send Data to DualSenseX
		void Send(Packet data)
		{
			if (userInterface.CurrentSettings.Verbose)
			{
				currentWorker.ReportProgress(0, new object[] { 0, $"Converting Message to JSON" });
			}
			byte[] RequestData = Encoding.ASCII.GetBytes(Triggers.PacketToJson(data));
			if (userInterface.CurrentSettings.Verbose)
			{
				currentWorker.ReportProgress(0, new object[] { 0, $"{Encoding.ASCII.GetString(RequestData)}" });
			}
			try
			{
				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Sending Message to DSX..." });
				}
				senderClient.Send(RequestData, RequestData.Length);
				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Message sent to DSX" });
				}
			}
			catch (Exception e)
			{
				currentWorker.ReportProgress(0, new object[] { 0, "Error Sending Message: " });

				if (e is SocketException)
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Couldn't Access Port. " + e.Message });
					throw e;
				}
				else if (e is ObjectDisposedException)
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Connection closed. Restarting..." });
					Connect();
				}
				else
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Unknown Error: " + e.Message });

				}

			}
		}

		static IPEndPoint ipEndPoint = null;
		static UdpClient client = null;
		StreamWriter writer = null;
		CsvWriter csv = null;

		public int ConnectToProcesses(BackgroundWorker worker)
		{
			currentWorker = worker;
			try
			{
				if (!userInterface.CurrentSettings.DISABLE_APP_CHECK)
				{
					currentWorker.ReportProgress(0, new object[] { 0, "Connecting to Forza and DSX" });

					int forzaProcesses = Process.GetProcessesByName("ForzaHorizon 5").Length;
					forzaProcesses += Process.GetProcessesByName("ForzaHorizon4").Length;
					forzaProcesses += Process.GetProcessesByName("ForzaMotorsport7").Length;
					Process[] DSX = Process.GetProcessesByName("DSX");
					Process[] DSX_2 = Process.GetProcessesByName("DualsenseX");
					Process[] cur = Process.GetProcesses();
					while (forzaProcesses == 0 || DSX.Length + DSX_2.Length == 0)
					{
						currentWorker.ReportProgress(0, new object[] { 1, (DSX.Length + DSX_2.Length) > 0 });
						currentWorker.ReportProgress(0, new object[] { 2, forzaProcesses > 0 });
						
						System.Threading.Thread.Sleep(1000);
						forzaProcesses += Process.GetProcessesByName("ForzaHorizon5").Length;
						forzaProcesses += Process.GetProcessesByName("ForzaHorizon4").Length; //Guess at name
						forzaProcesses += Process.GetProcessesByName("ForzaMotorsport7").Length; //Guess at name
																								 // DSX = "DSX" or "DualSenseX"
						DSX = Process.GetProcessesByName("DSX");
						DSX_2 = Process.GetProcessesByName("DualsenseX");
					}
					
					currentWorker.ReportProgress(0, new object[] { 0, "Forza and DSX are running. Let's Go! Version: " + Program.VERSION });

					currentWorker.ReportProgress(0, new object[] { 1, true });
					currentWorker.ReportProgress(0, new object[] { 2, true });
				}

				//Connect to DualSenseX
				Connect();

				//Connect to Forza
				ipEndPoint = new IPEndPoint(IPAddress.Loopback, userInterface.CurrentSettings.FORZA_PORT);
				client = new UdpClient(userInterface.CurrentSettings.FORZA_PORT);

				currentWorker.ReportProgress(0, new object[] { 0, $"The Program is running. Please set the Forza data out to 127.0.0.1, port {userInterface.CurrentSettings.FORZA_PORT} and verify the DualSenseX UDP Port is set to {userInterface.CurrentSettings.DSX_PORT}" });
			}
			catch (Exception e)
			{
				currentWorker.ReportProgress(0, new object[] { 0, "Application encountered an exception: " + e.Message });

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Cleaning Up" });
				}
				if (client != null)
				{
					client.Close();
					client.Dispose();
				}
				if (senderClient != null)
				{
					senderClient.Close();
					senderClient.Dispose();
				}
				if (csv != null)
				{
					csv.Dispose();
				}
				if (writer != null)
				{
					writer.Flush();
					writer.Close();

				}

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Cleanup Finished. Exiting..." });
				}

				throw e;
			}
			return 0;

		}

		public struct UdpState
		{
			public UdpClient u;
			public IPEndPoint e;

			public UdpState(UdpClient u, IPEndPoint e)
			{
				this.u = u;
				this.e = e;
			}
		}

		public int Run(BackgroundWorker worker)
		{
			currentWorker = worker;
			try
			{
				UdpReceiveResult receive;

				//Main loop, go until killed
				while (true)
				{
					//If Forza sends an update
					var resultBuffer = client.Receive(ref ipEndPoint);
					//receive = await client.ReceiveAsync();
					if (userInterface.CurrentSettings.Verbose)
					{
						currentWorker.ReportProgress(0, new object[] { 0, "recieved Message from Forza!" });
					}
					//parse data
					//var resultBuffer = receive.Buffer;
					if (!AdjustToBufferType(resultBuffer.Length))
					{
						//  return;
					}
					data = null;
					data = ParseData(resultBuffer);
					if (userInterface.CurrentSettings.Verbose)
					{
						currentWorker.ReportProgress(0, new object[] { 0, "Data Parsed" });
					}

					//Process and send data to DualSenseX
					SendData(data/*, csv*/);
				}
			}
			catch (Exception e)
			{
				currentWorker.ReportProgress(0, new object[] { 0, "Application encountered an exception: " + e.Message });
				throw e;
			}
			finally
			{
				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Cleaning Up" });
				}
				if (client != null)
				{
					client.Close();
					client.Dispose();
				}
				if (senderClient != null)
				{
					senderClient.Close();
					senderClient.Dispose();
				}
				if (csv != null)
				{
					csv.Dispose();
				}
				if (writer != null)
				{
					writer.Flush();
					writer.Close();

				}

				if (userInterface.CurrentSettings.Verbose)
				{
					currentWorker.ReportProgress(0, new object[] { 0, $"Cleanup Finished. Exiting..." });
				}

			}
			return 0;
		}

		static float EWMA(float input, float last, float alpha)
		{
			return (alpha * input) + (1 - alpha) * last;
		}
		static int EWMA(int input, int last, float alpha)
		{
			return (int)Math.Floor(EWMA((float)input, (float)last, alpha));
		}

		//Parses data from Forza into a DataPacket
		DataPacket ParseData(byte[] packet)
		{
			DataPacket data = new DataPacket();

			// sled
			data.IsRaceOn = packet.IsRaceOn();
			data.TimestampMS = packet.TimestampMs();
			data.EngineMaxRpm = packet.EngineMaxRpm();
			data.EngineIdleRpm = packet.EngineIdleRpm();
			data.CurrentEngineRpm = packet.CurrentEngineRpm();
			data.AccelerationX = packet.AccelerationX();
			data.AccelerationY = packet.AccelerationY();
			data.AccelerationZ = packet.AccelerationZ();
			data.VelocityX = packet.VelocityX();
			data.VelocityY = packet.VelocityY();
			data.VelocityZ = packet.VelocityZ();
			data.AngularVelocityX = packet.AngularVelocityX();
			data.AngularVelocityY = packet.AngularVelocityY();
			data.AngularVelocityZ = packet.AngularVelocityZ();
			data.Yaw = packet.Yaw();
			data.Pitch = packet.Pitch();
			data.Roll = packet.Roll();
			data.NormalizedSuspensionTravelFrontLeft = packet.NormSuspensionTravelFl();
			data.NormalizedSuspensionTravelFrontRight = packet.NormSuspensionTravelFr();
			data.NormalizedSuspensionTravelRearLeft = packet.NormSuspensionTravelRl();
			data.NormalizedSuspensionTravelRearRight = packet.NormSuspensionTravelRr();
			data.TireSlipRatioFrontLeft = packet.TireSlipRatioFl();
			data.TireSlipRatioFrontRight = packet.TireSlipRatioFr();
			data.TireSlipRatioRearLeft = packet.TireSlipRatioRl();
			data.TireSlipRatioRearRight = packet.TireSlipRatioRr();
			data.WheelRotationSpeedFrontLeft = packet.WheelRotationSpeedFl();
			data.WheelRotationSpeedFrontRight = packet.WheelRotationSpeedFr();
			data.WheelRotationSpeedRearLeft = packet.WheelRotationSpeedRl();
			data.WheelRotationSpeedRearRight = packet.WheelRotationSpeedRr();
			data.WheelOnRumbleStripFrontLeft = packet.WheelOnRumbleStripFl();
			data.WheelOnRumbleStripFrontRight = packet.WheelOnRumbleStripFr();
			data.WheelOnRumbleStripRearLeft = packet.WheelOnRumbleStripRl();
			data.WheelOnRumbleStripRearRight = packet.WheelOnRumbleStripRr();
			data.WheelInPuddleDepthFrontLeft = packet.WheelInPuddleFl();
			data.WheelInPuddleDepthFrontRight = packet.WheelInPuddleFr();
			data.WheelInPuddleDepthRearLeft = packet.WheelInPuddleRl();
			data.WheelInPuddleDepthRearRight = packet.WheelInPuddleRr();
			data.SurfaceRumbleFrontLeft = packet.SurfaceRumbleFl();
			data.SurfaceRumbleFrontRight = packet.SurfaceRumbleFr();
			data.SurfaceRumbleRearLeft = packet.SurfaceRumbleRl();
			data.SurfaceRumbleRearRight = packet.SurfaceRumbleRr();
			data.TireSlipAngleFrontLeft = packet.TireSlipAngleFl();
			data.TireSlipAngleFrontRight = packet.TireSlipAngleFr();
			data.TireSlipAngleRearLeft = packet.TireSlipAngleRl();
			data.TireSlipAngleRearRight = packet.TireSlipAngleRr();
			data.TireCombinedSlipFrontLeft = packet.TireCombinedSlipFl();
			data.TireCombinedSlipFrontRight = packet.TireCombinedSlipFr();
			data.TireCombinedSlipRearLeft = packet.TireCombinedSlipRl();
			data.TireCombinedSlipRearRight = packet.TireCombinedSlipRr();
			data.SuspensionTravelMetersFrontLeft = packet.SuspensionTravelMetersFl();
			data.SuspensionTravelMetersFrontRight = packet.SuspensionTravelMetersFr();
			data.SuspensionTravelMetersRearLeft = packet.SuspensionTravelMetersRl();
			data.SuspensionTravelMetersRearRight = packet.SuspensionTravelMetersRr();
			data.CarOrdinal = packet.CarOrdinal();
			data.CarClass = packet.CarClass();
			data.CarPerformanceIndex = packet.CarPerformanceIndex();
			data.DrivetrainType = packet.DriveTrain();
			data.NumCylinders = packet.NumCylinders();

			// dash
			data.PositionX = packet.PositionX();
			data.PositionY = packet.PositionY();
			data.PositionZ = packet.PositionZ();
			data.Speed = packet.Speed();
			data.Power = packet.Power();
			data.Torque = packet.Torque();
			data.TireTempFl = packet.TireTempFl();
			data.TireTempFr = packet.TireTempFr();
			data.TireTempRl = packet.TireTempRl();
			data.TireTempRr = packet.TireTempRr();
			data.Boost = packet.Boost();
			data.Fuel = packet.Fuel();
			data.Distance = packet.Distance();
			data.BestLapTime = packet.BestLapTime();
			data.LastLapTime = packet.LastLapTime();
			data.CurrentLapTime = packet.CurrentLapTime();
			data.CurrentRaceTime = packet.CurrentRaceTime();
			data.Lap = packet.Lap();
			data.RacePosition = packet.RacePosition();
			data.Accelerator = packet.Accelerator();
			data.Brake = packet.Brake();
			data.Clutch = packet.Clutch();
			data.Handbrake = packet.Handbrake();
			data.Gear = packet.Gear();
			data.Steer = packet.Steer();
			data.NormalDrivingLine = packet.NormalDrivingLine();
			data.NormalAiBrakeDifference = packet.NormalAiBrakeDifference();

			return data;
		}

		//Support different standards
		static bool AdjustToBufferType(int bufferLength)
		{
			switch (bufferLength)
			{
				case 232: // FM7 sled
					return false;
				case 311: // FM7 dash
					FMData.BufferOffset = 0;
					return true;
				case 324: // FH4
					FMData.BufferOffset = 12;
					return true;
				default:
					return false;
			}
		}
	}
}
