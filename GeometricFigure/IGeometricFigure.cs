using System;

namespace GeometricFigureExercise
{
    public interface IGeometricFigure
    {
        public  double Area { get; }
        public  double Perimeter { get; }
        public string GeometricFigureName { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
