using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureExercise
{
   public class Circle : GeometricFigure
    {
        private double Radius { get; set; }
       
       
        public override double Area{
            get { return 2 * Math.PI * Radius; }
            protected set { }

        }
        public override double Perimeter {
            get { return Math.PI * Math.Pow(Radius, 2); }
            protected set { }  
        }

        public Circle(double radius, string UnitOfMeasurement)
            :base("Circle", Convert.ToString(UnitOfMeasurement))
        {
            this.Radius = radius;
           
        }
        public  double CalculateDiameter()
        {
            double Diameter = 2 * Radius;
            return Diameter;
        }
        public void ModifyRadius(double Radius)
        {
            this.Radius = Radius;
         
        }
        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;

        }

    }
}
