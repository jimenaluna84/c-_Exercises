using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Rhombus : GeometricFigure
    {
        public double MajorDiagonal { get; set; }
        public double MinorDiagonal { get; set; }
        public Rhombus(int MajorDiagonal, int MinorDiagonal, string UnitOfMeasurement)
        : base("Rhombus", Convert.ToString(UnitOfMeasurement))
        {
            this.MajorDiagonal = MajorDiagonal;
            this.MinorDiagonal = MinorDiagonal;

        }

        public override double Perimeter
        {
            get
            {
                double result = 0;
                if (MajorDiagonal < 0 || MinorDiagonal < 0)
                {
                    Console.WriteLine("The Area should not negative.");
                }
                else
                {
                    double Side1 = Math.Pow(((MajorDiagonal) / 2), 2);
                    double Side2 = Math.Pow(((MinorDiagonal) / 2), 2);
                    result = 4 * (Math.Sqrt(Side1 + Side2));
                }
                return result;
            }

        }
        public override double Area
        {
            get
            {
                double result = 0;
                if (MajorDiagonal < 0 || MinorDiagonal < 0)
                {
                    Console.WriteLine("The Area should not negative.");
                }
                else
                {
                    result = (MajorDiagonal * MinorDiagonal) / 2;
                }
                return result;
            }


        }


        public void ModifyMajorDiagonal(double MajorDiagonal)
        {
            this.MajorDiagonal = MajorDiagonal;

        }
        public void ModifyMinorDiagonal(double MinorDiagonal)
        {
            this.MinorDiagonal = MinorDiagonal;

        }
        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;
        }
    }
}
