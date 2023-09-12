using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Ellipse : IGeometricFigure
    {
        double RadiusMajorAxis { get; set; }
        double RadiusMinorAxis { get; set; }

        private string _unitOfMeasurement;
        private string _name;
        private double _area;
        private double _perimeter;

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
        public double Area
        {
            get
            {
                return _area = Math.PI * RadiusMajorAxis * RadiusMinorAxis;
            }
            set { _area = value; }
        }
        public double Perimeter
        {
            get
            {
                return Convert.ToInt32(2 * Math.PI * Math.Sqrt((RadiusMajorAxis * RadiusMajorAxis + RadiusMinorAxis * RadiusMinorAxis) / 2));
            }
            set { _perimeter = value; }
        }
        public Ellipse(double RadiusMajorAxis, double RadiusMinorAxis, string unitOfMeasurement)
        {
            this.GeometricFigureName = "Ellipse";
            this.RadiusMajorAxis = RadiusMajorAxis;
            this.RadiusMinorAxis = RadiusMinorAxis;
            this.UnitOfMeasurement = unitOfMeasurement;
        }
        public void ModifyData(int radiusMajorAxis, int radiusMinorAxis, string unitOfMeasurement)
        {
            this.RadiusMajorAxis = radiusMajorAxis;
            this.RadiusMinorAxis = radiusMinorAxis;
            this.UnitOfMeasurement = unitOfMeasurement;
        }

    }

}
