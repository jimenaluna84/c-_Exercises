using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricFigureExercise
{
    public class Triangle : GeometricFigure
    {

       
       public double BaseLength { get; set;  }
       public double Height { get; set; }
        
        public override double Perimeter
        {
            get
            {
                double result = 0;
                if (ConsoleViewManager.AreValid(BaseLength, Height))
                {
                    double Side1 = Math.Pow(BaseLength, 2);
                    double Side2 = Math.Pow(Height, 2);
                    result = BaseLength + Height + Math.Sqrt(Side1 + Side2);
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
                if (ConsoleViewManager.AreValid(BaseLength, Height))
                    {
                    result = (BaseLength * Height) / 2;
                }
                return result;
            }

            protected set { }
        }
        public Triangle(double BaseLength, double Height, string UnitOfMeasurement)
        : base("Triangle", Convert.ToString(UnitOfMeasurement))
        {
            this.BaseLength = BaseLength;
            this.Height = Height;

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
