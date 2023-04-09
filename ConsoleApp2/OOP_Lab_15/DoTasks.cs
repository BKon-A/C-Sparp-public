using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    internal class DoTasks
    {
        IFile file = new FileManipulation("TextFile");
        public void Task1(TextBox textBox3, TextBox textBox2, TextBox textBox1)
        {
            ICube cube = new CubeActions(Convert.ToDouble(textBox3.Text));

            textBox1.Text = Convert.ToString(cube.CubeVolume);
            textBox2.Text = Convert.ToString(cube.CubeLateralSurfaceSquare);

        }

        public void Task2_Rename(string name)
        {
            file.FileRename(name);
        }
        public void Task2_Write()
        {

        }
        public void Task2_Read()
        {

        }
    }
}
