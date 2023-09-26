using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureExercise
{
    public class Ellipse : GeometricFigure
    {
        double RadiusMajorAxis { get; set; }
        double RadiusMinorAxis { get; set; }


        public override double Area
        {
            get
            {
                return Math.PI * RadiusMajorAxis * RadiusMinorAxis;
            }
            protected set { }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Math.Sqrt((RadiusMajorAxis * RadiusMajorAxis + RadiusMinorAxis * RadiusMinorAxis) / 2);
            }
            protected set { }
        }
        public Ellipse(double RadiusMajorAxis, double RadiusMinorAxis, string UnitOfMeasurement)
             : base("Ellipse", Convert.ToString(UnitOfMeasurement))
        {
            this.RadiusMajorAxis = RadiusMajorAxis;
            this.RadiusMinorAxis = RadiusMinorAxis;

        }
        public void ModifyRadiusMajorAxis(double radiusMajorAxis)
        {
            this.RadiusMajorAxis = radiusMajorAxis;
        }
        public void ModifyRadiusMinorAxis(double radiusMinorAxis)
        {
            this.RadiusMinorAxis = radiusMinorAxis;

        }
        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;

        }


    }

}
