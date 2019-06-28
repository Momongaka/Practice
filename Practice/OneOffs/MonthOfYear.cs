namespace Practice
{
    public class MonthOfYear
    {
        static Text text = new Text();

        private enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        /// <summary>
        /// Returns a the month given a number
        /// </summary>
        public static void NumToMonth()
        {
            var monthNumber = text.AskForInt("Enter Number from 1 to 12: ");
            Month month = (Month) monthNumber;
            text.TextEd("The month is: " + month);
        }
    }
}