using System;
using System.IO;
using System.Numerics;


namespace WurmHelper
{
	public static class Utilities
	{
		public static int numOfLoops = 10;
		public static int durationOfLoop = 43000;
		public static int extraDurationOfLoop = 2000;

        public static int minClickDelay = 130;
        public static int maxClickDelay = 170;

        public static int numOfClicks = 3;
        
		public static int resolutionX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
		public static int resolutionY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

		public static float scaleMultiplier = 1.0f;

		public static Vector2 prevMousePosition;
		public static Vector2 currentMousePosition;

		public static int buttonPositionX;
		public static int buttonPositionY;

        const string ConfigurationDataFileName = "WurmHelperConfigs.csv";
		static readonly string names = "numOfLoops,durationOfLoop,offsetDurationOfLoop,minClickDelay,maxClickDelay,numOfClicks,resolutionX,resolutionY,scaleMultiplier,buttonPositionX,buttonPositionY";


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

				output.WriteLine($"{numOfLoops},{durationOfLoop},{extraDurationOfLoop},{minClickDelay},{maxClickDelay},{numOfClicks},{resolutionX},{resolutionY},{CommaEliminated(scaleMultiplier)},{buttonPositionX},{buttonPositionY}");
			}
			/*catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}*/
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

				//read in names (not needed) and values
				input.ReadLine();
				string values = input.ReadLine();

				//set configuration data fields
				ParseConfigsFromCSV(values);
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
			extraDurationOfLoop = int.Parse(values[2]);

            minClickDelay = int.Parse(values[3]);
            maxClickDelay = int.Parse(values[4]);

            numOfClicks = int.Parse(values[5]);

			resolutionX = int.Parse(values[6]);
			resolutionY = int.Parse(values[7]);
			scaleMultiplier = float.Parse(EliminateComma(values[8]));

			buttonPositionX = int.Parse(values[9]);
			buttonPositionY = int.Parse(values[10]);
		}

        public static string EliminateComma(string input)
        {
            string output = input.Replace(',', '.');
            return output;
        }
        
        static string CommaEliminated(float input)
        {
            string output = input.ToString(System.Globalization.CultureInfo.InvariantCulture);
            output = output.Replace(',', '.');
            return output;
        }
        
    }
}
