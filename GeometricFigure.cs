namespace GeometricFigure
{
    public abstract class GeometricFigure: IGeometricFigure
    {
       public virtual double Area { get; set; }
        public virtual double Perimeter { get; set; }
        public string  GeomericFigureName { get;  set; }
        public string UnitOfMeasurement { get; set; }
        public  GeometricFigure(string GeomericFigureName, string UnitOfMeasurement)
        {
            this.GeomericFigureName = GeomericFigureName;
            this.UnitOfMeasurement = UnitOfMeasurement;
        }
    }
}
