namespace Practice
{
    public class Color
    {
        private byte red;

        public byte Red
        {
            get => red;
            set => red = value;
        }

        public byte Green { get; set; }

        public byte Blue { get; set; }

        public byte Alpha { get; private set; }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
    }
}