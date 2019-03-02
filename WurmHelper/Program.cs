using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            //
            //Change back to Windows Application in Project->Properties
            //
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Utilities.InitializeConfigurationDataFile();

			//at the end
			Application.Run(new MainWindow());
		}

		
	}
}
