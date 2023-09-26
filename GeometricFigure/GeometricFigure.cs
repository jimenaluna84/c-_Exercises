namespace GeometricFigureExercise
{
    public abstract class GeometricFigure: IGeometricFigure
    {
       public abstract double Area { get; protected set; }
        public abstract double Perimeter { get; protected set; }
        public string  GeometricFigureName { get;  set; }
        public string UnitOfMeasurement { get; set; }
        public  GeometricFigure(string GeomericFigureName, string UnitOfMeasurement)
        {
            this.GeometricFigureName = GeomericFigureName;
            this.UnitOfMeasurement = UnitOfMeasurement;
        }
    }
}
