using System;

namespace Random_Maths_Quiz
{
	class Program
	{
		public static int num1;
		public static int num2;

		public static char repeat;

		public static void Main()
		{

			RandomGeneration();
			Reapeater();

		}
		public static void RandomGeneration()
		{

			Random enga = new Random();

			num1 = enga.Next(0, 100);
			num2 = enga.Next(0, 100);

			Console.WriteLine("What is the sum of " + num1 + " " + num2);
			Console.Write("Enter your Answer: ");
			int answer = Convert.ToInt32(Console.ReadLine());

			int result = num1 + num2;

			if (result == answer)
			{
				Console.WriteLine("It's Correct Answer");
			}
			else
			{
				Console.WriteLine("Sorry It's a Wrong Answer");
			}

			Console.ReadKey();

		}

		public static void Reapeater()
		{
			Console.Write("Do you want to try again y/n: ");
			repeat = Convert.ToChar(Console.ReadLine());

			if (repeat == 'y')
			{
				Main();
			}
			else if (repeat == 'n')
			{
				Console.WriteLine("Okay!");
			}else
			{
				Console.Beep();
				Environment.Exit(0);
				
			}
		}
	}
	}

