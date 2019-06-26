using System;

namespace Practice
{
    public class Stars
    {
        public static void Star()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = 4; column > row; column--)
                {
                    Console.Write(" ");
                }

                for (int column = 0; column < 2 * row + 1; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}