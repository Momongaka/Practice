namespace Practice
{
    public class NumGen
    {
        static Text text = new Text();

        /// <summary>
        /// Generates an array ending with as many items as inputed
        /// </summary>
        /// <returns></returns>
        public static int[] GenerateNumbers()
        {
            var number = text.AskForInt("Array length to generate? Input Number greater than 0: ");

            int[] array1 = new int[number];

            for (int i = 0; i < (array1.Length); i++)
            {
                array1[i] = i + 1;
            }

            text.TextEd("Generated numbers\n");
            //Console.WriteLine(string.Join("\n", array1));
            return array1;
        }
    }
}