using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_15
{
    public partial class TaskForm1 : Form
    {
        public TaskForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Exit
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) // Back
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoTasks DoTask1 = new DoTasks();

            DoTask1.Task1(textBox3, textBox2, textBox1);
        }
    }
}
