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
                double sideData = 0;
                if (MajorDiagonal < 0 || MinorDiagonal < 0)
                {
                    Console.WriteLine("El perímetro no puede ser negativo.");
                }
                else
                {
                    double Side1 = Math.Pow(((MajorDiagonal) / 2), 2);
                    double Side2 = Math.Pow(((MinorDiagonal) / 2), 2);
                    sideData = Convert.ToInt32(4 * (Math.Sqrt(Side1 + Side2)));
                }
                return sideData;
            }
            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("El perímetro no puede ser negativo.");
            //    }
            //    else
            //    {
            //        _sideLength = value / 4;
            //    }
            //}
        }
        public override double Area
        {
            get
            {
                double sideData = 0;
                if (MajorDiagonal < 0 || MinorDiagonal < 0)
                {
                    Console.WriteLine("El área no puede ser negativa.");
                }
                else
                {
                    sideData = (MajorDiagonal * MinorDiagonal) / 2;
                }
                return sideData;
            }

            //set
            //{
            //    if (value < 0)
            //    {
            //        Console.WriteLine("El área no puede ser negativa.");
            //    }
            //    else
            //    {
            //        _sideLength = Math.Sqrt(value);
            //    }
            //}
        }

        //public override double CalculateArea()
        //{
        //    double Area = (MajorDiagonal * MinorDiagonal) / 2;
        //    return Area;
        //}

        //public override double CalculatePerimeter()
        //{

        //    double Side1 = Math.Pow(((MajorDiagonal) / 2), 2);
        //    double Side2 = Math.Pow(((MinorDiagonal) / 2), 2);
        //    int Perimeter = Convert.ToInt32(4 * (Math.Sqrt(Side1 + Side2)));
        //    return Perimeter;
        //}



        //public override void DisplayFigureInfo()
        //{
        //    base.DisplayFigureInfo();
        //    Console.WriteLine($"MajorDiagonal: {MajorDiagonal} {UnitOfMeasurement}");
        //    Console.WriteLine($"MinorDiagonal: {MinorDiagonal} {UnitOfMeasurement}");
        //    Console.WriteLine($"Area: {CalculateArea()} Rhombus {UnitOfMeasurement}");
        //    Console.WriteLine($"Perimeter: {CalculatePerimeter()} {UnitOfMeasurement}");
        //    System.Console.WriteLine();
        //}

        public void ModifyData(int MajorDiagonal, int MinorDiagonal, string UnitOfMeasurement)
        {
            this.MajorDiagonal = MajorDiagonal;
            this.MinorDiagonal = MinorDiagonal;
            this.UnitOfMeasurement = UnitOfMeasurement;
        }

    }
}
