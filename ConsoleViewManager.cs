using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure;

namespace GeometricFigure
{
    public class ConsoleViewManager
    {
        public static void DisplayFigureInfo(IGeometricFigure figure)

        {
            System.Console.WriteLine("7************************************");
            Console.WriteLine($"----Figure: {figure.GeometricFigureName}----");
            Console.WriteLine("Area: " + figure.Area + " " +figure.UnitOfMeasurement + "\n" + "Perimeter: " + figure.Perimeter + " " + figure.UnitOfMeasurement);
        }

        public static bool IsValid(double Data)

        {
            bool Result  = false;
            if (Data < 0)
            {
                Console.WriteLine("The Value should not negative.");
                
            }
            else
            {
                Result = true;
            
             }
           return Result;
        }
        public static bool AreValid(double Data1, double data2)

        {
            bool Result = false;
            if (Data1 < 0 || data2 < 0)
            {
                Console.WriteLine("The Value should not negative.");

            }
            else
            {
                Result = true;

            }
            return Result;
        }
    }


}
