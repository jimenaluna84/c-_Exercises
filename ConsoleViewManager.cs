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
            System.Console.WriteLine("6************************************");
            Console.WriteLine($"----Figure: {figure.GeomericFigureName}----");
            Console.WriteLine("Area: " + figure.Area + " " +figure.UnitOfMeasurement + "\n" + "Perimeter: " + figure.Perimeter + " " + figure.UnitOfMeasurement);
        }
    }


}
