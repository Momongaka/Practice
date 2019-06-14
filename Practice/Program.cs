using System;
using System.Linq;

namespace Practice
{
    static class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Menu();
                if (AskForRetry()) Menu();
                else break;
            } while (true);
        }

        private static void Menu()
        {
            TextEd("Choose program: Enter Number", "cyan");

            string[] titles = new string[]
            {
                "Triangle Area",
                "Odd or Even",
                "Stars",
                "Fizzle",
                "Array Test",
                "To Quit"
            };

            for (int i = 0; i < titles.Length; i++)
            {
                TextEd("\n" + (i + 1) + ". " + titles[i], "green");
            }


            var choice = AskForInt("Enter Input Here:");

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    TriangleArea();
                    break;
                case 2:
                    Console.Clear();
                    OddEven();
                    break;
                case 3:
                    Console.Clear();
                    Stars();
                    break;
                case 4:
                    Console.Clear();
                    Fizzle();
                    break;
                case 5:
                    Console.Clear();
                    ArrayTest();
                    break;
                case 6:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    TextEd("Please select a choice from the list.", "red");
                    break;
            }

            Console.ReadKey();
        }

        public static void TextEd(string message, string color = "", string align = "")
        {
            if (color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == "cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (align == "center")
            {
                int screenWidth = Console.WindowWidth;
                int stringWidth = message.Length;
                int spaces = (screenWidth / 2) + (stringWidth / 2);
                Console.WriteLine(message.PadLeft(spaces));
            }
            else
            {
                Console.WriteLine(message);
            }

            Console.ResetColor();
        }

        private static bool AskForRetry()
        {
            TextEd("Would you like to return to the main menu? (Y/N)");

            var inputString = Console.ReadLine();
            char i = inputString?.FirstOrDefault() ?? ' ';
            bool success;
            switch (i)
            {
                case 'Y':
                case 'y':
                    success = true;
                    break;
                default:
                    success = false;
                    break;
            }

            return success;
        }

        private static void TriangleArea()
        {
            TextEd("\nFind the Area of a Triangle", "red", "center");

            long triBase = AskForInt("What is the base of the triangle?");
            var triHeight = AskForInt("What is the height of the triangle?");

            var triArea = GetArea(triBase, triHeight);
            TextEd("The area is " + triArea, "green");
        }

        private static double GetArea(long triBase, long triHeight)
        {
            return triBase * triHeight / 2.0;
        }

        private static void OddEven()
        {
            TextEd("\nWelcome to Odd or Even\n");
            var numChoice = AskForInt("Enter a number");

            string state = IsEven(numChoice) ? "even" : "odd";
            TextEd($"The number {numChoice} is {state}.", "green");
        }

        private static bool IsEven(long numCheck) => (numCheck % 2) == 0;

        private static long AskForInt(string query)
        {
            TextEd(query, "cyan");
            var inputString = Console.ReadLine();
            long output;
            while (!long.TryParse(inputString, out output))
            {
                TextEd("Please enter an integer.", "cyan");
                inputString = Console.ReadLine();
            }

            return output;
        }

        private static void Stars()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = 4; column > row; column--)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < 2*row + 1; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private static void Fizzle()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                 Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);  
                }
            }
        }

        private static void ArrayTest()
        {
            int[] numbers = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};
            int[] copyTo = new int [numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {

                copyTo[i] = numbers[i];
            }
            Console.WriteLine(string.Join(",",numbers));
            Console.WriteLine();
            Console.WriteLine(string.Join(",",copyTo));
        }
    }
}