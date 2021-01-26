namespace shapes
{
    //Single responsibility - only creates the circle and assigns the value to the area
    public class Circle : Shape
    {
        public double Radius;

        CalculateArea areaCalc = new CalculateArea();

        public Circle(int radius)
        {
            this.Radius = radius;
            area = areaCalc.calculateArea(Radius);
        }
    }
}  