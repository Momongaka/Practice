using System;

namespace Practice
{
    public class ChatOp
    {
        public void TextEd(string message, string color="", string align="")
        {
            if (color== "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (color == "cyan")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

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
    }
}