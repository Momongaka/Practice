using System;
using System.Linq;

namespace Practice
{
    static class Program
    {
        static ChatOp chat = new ChatOp();

        static void Main(string[] args)
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
            chat.TextEd("Choose program: Enter Number", "cyan");
            chat.TextEd("\n1. Triangle Area", "green");
            chat.TextEd("\n2. Odd or Even\n", "green");
            chat.TextEd("\nHit Escape to Quit\n", "red");
            var choice = AskForInt("Enter Input Here:");

            switch (choice)
            {
                case 1:
                    GetTriangleDimensionsFromUser();
                    break;
                case 2:
                    OddEven();
                    break;
                default:
                    chat.TextEd("Please select a choice from the list.", "red");
                    break;
            }
        }

        private static bool AskForRetry()
        {
            chat.TextEd("Would you like to return to the main menu? (Y/N)");
            
            var inputString = Console.ReadLine();
            char i = inputString?.FirstOrDefault() ?? ' ';
            bool success;
            switch (i)
            {
                case 'Y':
                case 'y':
                    success = true; break;
                default:
                    success = false; break;
            }

            return success;
        }

        private static void GetTriangleDimensionsFromUser()
        {
            chat.TextEd("\nFind the Area of a Triangle", "red", "center");

            long triBase = AskForInt("What is the base of the triangle?");
            var triHeight = AskForInt("What is the height of the triangle?");

            var triArea = GetArea(triBase, triHeight);
            chat.TextEd("The area is " + triArea, "green");
        }

        private static double GetArea(long triBase, long triHeight)
        {
            return triBase * triHeight / 2.0;
        }

        private static void OddEven()
        {
            chat.TextEd("\nWelcome to Odd or Even\n");
            var numCheck = AskForInt("Please enter a number");
            var answer = IsOddEven(numCheck);

            if (answer != 0)
            {
                chat.TextEd("\nThe Number " + numCheck + " is Odd\n", "green");
                Console.ReadKey();
                Menu();
            }
            else
            {
                chat.TextEd("\nThe Number " + numCheck + " is Even\n", "green");
                Console.ReadKey();
                Menu();
            }
        }

        private static double IsOddEven(long numCheck)
        {
           return numCheck % 2;
        }

        private static long AskForInt(string query)
        {
            chat.TextEd(query, "cyan");
            var inputString = Console.ReadLine();
            long output;
            while (!long.TryParse(inputString, out output))
            {
                chat.TextEd("Please enter an integer.", "cyan");
                inputString = Console.ReadLine();
            }

            return output;
        }
    }
}