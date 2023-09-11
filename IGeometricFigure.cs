using System;

namespace GeometricFigure
{
    public interface IGeometricFigure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public string GeomericFigureName { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
