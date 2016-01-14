namespace CohesionAndCoupling
{
    using System;

    public class Point : IPoint
    {
        private double x;
        private double y;
        private double z;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(double x, double y, double z) 
            : this(x, y)
        {
            this.Z = z;
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

        public double Z
        {
            get
            {
                return this.z;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Value cannot be null.");
                }

                this.z = value;
            }
        }
    }
}
