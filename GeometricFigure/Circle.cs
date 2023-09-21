using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureExercise
{
   public class Circle : IGeometricFigure
    {
        double Radius { get; set; }
        private  string _unitOfMeasurement;
        private  string _name;
        private  double _area;
        private  double _perimeter;
        public string UnitOfMeasurement
        {
            get { return _unitOfMeasurement; }
            set { _unitOfMeasurement = value; }
        }
        public string GeometricFigureName
        {
            get { return _name; }
            set { _name = value; } 
        }
        public  double Area { 
            get{
                return _area = 2 * Math.PI * Radius;
              } 
            set { _area = value; } 
        }
        public  double Perimeter {
            get
            {
                return _perimeter = Math.PI * Math.Pow(Radius, 2);
            }
            set { _perimeter = value; } 
        }

        public Circle(double radius, string unitOfMeasurement)
        {
            this._name = "Circle";
            this.Radius = radius;
            this._unitOfMeasurement = unitOfMeasurement;
        }
        public  double CalculateDiameter()
        {
            double Diameter = 2 * Radius;
            return Diameter;
        }
        public void ModifyData(int Radius, string UnitOfMeasurement)
        {
            this.Radius = Radius;
            this._unitOfMeasurement = UnitOfMeasurement;
        }

    }
}
