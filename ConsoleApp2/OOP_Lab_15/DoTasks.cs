using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    internal class DoTasks
    {
        public void Task1(TextBox textBox3, TextBox textBox2, TextBox textBox1)
        {
            ICubeActions cube = new CubeActions();
            cube.RibLength = Convert.ToDouble(textBox3.Text);

            cube.SetCubeVolume();
            cube.SetCubeLateralSurfaceSquare();

            textBox1.Text = Convert.ToString(cube.CubeVolume);
            textBox2.Text = Convert.ToString(cube.CubeLateralSurfaceSquare);

        }

        public void Task2()
        {

        }
    }
}
