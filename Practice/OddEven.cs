namespace Practice
{
    public class OddEven
    {
        static Text text = new Text();
        public static void Check()
        {
            text.TextEd("\nWelcome to Odd or Even\n");
            var numChoice = text.AskForInt("Enter a number");

            string state = IsEven(numChoice) ? "even" : "odd";
            text.TextEd($"The number {numChoice} is {state}.", "green");
        }

        private static bool IsEven(long numCheck) => (numCheck % 2) == 0;
    }
}