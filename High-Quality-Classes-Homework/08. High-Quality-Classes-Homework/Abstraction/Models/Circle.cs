namespace Abstraction.Models
{
    public class Circle : Figure
    {
        private const int Мultiplier = 2;
        private const double PI = 3.14;

        public Circle(double radius)
            : base(radius)
        {
        }

        public override double CalculateArea()
        {
            double radius = this.Width;
            double area = PI * (radius * radius);
            return area;
        }

        public override double CalculatePerimeter()
        {
            double radius = this.Width;
            double perimeter = Мultiplier * PI * radius;
            return perimeter;
        }
    }
}
