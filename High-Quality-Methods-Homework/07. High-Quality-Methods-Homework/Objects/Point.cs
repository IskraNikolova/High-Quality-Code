using System;

namespace Methods
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Value cannot be null.");
                }

                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Value cannot be null.");
                }

                this.y = value;
            }
        }

        public double CalculateDistanceBetweenTwoPoints(Point other)
        {
            double otherX = other.X;
            double otherY = other.Y;
            double distance = Math.Sqrt((otherX - this.X) * (otherX - this.X) +
                (otherY - this.Y) * (otherY - this.Y));

            return distance;
        }

        public override string ToString()
        {
            return $"{{{this.X}, {this.Y}}}";
        }
    }
}
