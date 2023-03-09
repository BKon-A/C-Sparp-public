namespace OOP_Lab_12
{
    abstract class NormalVector
    {
        internal double CoordinateX { get; set; }
        internal double CoordinateY { get; set; }

        internal double UnitVector;

        public NormalVector()
        {

        }
        public NormalVector(double coordinateX, double coordinateY)
        {

        }

        ~NormalVector() { }
    }
}
