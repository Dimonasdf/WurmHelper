namespace WurmHelper
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.StartButton = new System.Windows.Forms.Button();
			this.CurrentMousePositionLabel1 = new System.Windows.Forms.Label();
			this.CurrentMousePositionLabel2 = new System.Windows.Forms.Label();
			this.totalProgressBar = new System.Windows.Forms.ProgressBar();
			this.durationOfLoopData = new System.Windows.Forms.TextBox();
			this.offsetDurationOfLoopLabel1 = new System.Windows.Forms.Label();
			this.offsetDurationOfLoopData = new System.Windows.Forms.TextBox();
			this.currentProgressBar = new System.Windows.Forms.ProgressBar();
			this.totalProgressLabel = new System.Windows.Forms.Label();
			this.currentProgressLabel = new System.Windows.Forms.Label();
			this.durationOfLoopLabel = new System.Windows.Forms.Label();
			this.offsetDurationOfLoop2 = new System.Windows.Forms.Label();
			this.numOfLoopsLabel = new System.Windows.Forms.Label();
			this.numOfLoopsData = new System.Windows.Forms.TextBox();
			this.numOfClicksLabel = new System.Windows.Forms.Label();
			this.numOfClicksData = new System.Windows.Forms.TextBox();
			this.resolutionLabel = new System.Windows.Forms.Label();
			this.resolutionXLabel = new System.Windows.Forms.Label();
			this.resolutionXData = new System.Windows.Forms.TextBox();
			this.resolutionYLabel = new System.Windows.Forms.Label();
			this.resolutionYData = new System.Windows.Forms.TextBox();
			this.scaleMultiplierLabel = new System.Windows.Forms.Label();
			this.scaleMultiplierData = new System.Windows.Forms.TextBox();
			this.EventLog = new System.Windows.Forms.RichTextBox();
			this.buttonPositionLabel = new System.Windows.Forms.Label();
			this.buttonPositionXData = new System.Windows.Forms.TextBox();
			this.buttonPositionYData = new System.Windows.Forms.TextBox();
			this.mousePosRefreshTimer = new System.Windows.Forms.Timer(this.components);
			this.StopButton = new System.Windows.Forms.Button();
			this.currentProgressBarTimer = new System.Windows.Forms.Timer(this.components);
			this.theTimer = new System.Windows.Forms.Timer(this.components);
			this.totalProgressBarTimer = new System.Windows.Forms.Timer(this.components);
			this.estimatedTotalLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(706, 14);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(150, 50);
			this.StartButton.TabIndex = 15;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// CurrentMousePositionLabel1
			// 
			this.CurrentMousePositionLabel1.AutoSize = true;
			this.CurrentMousePositionLabel1.Location = new System.Drawing.Point(23, 123);
			this.CurrentMousePositionLabel1.Name = "CurrentMousePositionLabel1";
			this.CurrentMousePositionLabel1.Size = new System.Drawing.Size(174, 20);
			this.CurrentMousePositionLabel1.TabIndex = 5;
			this.CurrentMousePositionLabel1.Text = "Current Mouse Position";
			// 
			// CurrentMousePositionLabel2
			// 
			this.CurrentMousePositionLabel2.AutoSize = true;
			this.CurrentMousePositionLabel2.Location = new System.Drawing.Point(203, 123);
			this.CurrentMousePositionLabel2.Name = "CurrentMousePositionLabel2";
			this.CurrentMousePositionLabel2.Size = new System.Drawing.Size(45, 20);
			this.CurrentMousePositionLabel2.TabIndex = 5;
			this.CurrentMousePositionLabel2.Text = "2747";
			// 
			// totalProgressBar
			// 
			this.totalProgressBar.Location = new System.Drawing.Point(225, 236);
			this.totalProgressBar.Name = "totalProgressBar";
			this.totalProgressBar.Size = new System.Drawing.Size(631, 20);
			this.totalProgressBar.TabIndex = 13;
			// 
			// durationOfLoopData
			// 
			this.durationOfLoopData.Location = new System.Drawing.Point(236, 77);
			this.durationOfLoopData.Name = "durationOfLoopData";
			this.durationOfLoopData.Size = new System.Drawing.Size(204, 26);
			this.durationOfLoopData.TabIndex = 3;
			// 
			// offsetDurationOfLoopLabel1
			// 
			this.offsetDurationOfLoopLabel1.AutoSize = true;
			this.offsetDurationOfLoopLabel1.Location = new System.Drawing.Point(446, 77);
			this.offsetDurationOfLoopLabel1.Name = "offsetDurationOfLoopLabel1";
			this.offsetDurationOfLoopLabel1.Size = new System.Drawing.Size(23, 20);
			this.offsetDurationOfLoopLabel1.TabIndex = 4;
			this.offsetDurationOfLoopLabel1.Text = "+-";
			// 
			// offsetDurationOfLoopData
			// 
			this.offsetDurationOfLoopData.Location = new System.Drawing.Point(475, 74);
			this.offsetDurationOfLoopData.Name = "offsetDurationOfLoopData";
			this.offsetDurationOfLoopData.Size = new System.Drawing.Size(100, 26);
			this.offsetDurationOfLoopData.TabIndex = 4;
			// 
			// currentProgressBar
			// 
			this.currentProgressBar.Location = new System.Drawing.Point(225, 210);
			this.currentProgressBar.Name = "currentProgressBar";
			this.currentProgressBar.Size = new System.Drawing.Size(631, 20);
			this.currentProgressBar.TabIndex = 12;
			// 
			// totalProgressLabel
			// 
			this.totalProgressLabel.AutoSize = true;
			this.totalProgressLabel.Location = new System.Drawing.Point(23, 236);
			this.totalProgressLabel.Name = "totalProgressLabel";
			this.totalProgressLabel.Size = new System.Drawing.Size(201, 20);
			this.totalProgressLabel.TabIndex = 13;
			this.totalProgressLabel.Text = "Estimated(!) Total Progress";
			// 
			// currentProgressLabel
			// 
			this.currentProgressLabel.AutoSize = true;
			this.currentProgressLabel.Location = new System.Drawing.Point(23, 210);
			this.currentProgressLabel.Name = "currentProgressLabel";
			this.currentProgressLabel.Size = new System.Drawing.Size(129, 20);
			this.currentProgressLabel.TabIndex = 12;
			this.currentProgressLabel.Text = "Current Progress";
			// 
			// durationOfLoopLabel
			// 
			this.durationOfLoopLabel.AutoSize = true;
			this.durationOfLoopLabel.Location = new System.Drawing.Point(23, 77);
			this.durationOfLoopLabel.Name = "durationOfLoopLabel";
			this.durationOfLoopLabel.Size = new System.Drawing.Size(207, 20);
			this.durationOfLoopLabel.TabIndex = 3;
			this.durationOfLoopLabel.Text = "Total Loop Msec (sec*1000)";
			// 
			// offsetDurationOfLoop2
			// 
			this.offsetDurationOfLoop2.AutoSize = true;
			this.offsetDurationOfLoop2.Location = new System.Drawing.Point(581, 77);
			this.offsetDurationOfLoop2.Name = "offsetDurationOfLoop2";
			this.offsetDurationOfLoop2.Size = new System.Drawing.Size(47, 20);
			this.offsetDurationOfLoop2.TabIndex = 4;
			this.offsetDurationOfLoop2.Text = "Msec";
			// 
			// numOfLoopsLabel
			// 
			this.numOfLoopsLabel.AutoSize = true;
			this.numOfLoopsLabel.Location = new System.Drawing.Point(23, 29);
			this.numOfLoopsLabel.Name = "numOfLoopsLabel";
			this.numOfLoopsLabel.Size = new System.Drawing.Size(112, 20);
			this.numOfLoopsLabel.TabIndex = 1;
			this.numOfLoopsLabel.Text = "Num. of Loops";
			// 
			// numOfLoopsData
			// 
			this.numOfLoopsData.Location = new System.Drawing.Point(141, 26);
			this.numOfLoopsData.Name = "numOfLoopsData";
			this.numOfLoopsData.Size = new System.Drawing.Size(100, 26);
			this.numOfLoopsData.TabIndex = 1;
			// 
			// numOfClicksLabel
			// 
			this.numOfClicksLabel.AutoSize = true;
			this.numOfClicksLabel.Location = new System.Drawing.Point(247, 29);
			this.numOfClicksLabel.Name = "numOfClicksLabel";
			this.numOfClicksLabel.Size = new System.Drawing.Size(109, 20);
			this.numOfClicksLabel.TabIndex = 2;
			this.numOfClicksLabel.Text = "Num. of Clicks";
			// 
			// numOfClicksData
			// 
			this.numOfClicksData.Location = new System.Drawing.Point(362, 26);
			this.numOfClicksData.Name = "numOfClicksData";
			this.numOfClicksData.Size = new System.Drawing.Size(100, 26);
			this.numOfClicksData.TabIndex = 2;
			// 
			// resolutionLabel
			// 
			this.resolutionLabel.AutoSize = true;
			this.resolutionLabel.Location = new System.Drawing.Point(23, 169);
			this.resolutionLabel.Name = "resolutionLabel";
			this.resolutionLabel.Size = new System.Drawing.Size(140, 20);
			this.resolutionLabel.TabIndex = 8;
			this.resolutionLabel.Text = "Screen Resolution";
			// 
			// resolutionXLabel
			// 
			this.resolutionXLabel.AutoSize = true;
			this.resolutionXLabel.Location = new System.Drawing.Point(169, 169);
			this.resolutionXLabel.Name = "resolutionXLabel";
			this.resolutionXLabel.Size = new System.Drawing.Size(50, 20);
			this.resolutionXLabel.TabIndex = 9;
			this.resolutionXLabel.Text = "Width";
			// 
			// resolutionXData
			// 
			this.resolutionXData.Location = new System.Drawing.Point(225, 166);
			this.resolutionXData.Name = "resolutionXData";
			this.resolutionXData.Size = new System.Drawing.Size(100, 26);
			this.resolutionXData.TabIndex = 9;
			// 
			// resolutionYLabel
			// 
			this.resolutionYLabel.AutoSize = true;
			this.resolutionYLabel.Location = new System.Drawing.Point(331, 169);
			this.resolutionYLabel.Name = "resolutionYLabel";
			this.resolutionYLabel.Size = new System.Drawing.Size(56, 20);
			this.resolutionYLabel.TabIndex = 10;
			this.resolutionYLabel.Text = "Height";
			// 
			// resolutionYData
			// 
			this.resolutionYData.Location = new System.Drawing.Point(393, 166);
			this.resolutionYData.Name = "resolutionYData";
			this.resolutionYData.Size = new System.Drawing.Size(100, 26);
			this.resolutionYData.TabIndex = 10;
			// 
			// scaleMultiplierLabel
			// 
			this.scaleMultiplierLabel.AutoSize = true;
			this.scaleMultiplierLabel.Location = new System.Drawing.Point(499, 169);
			this.scaleMultiplierLabel.Name = "scaleMultiplierLabel";
			this.scaleMultiplierLabel.Size = new System.Drawing.Size(141, 20);
			this.scaleMultiplierLabel.TabIndex = 11;
			this.scaleMultiplierLabel.Text = "Resolution Scaling";
			// 
			// scaleMultiplierData
			// 
			this.scaleMultiplierData.Location = new System.Drawing.Point(646, 166);
			this.scaleMultiplierData.Name = "scaleMultiplierData";
			this.scaleMultiplierData.Size = new System.Drawing.Size(100, 26);
			this.scaleMultiplierData.TabIndex = 11;
			// 
			// EventLog
			// 
			this.EventLog.AccessibleName = "EventLog";
			this.EventLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.EventLog.Location = new System.Drawing.Point(12, 275);
			this.EventLog.Name = "EventLog";
			this.EventLog.ReadOnly = true;
			this.EventLog.Size = new System.Drawing.Size(854, 157);
			this.EventLog.TabIndex = 14;
			this.EventLog.Text = "Event Log";
			// 
			// buttonPositionLabel
			// 
			this.buttonPositionLabel.AutoSize = true;
			this.buttonPositionLabel.Location = new System.Drawing.Point(309, 123);
			this.buttonPositionLabel.Name = "buttonPositionLabel";
			this.buttonPositionLabel.Size = new System.Drawing.Size(117, 20);
			this.buttonPositionLabel.TabIndex = 6;
			this.buttonPositionLabel.Text = "Button Position";
			// 
			// buttonPositionXData
			// 
			this.buttonPositionXData.Location = new System.Drawing.Point(432, 120);
			this.buttonPositionXData.Name = "buttonPositionXData";
			this.buttonPositionXData.Size = new System.Drawing.Size(100, 26);
			this.buttonPositionXData.TabIndex = 6;
			// 
			// buttonPositionYData
			// 
			this.buttonPositionYData.Location = new System.Drawing.Point(538, 120);
			this.buttonPositionYData.Name = "buttonPositionYData";
			this.buttonPositionYData.Size = new System.Drawing.Size(100, 26);
			this.buttonPositionYData.TabIndex = 7;
			// 
			// StopButton
			// 
			this.StopButton.Location = new System.Drawing.Point(706, 77);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(150, 50);
			this.StopButton.TabIndex = 16;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// theTimer
			// 
			this.theTimer.Interval = 1;
			// 
			// estimatedTotalLabel
			// 
			this.estimatedTotalLabel.AutoSize = true;
			this.estimatedTotalLabel.Location = new System.Drawing.Point(499, 14);
			this.estimatedTotalLabel.Name = "estimatedTotalLabel";
			this.estimatedTotalLabel.Size = new System.Drawing.Size(162, 20);
			this.estimatedTotalLabel.TabIndex = 17;
			this.estimatedTotalLabel.Text = "Estimated Total Time:";
			this.estimatedTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 444);
			this.Controls.Add(this.estimatedTotalLabel);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.buttonPositionYData);
			this.Controls.Add(this.buttonPositionXData);
			this.Controls.Add(this.buttonPositionLabel);
			this.Controls.Add(this.EventLog);
			this.Controls.Add(this.scaleMultiplierData);
			this.Controls.Add(this.scaleMultiplierLabel);
			this.Controls.Add(this.resolutionYData);
			this.Controls.Add(this.resolutionYLabel);
			this.Controls.Add(this.resolutionXData);
			this.Controls.Add(this.resolutionXLabel);
			this.Controls.Add(this.resolutionLabel);
			this.Controls.Add(this.numOfClicksData);
			this.Controls.Add(this.numOfClicksLabel);
			this.Controls.Add(this.numOfLoopsData);
			this.Controls.Add(this.numOfLoopsLabel);
			this.Controls.Add(this.offsetDurationOfLoop2);
			this.Controls.Add(this.durationOfLoopLabel);
			this.Controls.Add(this.currentProgressLabel);
			this.Controls.Add(this.totalProgressLabel);
			this.Controls.Add(this.currentProgressBar);
			this.Controls.Add(this.offsetDurationOfLoopData);
			this.Controls.Add(this.offsetDurationOfLoopLabel1);
			this.Controls.Add(this.durationOfLoopData);
			this.Controls.Add(this.totalProgressBar);
			this.Controls.Add(this.CurrentMousePositionLabel2);
			this.Controls.Add(this.CurrentMousePositionLabel1);
			this.Controls.Add(this.StartButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.Text = "Wurm Helper";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Label CurrentMousePositionLabel1;
		private System.Windows.Forms.Label CurrentMousePositionLabel2;
		private System.Windows.Forms.ProgressBar totalProgressBar;
		private System.Windows.Forms.TextBox durationOfLoopData;
		private System.Windows.Forms.Label offsetDurationOfLoopLabel1;
		private System.Windows.Forms.TextBox offsetDurationOfLoopData;
		private System.Windows.Forms.ProgressBar currentProgressBar;
		private System.Windows.Forms.Label totalProgressLabel;
		private System.Windows.Forms.Label currentProgressLabel;
		private System.Windows.Forms.Label durationOfLoopLabel;
		private System.Windows.Forms.Label offsetDurationOfLoop2;
		private System.Windows.Forms.Label numOfLoopsLabel;
		private System.Windows.Forms.TextBox numOfLoopsData;
		private System.Windows.Forms.Label numOfClicksLabel;
		private System.Windows.Forms.TextBox numOfClicksData;
		private System.Windows.Forms.Label resolutionLabel;
		private System.Windows.Forms.Label resolutionXLabel;
		private System.Windows.Forms.TextBox resolutionXData;
		private System.Windows.Forms.Label resolutionYLabel;
		private System.Windows.Forms.TextBox resolutionYData;
		private System.Windows.Forms.Label scaleMultiplierLabel;
		private System.Windows.Forms.TextBox scaleMultiplierData;
		public System.Windows.Forms.RichTextBox EventLog;
		private System.Windows.Forms.Label buttonPositionLabel;
		private System.Windows.Forms.TextBox buttonPositionXData;
		private System.Windows.Forms.TextBox buttonPositionYData;
		private System.Windows.Forms.Timer mousePosRefreshTimer;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Timer currentProgressBarTimer;
		private System.Windows.Forms.Timer theTimer;
		private System.Windows.Forms.Timer totalProgressBarTimer;
		private System.Windows.Forms.Label estimatedTotalLabel;
	}
}

