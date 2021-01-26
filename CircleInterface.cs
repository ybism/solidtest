namespace shapes
{
    //interface segregation - seperate interfaces for the circle and square calculate area if changes need to be made
    public interface CirlceInterface
    {
        double calculateArea(double radius);
    }
}