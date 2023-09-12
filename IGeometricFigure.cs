﻿using System;

namespace GeometricFigure
{
    public interface IGeometricFigure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public string GeometricFigureName { get; set; }
        public string UnitOfMeasurement { get; set; }
    }
}
