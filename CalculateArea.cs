using System;

namespace shapes
{
    //Single responsibility - only calculates the area and nothing else
    //liskov substitution - implements multiple interfaces 
    public class CalculateArea : SquareInterface, CirlceInterface
    {
        public CalculateArea()
        {}
        public double calculateArea(double height, double width)
        {
            return height * height;
        }

        public double calculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}