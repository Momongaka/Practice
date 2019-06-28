using System;

namespace Practice
{
    public class Dice
    {
        public static void DiceRoll()
        {
            Random random = new Random();
            Text text = new Text();

            var numDice = text.AskForInt("How many Die do you want to roll?: ");

            for (int i = 0; i < numDice; i++)
            {
                int dieRoll = random.Next(6) + 1;
                text.TextEd("Roll Number " + (i + 1) + ":= " + dieRoll);
            }
        }
    }
}