namespace Practice.OneOffs
{
    public class PlayBall
    {
        static Text text = new Text();

        // Create two different balls of different colors and sizes.
        private static Ball bigRed = new Ball(new Color(255, 0, 0), 5);
        private static Ball lilPur = new Ball(new Color(255, 0, 255), 3);

        public static void RedThrow()
        {
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            text.TextEd("Total Times Red Thrown: " + bigRed.GetTimesThrown());

            bigRed.Throw();
            bigRed.Throw();
            text.TextEd("Total Times Red Thrown: " + bigRed.GetTimesThrown());

            lilPur.Throw();
            lilPur.Throw();
            text.TextEd("Total Times Purple Thrown: " + lilPur.GetTimesThrown());

            lilPur.Pop();
            lilPur.Throw();
            text.TextEd("Total Times Purple Thrown: " + lilPur.GetTimesThrown());
        }
    }
}