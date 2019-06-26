namespace Practice
{
    public class Triangle
    {
        
        public static void TriangleArea()
        {
            Text text = new Text();
            
            text.TextEd("\nFind the Area of a Triangle", "red", "center");

            long triBase = text.AskForInt("What is the base of the triangle?");
            var triHeight = text.AskForInt("What is the height of the triangle?");

            var triArea = GetArea(triBase, triHeight);
            text.TextEd("The area is " + triArea, "green");
        }

        /// <summary>
        /// mathematical calculations to find area given base and height
        /// </summary>
        /// <param name="triBase"></param>
        /// <param name="triHeight"></param>
        /// <returns></returns>
        private static double GetArea(long triBase, long triHeight)
        {
            return triBase * triHeight / 2.0;
        }
    }
}