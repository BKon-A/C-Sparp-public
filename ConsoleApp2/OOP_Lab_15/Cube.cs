namespace OOP_Lab_15
{
    abstract class Cube
    {
        public double RibLength { get; set; }
        public double CubeVolume { get; set; }
        public double CubeLateralSurfaceSquare { get; set;}

        public Cube()
        {
            RibLength = 1.5;
            CubeVolume = Math.Pow(RibLength, 3);
            CubeLateralSurfaceSquare = Math.Pow(RibLength, 2) * 6;
        }
        public Cube(double ribLength)
        {
            RibLength = ribLength;
        }
    }

    internal class CubeActions : Cube, ICube
    {

        public CubeActions() : base()
        {

        }
        public CubeActions(double ribLength) : base(ribLength)
        {
            CubeVolume = Math.Pow(ribLength, 3);
            CubeLateralSurfaceSquare = Math.Pow(ribLength, 2) * 6;
        }
    }
}


