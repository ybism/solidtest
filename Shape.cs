namespace shapes
{
    //Open-Closed principle, allows creating new shapes and only have to inherit properties from the top level so can be passed into calculate area methods. 
    public class Shape
    {
        public double area;
    }
}