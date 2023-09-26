using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureExercise
{
    public class Rectangle : GeometricFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double Width, double Height, string UnitOfMeasurement)
        : base("Rectangle", Convert.ToString(UnitOfMeasurement))
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double Perimeter
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.AreValid(Width, Height))
                {
                    result = (2 * this.Width) + (2 * this.Height);
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
                if (ConsoleViewManager.AreValid(Width, Height))
                { 
                    result = this.Width * this.Height;
                }
                return result;
            }
            protected set { }
        }
        public void ModifyWidth(double Width)
        {
            this.Width = Width;
        }
        public void ModifyHeight( double Height)
        {
            this.Height = Height;
        }
        public void ModifyUnitOfMeasurement(string UnitOfMeasurement)
        {
            this.UnitOfMeasurement = UnitOfMeasurement;
        }

    }
}
