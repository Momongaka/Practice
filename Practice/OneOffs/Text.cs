using System;

namespace Practice
{
    public class Text
    {
        /// <summary>
        /// TextEd returns text to the console with numerous adjustments
        /// </summary>
        /// <param name="message"> string to output </param>
        /// <param name="color"> text desired color output </param>
        /// <param name="align"> text alignment output </param>
        public void TextEd(string message, string color = "", string align = "")
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


        /// <summary>
        /// Asks for input that must be an integer otherwise error
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public long AskForInt(string query)
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
    }
}