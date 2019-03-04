using System;
using System.Collections.Concurrent;
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
	public static class Utilities
	{
		public static int numOfLoops = 50;
		public static int durationOfLoop = 43000;
		public static int offsetDurationOfLoop = 2000;

		public static int numOfClicks = 3;
        
		public static int resolutionX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
		public static int resolutionY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

		public static float scaleMultiplier = 1.0f;

		public static Vector2 prevMousePosition;
		public static Vector2 currentMousePosition;

		public static int buttonPositionX = 0;
		public static int buttonPositionY = 0;

		const string ConfigurationDataFileName = "WurmHelperConfigs.csv";
		static readonly string names = "numOfLoops,durationOfLoop,offsetDurationOfLoop,numOfClicks,resolutionX,resolutionY,scaleMultiplier,buttonPositionX,buttonPositionY";


		public static void InitializeConfigurationDataFile()
		{
			if (File.Exists(ConfigurationDataFileName))
			{
				ReadConfigsFromFile(); 
			}
			else
			{
				WriteConfigsToFile();
			}
		}

		public static void WriteConfigsToFile()
		{
			StreamWriter output = null;
			try
			{
				output = File.CreateText(ConfigurationDataFileName);
				output.WriteLine(names);

				output.WriteLine($"{numOfLoops},{durationOfLoop},{offsetDurationOfLoop},{numOfClicks},{resolutionX},{resolutionY},{CommaEliminated(scaleMultiplier)},{buttonPositionX},{buttonPositionY}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (output != null)
				{
					output.Close();
				}
			}
		}

		static void ReadConfigsFromFile()
		{
			StreamReader input = null;
			try
			{
				//create stream reader object
				input = File.OpenText(ConfigurationDataFileName);

				//read in names and values
				string names = input.ReadLine();
				string values = input.ReadLine();

				//set configuration data fields
				ParseConfigsFromCSV(values);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (input != null)
				{
					input.Close();
				}
			}
		}

		static void ParseConfigsFromCSV(string csvValues)
		{
			string[] values = csvValues.Split(',');

			numOfLoops = int.Parse(values[0]);
			durationOfLoop = int.Parse(values[1]);
			offsetDurationOfLoop = int.Parse(values[2]);

			numOfClicks = int.Parse(values[3]);

			resolutionX = int.Parse(values[4]);
			resolutionY = int.Parse(values[5]);
			scaleMultiplier = float.Parse(CommaEliminated(values[6]));

			buttonPositionX = int.Parse(values[7]);
			buttonPositionY = int.Parse(values[8]);
		}

        //is also used in MainWindow
        public static string CommaEliminated (string input)
        {
            input = input.Replace(',', '.');
            return input;
        }

        //is only used here
        static string CommaEliminated(float input)
        {
            string convertedInput = input.ToString();
            convertedInput = convertedInput.Replace(',', '.');
            return convertedInput;
        }
    }
}
