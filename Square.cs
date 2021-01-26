namespace shapes
{
    //Single responsibility - only creates the circle and assigns the value to the area

    public class Square : Shape 
    {
        public double Width;
        public double Height; 
        CalculateArea areaCalc = new CalculateArea();
        public Square(int width)
        {
            this.Width = width;
            this.Height = width;
            area = areaCalc.calculateArea(Width, Height);
        }
    }
}