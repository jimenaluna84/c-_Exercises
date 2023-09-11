using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Square : GeometricFigure
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
            get {
                double sideData = 0;
                if (_sideLength < 0)
                {
                    Console.WriteLine("El perímetro no puede ser negativo.");
                }
                else
                {
                    sideData = 4 * _sideLength;
                }
                return sideData; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El perímetro no puede ser negativo.");
                }
                else
                {
                    _sideLength = value / 4;
                }
            }
        }
        public override double Area
        {
            get
            {
                double sideData = 0;
                if (_sideLength < 0)
                {
                    Console.WriteLine("El área no puede ser negativa.");
                }
                else
                {
                    sideData = _sideLength * _sideLength;
                }
                return sideData;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("El área no puede ser negativa.");
                }
                else
                {
                    _sideLength = Math.Sqrt(value);
                }
            }
        }
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
