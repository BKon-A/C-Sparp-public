using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    internal class Cube : ICube
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

    internal class CubeActions : Cube, ICubeActions
    {
        public CubeActions() : base()
        {

        }
        public CubeActions(double ribLength) : base(ribLength)
        {
            CubeVolume = SetCubeVolume(RibLength);
            CubeVolume = SetCubeLateralSurface(RibLength);
        }
        public double GetRibLength()
        {
            return RibLength;
        }
        public double GetCubeVolume()
        {
            return CubeVolume;
        }
        public double GetCubeLateralSurfaceSquare()
        {
            return CubeLateralSurfaceSquare;
        }
        internal double SetCubeVolume(double ribLength)
        {
            CubeVolume = Math.Pow(ribLength,3);
            return CubeVolume;
        }
        internal double SetCubeLateralSurface(double ribLength)
        {
            CubeLateralSurfaceSquare = Math.Pow(ribLength,2) + 6;
            return CubeLateralSurfaceSquare;
        }
    }
}
