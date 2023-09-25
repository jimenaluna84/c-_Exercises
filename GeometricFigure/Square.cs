using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricFigureExercise
{
    public class Square : GeometricFigure
    {
      
        public double SideLength { get; set; }
   

        public Square(double SideLength, string UnitOfMeasurement)
        : base("Square", Convert.ToString(UnitOfMeasurement))
        {
            this.SideLength = SideLength;
        }

       
        public override double Perimeter
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.IsValid(SideLength))
                {
                    result = 4 * SideLength;
                }
                return result;
            }
            protected set { }


        }
        public override double Area
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.IsValid(SideLength))
                {
                    result = SideLength * SideLength;
                }
                return result;
            }
            protected set { }


        }

        public double Side { get; }

        public void ModifySideLength(double SideLength)
        {
            this.SideLength = SideLength;
        }
        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;

        }
    }
}
