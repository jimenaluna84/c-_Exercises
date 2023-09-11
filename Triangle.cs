using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Triangle : GeometricFigure
    {

        double _baseLength { get; set; }
        double _height { get; set; }
        double BaseLength {
            get => _baseLength;
            set
            {
                _baseLength = value;
            }
        }
        double Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }
        public override double Perimeter
        {
            get
            {
                double sideData = 0;
                if (_baseLength < 0 || _height <0)
                {
                    Console.WriteLine("El perímetro no puede ser negativo.");
                }
                else
                {
                    double Side1 = Math.Pow(_baseLength, 2);
                    double Side2 = Math.Pow(_height, 2);
                    sideData = _baseLength + _height + Math.Sqrt(Side1 + Side2);
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
            //        _baseLength = value;
            //    }
            //}
        }
        public override double Area
        {
            get
            {
                double sideData = 0;
                if (_baseLength < 0 || _height < 0)
                {
                    Console.WriteLine("El área no puede ser negativa.");
                }
                else
                {
                    sideData = (_baseLength * _height) / 2;
                }
                return sideData;
            }
        }
        public Triangle(double BaseLength, double Height, string UnitOfMeasurement)
        : base("Triangle", Convert.ToString(UnitOfMeasurement))
        {
            this._baseLength = BaseLength;
            this._height = Height;

        }
          
        public void ModifyBaseLength(double BaseLength)
        {
            this.BaseLength = BaseLength;
        } public void ModifyHeight(double Height)
        {
            this.Height = Height;
        }

        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;
        }
    }
}
