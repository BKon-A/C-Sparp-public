using System.Reflection.Metadata;

namespace OOP_Lab_15
{
    internal class DoTasks
    {
        internal List<string> values = new List<string>();

        IFile file = new FileManipulation("TextFile");
        public void Task1(TextBox textBox3, TextBox textBox2, TextBox textBox1)
        {
            ICube cube = new CubeActions(Convert.ToDouble(textBox3.Text));

            textBox1.Text = Convert.ToString(cube.CubeVolume);
            textBox2.Text = Convert.ToString(cube.CubeLateralSurfaceSquare);

        }

        public void Task2_Rename(string path)
        {
            file.FileRename(path);
        }
        public void Task2_Write(string path, List<string> values)
        {   
            file.FileWrite(path, values);
        }
        public string Task2_Read(string path)
        {
            try
            {
                return file.FileRead(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return string.Empty;
        }
    }
}
