using System;

// Namespace
namespace NumberGuesser
{
	// Main Class
	class MainClass
	{
		// Entry point method
		public static void Main(string[] args)
		{
			// Run GetAppInfo function
			GetAppInfo();

			// Get user info
			GreetUser();


			while(true)
			{
				// Init correct number
				// int correctNumber = 7;

				// Instead of using a static number, dynamically generate a random number
				Random random = new Random();

				int correctNumber = random.Next(1, 10);

				// Init guess var
				int guess = 0;

				// Prompt user to guess a number
				Console.WriteLine("Guess a number between 1 and 10");

				// While guess is incorrect
				while (guess != correctNumber)
				{
					// Get user input
					string input = Console.ReadLine();

					// Ensure input is a number
					if (!int.TryParse(input, out guess))
					{

						// Print error message
						PrintColorMessage(ConsoleColor.Red, "Please input a number.");

						// Keep going
						continue;
					}

					// Cast to int and put in guess
					guess = Int32.Parse(input);

					// Match guess to correct number
					if (guess != correctNumber)
					{
						// Print error message
						PrintColorMessage(ConsoleColor.Red, "Wrong number. Try again.");
					}
				}

				// Output success message
				PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

				// Ask to play again
				Console.WriteLine("Play again? [Y or N]");

				// Get answer
				string answer = Console.ReadLine().ToUpper();

				if (answer == "Y")
				{
					continue;
				}
				else if (answer == "N")
				{
					return;
				}
				else
				{
					return;
				}
			}
		}

		// Get and display app info
		static void GetAppInfo()
		{
			// Set app vars
			string appName = "Number Guesser";
			string appVersion = "1.0.0";
			string appAuthor = "Tyler Wells";

			// Change console color
			Console.ForegroundColor = ConsoleColor.Green;

			// Write app info
			Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

			// Reset console color
			Console.ResetColor();
		}

		// Ask user's name and greet user
		static void GreetUser()
		{
			// Ask user's name
			Console.WriteLine("What is your name?");

			// Get user's input
			string inputName = Console.ReadLine();

			// Write a hello message to user
			Console.WriteLine("Hello {0}, let's play a game ... ", inputName);
		}

		// Print color message
		static void PrintColorMessage(ConsoleColor color, string message)
		{
			// Change console color
			Console.ForegroundColor = color;

			// Tell user it's the right number
			Console.WriteLine(message);

			// Reset console color
			Console.ResetColor();
		}
	}
}

