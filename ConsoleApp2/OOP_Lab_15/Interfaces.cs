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
    internal interface IFile
    {
        string FileName { get; set; }

        void FileRename(string name);
        void FileWrite(string name);
    }
}
