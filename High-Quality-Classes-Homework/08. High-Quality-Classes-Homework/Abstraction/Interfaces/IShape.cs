namespace Abstraction
{
    public interface IShape
    {
        /// <summary>
        /// Calculate area of shape.
        /// </summary>
        /// <returns>Return number to area of type double.</returns>
        double CalculateArea();

        /// <summary>
        /// Calculate perimeter of shape.
        /// </summary>
        /// <returns>Return number of type double to perimeter.</returns>
        double CalculatePerimeter();
    }
}