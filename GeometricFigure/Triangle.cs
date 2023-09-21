using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricFigureExercise
{
    public class Triangle : GeometricFigure
    {

        double _baseLength { get; set; }
        double _height { get; set; }
       public double BaseLength {
            get => _baseLength;
            set
            {
                _baseLength = value;
            }
        }
       public double Height
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
                double result = 0;
                if (ConsoleViewManager.AreValid(_baseLength, _height))
                {
                    double Side1 = Math.Pow(_baseLength, 2);
                    double Side2 = Math.Pow(_height, 2);
                    result = _baseLength + _height + Math.Sqrt(Side1 + Side2);
                }
                return result;
            }
            
        }
        public override double Area
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.AreValid(_baseLength, _height))
                    {
                    result = (_baseLength * _height) / 2;
                }
                return result;
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
