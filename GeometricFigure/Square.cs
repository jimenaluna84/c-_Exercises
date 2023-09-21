using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricFigureExercise
{
    public class Square : GeometricFigure
    {
        private double _sideLength;
        public double SideLength
        {
            get => _sideLength;
            set
            {
                _sideLength = value;
            }
        }

        public Square(double SideLength, string UnitOfMeasurement)
        : base("Square", Convert.ToString(UnitOfMeasurement))
        {
            this._sideLength = SideLength;
        }

       
        public override double Perimeter
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.IsValid(_sideLength))
                {
                    result = 4 * _sideLength;
                }
                return result;
            }
           

        }
        public override double Area
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.IsValid(_sideLength))
                {
                    result = _sideLength * _sideLength;
                }
                return result;
            }


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
