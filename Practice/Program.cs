using System;
using System.Linq;
using System.Numerics;
using Practice.OneOffs;

namespace Practice
{
    static class Program
    {
        static Text text = new Text();

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
            text.TextEd("Choose program: Enter Number", "cyan");


            string[] titles = new string[]
            {
                "Triangle Area",
                "Odd or Even",
                "Stars",
                "Fizzle",
                "Array Test",
                "Months of Year",
                "Reverse Array",
                "Rolling Dice",
                "Ball Pop",
                "To Quit"
            };

            for (int i = 0; i < titles.Length; i++)
            {
                text.TextEd("\n" + (i + 1) + ". " + titles[i], "green");
            }


            var choice = text.AskForInt("Enter Input Here:");


            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Triangle.TriangleArea();
                    break;
                case 2:
                    Console.Clear();
                    OddEven.Check();
                    break;
                case 3:
                    Console.Clear();
                    Stars.Star();
                    break;
                case 4:
                    Console.Clear();
                    Fizzle.Fizz();
                    break;
                case 5:
                    Console.Clear();
                    ArrayTest.ATest();
                    break;
                case 6:
                    Console.Clear();
                    MonthOfYear.NumToMonth();
                    break;
                case 7:
                    Console.Clear();
                    int[] array1 = NumGen.GenerateNumbers();
                    ReverseArray.Reverse(array1);
                    break;
                case 8:
                    Console.Clear();
                    Dice.DiceRoll();
                    break;
                case 9:
                    Console.Clear();
                    PlayBall.RedThrow();
                    break;
                case 10:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    text.TextEd("Please select a choice from the list.", "red");
                    break;
            }

            Console.ReadKey();
        }


        /// <summary>
        ///     returns you to the main menu after completing a task
        /// </summary>
        /// <returns></returns>
        private static bool AskForRetry()
        {
            text.TextEd("Would you like to return to the main menu? (Y/N)");

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
    }
}