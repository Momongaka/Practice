namespace Practice
{
    public class Ball
    {
       public Color Color { get; set; }
       
       public float Radius { get; set; }

       private int timeThrown;

       public Ball(Color color, float radius)
       {
           Color = color;
           Radius = radius;
           this.timeThrown = 0;
       }

       public void Pop()
       {
           Radius = 0;
       }

       public void Throw()
       {
           if (Radius > 0)
           {
               timeThrown++;
           }
       }

       public int GetTimesThrown()
       {
           return timeThrown;
       }
    }
}