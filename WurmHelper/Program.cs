using System;
using System.Windows.Forms;


namespace WurmHelper
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Utilities.InitializeConfigurationDataFile();

			//at the end
			Application.Run(new MainWindow());
		}

		
	}
}
