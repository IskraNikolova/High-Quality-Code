namespace Methods
{
    using System;

    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Side cannot be negative.");
                }
               
                this.sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Side cannot be negative.");
                }

                this.sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Side cannot be negative.");
                }
             
                this.sideC = value;
            }
        }

        public double CalcTriangleArea()
        {
            if (this.SideA >= this.SideB + this.SideC || this.SideB >= this.SideA + this.SideC ||
                this.SideC >= this.SideA + this.SideB)
            {
                throw new ArithmeticException("Invalid sides for triangle.");
            }  
                  
            double area = (this.sideA + this.SideB + this.SideC) / 2;
   
            return area;
        }
    }
}
