using System;

namespace Practice
{
    public class ArrayTest
    {
        public static void ATest()
        {
            int[] numbers = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};
            int[] copyTo = new int [numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                copyTo[i] = numbers[i];
            }

            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine();
            Console.WriteLine(string.Join(",", copyTo));
        }
    }
}