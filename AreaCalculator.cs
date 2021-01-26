namespace shapes
{
    public class AreaCalculator
    {
        //Single responsibility - class only calculates the area and nothing else
        public double totalArea = 0;

        //Liskov principle, can use any type of shape here instead of just shapes such as an array of circles and it can calculate the area
        public void setArea(Shape[] shapes)
        {
            foreach(var Shape in shapes)
            {
                totalArea += Shape.area;
            }
        }
    }
}