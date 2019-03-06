using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WurmHelper
{
	public partial class MainWindow : Form
	{
		//
		//		System.Windows.Forms	-	20ms inaccuracy		8ms min step 
		//		System.Timers.Timer		-	--ms inaccuracy		16ms min step
		//		AccurateTimer			-						3ms min step	-	ASYNC !@#$%
		//

		int delayTime;
		const int inaccuracyIncrement = 16;
		const int inaccuracyTick = 1;
		
		public MainWindow()
		{
            InitializeComponent();
            LoadInputValuesFromUtils();

            mousePosRefreshTimer.Interval = 100;
			mousePosRefreshTimer.Start();
			mousePosRefreshTimer.Tick += MousePosRefreshTimer_Tick;
			
			currentProgressBarTimer.Interval = inaccuracyTick;
			currentProgressBarTimer.Tick += CurrentProgressBarTimer_Tick;
			
			totalProgressBarTimer.Interval = inaccuracyTick;
			totalProgressBarTimer.Tick += TotalProgressBarTimer_Tick;
        }


		private async void Craft()
		{
			#region Fields
			Random rng;

			totalProgressBar.Value = 0;
			totalProgressBar.Maximum = Utilities.numOfLoops * (Utilities.durationOfLoop + Utilities.numOfClicks * (Utilities.minClickDelay + Utilities.maxClickDelay)/2);
			totalProgressBar.Step = inaccuracyIncrement;
			totalProgressBarTimer.Start();

			int hours = totalProgressBar.Maximum / 3600000;
			int minutes = (totalProgressBar.Maximum - 3600000 * hours) / 60000;
			int seconds = (totalProgressBar.Maximum - 3600000 * hours - 60000 * minutes) / 1000;

			estimatedTotalLabel.Text = ("Estimated Total Time:\n" + $"{hours} h, {minutes} min, {seconds} sec.");
			#endregion

			for (int t = 0; t < Utilities.numOfLoops; t++)
			{
				rng = new Random();

				VirtualMouse.LeftUp();
				Utilities.prevMousePosition = VirtualMouse.GetPosition() * Utilities.scaleMultiplier;
                //UpdateEventLog("Prev. mouse position: " + Utilities.prevMousePosition.ToString());

				for (int l = 0; l < Utilities.numOfClicks; l++)
				{
					delayTime = rng.Next(Utilities.minClickDelay, Utilities.maxClickDelay + 1);
                    //UpdateEventLog("Move to: " + Utilities.buttonPositionX.ToString() + " " + Utilities.buttonPositionY.ToString());
                    //UpdateEventLog("Moving to: " + (Utilities.buttonPositionX * Utilities.scaleMultiplier).ToString() + " " + (Utilities.buttonPositionY * Utilities.scaleMultiplier).ToString());
                    VirtualMouse.MoveTo(Utilities.buttonPositionX * Utilities.scaleMultiplier, Utilities.buttonPositionY * Utilities.scaleMultiplier);
                    //UpdateEventLog("Moved to: " + VirtualMouse.GetPosition().ToString());
                    VirtualMouse.LeftDown();
					VirtualMouse.LeftUp();

					currentProgressBar.Value = 0;
					currentProgressBar.Maximum = delayTime;
					currentProgressBar.Step = inaccuracyIncrement;


					currentProgressBarTimer.Start();
                    await Delayer(delayTime);

					currentProgressBarTimer.Stop();

					UpdateEventLog("Clicked with delay of " + delayTime + " ms");
				}

				delayTime = rng.Next(Utilities.durationOfLoop, Utilities.durationOfLoop + Utilities.extraDurationOfLoop + 1);

                //UpdateEventLog("Returning to: " + Utilities.prevMousePosition.X.ToString() + " " + Utilities.prevMousePosition.Y.ToString());
                VirtualMouse.MoveTo(Utilities.prevMousePosition.X, Utilities.prevMousePosition.Y);
                //UpdateEventLog("Returned to: " + VirtualMouse.GetPosition().ToString());


                currentProgressBar.Value = 0;
				currentProgressBar.Maximum = delayTime;
				currentProgressBar.Step = inaccuracyIncrement;

				currentProgressBarTimer.Start();
				UpdateEventLog("Job will perform for " + delayTime + " more ms");

				await Delayer(delayTime);

				currentProgressBarTimer.Stop();
			}

			UpdateEventLog("Task completed");
			totalProgressBarTimer.Stop();
			totalProgressBar.Value = totalProgressBar.Maximum;

			return;
		}

		async Task Delayer(int delay)
		{
			await Task.Run(async () =>  { await Task.Delay(delay); } );
		}

		private void MousePosRefreshTimer_Tick(object sender, EventArgs e)
		{
			CurrentMousePositionLabel2.Text = VirtualMouse.GetPosition().ToString();
		}

		private void CurrentProgressBarTimer_Tick(object sender, EventArgs e)
		{
			//UpdateEventLog($"max value: {currentProgressBar.Maximum}, progress value: {currentProgressBar.Value}, {DateTime.Now.Millisecond}");
			currentProgressBar.PerformStep();
			currentProgressBar.Refresh();
		}
		private void TotalProgressBarTimer_Tick(object sender, EventArgs e)
		{
			totalProgressBar.PerformStep();
			totalProgressBar.Refresh();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			LoadInputValuesFromUtils();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			if (SaveInputValuesToUtils())
            {
                Utilities.WriteConfigsToFile();

                mousePosRefreshTimer.Stop();

                Craft();
            }
		}
		private void StopButton_Click(object sender, EventArgs e)
		{
			UpdateEventLog("Task aborted");
			Application.Restart();
		}

		void UpdateEventLog(string input)
		{
			EventLog.Text = EventLog.Text.Insert(0, input + "\n");
		}

		private bool SaveInputValuesToUtils()
		{
            if (CheckForValidInput(numOfLoopsData.Text) &&
                CheckForValidInput(durationOfLoopData.Text) &&
                CheckForValidInput(offsetDurationOfLoopData.Text) &&

                CheckForValidInput(minClickDelayData.Text) &&
                CheckForValidInput(maxClickDelayData.Text) &&

                CheckForValidInput(numOfClicksData.Text) &&

                CheckForValidInput(buttonPositionXData.Text) &&
                CheckForValidInput(buttonPositionYData.Text)
                )
            {
                Utilities.numOfLoops = int.Parse(numOfLoopsData.Text);
                Utilities.durationOfLoop = int.Parse(durationOfLoopData.Text);
                Utilities.extraDurationOfLoop = int.Parse(offsetDurationOfLoopData.Text);

                Utilities.minClickDelay = int.Parse(minClickDelayData.Text);
                Utilities.maxClickDelay = int.Parse(maxClickDelayData.Text);

                Utilities.numOfClicks = int.Parse(numOfClicksData.Text);
                /*
                Utilities.resolutionX = CheckForIntAndParse(resolutionXData.Text);
                Utilities.resolutionY = CheckForIntAndParse(resolutionYData.Text);
                Utilities.scaleMultiplier = float.Parse(Utilities.CommaEliminated(scaleMultiplierData.Text));
                */
                Utilities.buttonPositionX = int.Parse(buttonPositionXData.Text);
                Utilities.buttonPositionY = int.Parse(buttonPositionYData.Text);

                if (Utilities.maxClickDelay < Utilities.minClickDelay)
                {
                    string message = "Max click delay value is less than min click delay value.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttonOK = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttonOK);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

		private void LoadInputValuesFromUtils()
		{
            numOfLoopsData.Text = Utilities.numOfLoops.ToString();
			durationOfLoopData.Text = Utilities.durationOfLoop.ToString();
			offsetDurationOfLoopData.Text = Utilities.extraDurationOfLoop.ToString();

            minClickDelayData.Text = Utilities.minClickDelay.ToString();
            maxClickDelayData.Text = Utilities.maxClickDelay.ToString();

            numOfClicksData.Text = Utilities.numOfClicks.ToString();

			resolutionXData.Text = Utilities.resolutionX.ToString();
			resolutionYData.Text = Utilities.resolutionY.ToString();
			scaleMultiplierData.Text = Utilities.scaleMultiplier.ToString();

			buttonPositionXData.Text = Utilities.buttonPositionX.ToString();
			buttonPositionYData.Text = Utilities.buttonPositionY.ToString();
		}

        static bool CheckForValidInput (string inputTextBox)
        {
            if(inputTextBox.Length == 0)
            {
                string message = "You did not enter a value.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttonOK = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttonOK);
                return false;
            }

            if (!int.TryParse(inputTextBox, out int output))
            {
                string message = "Entered value is not a number.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttonOK = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttonOK);
                return false;
            }
            else
            {
                if (output <= 0)
                {
                    string message = "Entered value is less or equal to zero. You probably don't want that.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttonOK = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttonOK);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
