using System;

namespace Practice
{
    public class ReverseArray
    {
        /// <summary>
        /// reverses an array
        /// </summary>
        /// <param name="array1"></param>
        public static void Reverse(int[] array1)
        {
            Array.Reverse(array1, 0, array1.Length);
            Console.WriteLine(string.Join("\n", array1));
        }
    }
}