using System.Drawing;

namespace GeometricFigure
{
    class Principal
    {
        static void Main()
        {

            Square square = new(2, "cm");
            ConsoleViewManager.DisplayFigureInfo(square);
            square.ModifySideLength(5);
            square.ModifyUnitOfMeasurement("mm");
            ConsoleViewManager.DisplayFigureInfo(square);

            Triangle triangle = new(5, 10, "cm");
            ConsoleViewManager.DisplayFigureInfo(triangle);
            triangle.ModifyBaseLength(4);
            triangle.ModifyHeight(8);
            triangle.ModifyUnitOfMeasurement("mm");
            ConsoleViewManager.DisplayFigureInfo(triangle);

            Rectangle rectangle = new(5, 10, "cm");
            ConsoleViewManager.DisplayFigureInfo(rectangle);
            rectangle.ModifyHeight(8);
            rectangle.ModifyUnitOfMeasurement("mm");
            ConsoleViewManager.DisplayFigureInfo(rectangle);

            Rhombus rhombus = new(20, 10, "cm");
            ConsoleViewManager.DisplayFigureInfo(rhombus);
            rhombus.ModifyMajorDiagonal(5);
            rhombus.ModifyMinorDiagonal(4);
            rhombus.ModifyUnitOfMeasurement("mm");
            ConsoleViewManager.DisplayFigureInfo(rhombus);

            Circle circle = new(20, "cm");
            ConsoleViewManager.DisplayFigureInfo(circle);
            circle.ModifyData(8, "cm");
            ConsoleViewManager.DisplayFigureInfo(circle);
            
            Ellipse ellipse = new(20,15, "cm");
            ConsoleViewManager.DisplayFigureInfo(ellipse);
            ellipse.ModifyData(8,6, "cm");
            ConsoleViewManager.DisplayFigureInfo(ellipse);

        }
    }
}