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
        protected double CubeVolume { get; set; }
        protected double CubeLateralSurfaceSquare { get; set;}
    }
    internal interface ICubeActions
    {
        public double GetRibLength();
        public double GetCubeVolume();
        public double GetCubeLateralSurfaceSquare();
    }
}
