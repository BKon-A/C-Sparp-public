using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    internal interface ICube
    {
        double RibLength { get; set; }
        double CubeVolume { get; set; }
        double CubeLateralSurfaceSquare { get; set;}
    }
    internal interface ICubeActions : ICube
    {
        void SetCubeVolume();
        void SetCubeLateralSurfaceSquare();
        void SetCubeVolume(double cubeVolume);
        void SetCubeLateralSurfaceSquare(double cubeLateralSurfaceSquare);
    }
}
