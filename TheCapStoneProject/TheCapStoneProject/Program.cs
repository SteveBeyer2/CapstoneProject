using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCapStoneProject
{
	class Program
	{
		static void Main(string[] args)
		{
			//	**********************************************
			//	Title:			Pacing Calculator
			//	Application:	Console TheCapStoneProject
			//	Description:	A console utility in C# to calculate pace per mile based on user input of time and distance
			//	Inspiration:	www.coolrunning.com/engine/4/4_1/96.shtml
			//	Author:			Steve Beyer
			//	Date Created:	11-27-2017
			//	Last Modified:	12-8-2017
			//	**********************************************


			//	Initial Greetings

			Console.WriteLine("Welcome to the Pacing Calculator Application!");
			Console.WriteLine("Did you ever wonder your pace per mile from a run or walk?");
			Console.WriteLine("Please enter the Hours, Minutes, Seconds, and Distance in each field.");
			Console.WriteLine("Your pace per mile will appear.");
			Console.WriteLine();

			//	Int level

			int hours;
			int minutes;
			int seconds;
			double miles;
			double paceInSeconds;
			int totalTimeSec;
			bool running = true;

			//	While Loop

			while (running)
			{
				//	Hours prompt

				Console.WriteLine("Please enter the time in Hours:");
				string textHours = Console.ReadLine();
				hours = Convert.ToInt32(textHours);

				//	Minutes prompt

				Console.WriteLine("Please enter the time in Minutes:");
				string textMinutes = Console.ReadLine();
				minutes = Convert.ToInt32(textMinutes);

				//	Seconds prompt

				Console.WriteLine("Please enter the time in Seconds:");
				string textSeconds = Console.ReadLine();
				seconds = Convert.ToInt32(textSeconds);

				//	Miles prompt

				Console.WriteLine("Please enter the distance in Miles:");
				string textMiles = Console.ReadLine();
				miles = Convert.ToDouble(textMiles);

				//	Pace math calculations credit from website:
				//	forums.codeguru.com/showthread.php?415877-Calculating-Running-Pace

				totalTimeSec = (hours * 3600) + (minutes * 60) + (seconds);
				paceInSeconds = (totalTimeSec / miles);

				TimeSpan paceTime = TimeSpan.FromSeconds(paceInSeconds);

				//	Console output credit from website:
				//	stackoverflow.com/questions/463642/what-is-the-best-way-to-convert-seconds-into-hourminutessecondsmilliseconds

				Console.WriteLine();

				Console.WriteLine($"Your pace: {paceTime.ToString(@"hh\:mm\:ss")} Per Mile");

				//	If statement enter another pace Frank from class helped out on this code

				Console.WriteLine();
				Console.WriteLine("Would you like to enter another pace? yes or no");

				string userInput = Console.ReadLine().ToLower();

				if (userInput == "yes")
				{
					running = true;
				}
				else if (userInput == "no")
				{
					running = false;
				}

			}

				//	Ending

				Console.WriteLine();

				Console.WriteLine("Thank you for using my program!");

				Console.ReadKey();


		}
	}
}
