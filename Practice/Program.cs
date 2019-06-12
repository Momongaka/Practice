using System;

namespace Practice
{
    static class Program
    {
        static ChatOp chat = new ChatOp();
        private static string ChoiceString { get; set; }
        private static int Choice { get; set; }

        static void Main(string[] args)
        {
            Menu();
        }

        private static int Base { get; set; }
        private static int Height { get; set; }
        private static double Area { get; set; }

        private static string BaseString { get; set; }
        private static string HeightString { get; set; }

        private static void Menu()
        {
            chat.TextEd("Choose program: Enter Number");
            chat.TextEd("\n1. Triangle Area", "green");
            chat.TextEd("\n2. Odd or Even\n", "green");
            chat.TextEd("\nHit Escape to Quit\n", "red");
            Console.Write("Enter Input Here:");
            ChoiceString = Console.ReadLine();
            Choice = int.Parse(ChoiceString);

            switch (Choice)
            {
                case 1:
                    CalcArea();
                    break;
                case 2:
                    OddEven();
                    break;
                default:
                    Menu();
                    break;
            }
        }


        private static void CalcArea()
        {
            chat.TextEd("\nFind the Area of a Triangle", "red", "center");

            chat.TextEd("What is the base of the triangle?", "cyan");
            BaseString = Console.ReadLine();
            Base = int.Parse(BaseString);

            chat.TextEd("What is the height of the triangle?", "cyan");
            HeightString = Console.ReadLine();
            Height = int.Parse(HeightString);

            Area = Base * Height / 2.0;
            chat.TextEd("The area is " + Area, "green");

            Console.ReadKey();

            Menu();
        }

        private static void OddEven()
        {
            chat.TextEd("\nWelcome to Odd or Even\n");
            Console.Write("Enter a Number Here:");
            var numChoice = Console.ReadLine();
            var numCheck = long.Parse(numChoice);

            var oddEven = numCheck % 2;

            if (oddEven != 0)
            {
                chat.TextEd("\nThe Number " + numCheck + " is Even\n", "green");
                Console.ReadKey();
                Menu();
            }

            else
            {
                chat.TextEd("\nThe Number " + numCheck + " is Odd\n", "green");
                Console.ReadKey();
                Menu();
            }
        }
    }
}