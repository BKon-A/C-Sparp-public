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
    internal partial class TaskForm2 : Form
    {
        public TaskForm2()
        {
            InitializeComponent();

            textBox5.Text = "Defoult.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) // Reverse
        {
            string userName;

            userName = textBox1.Text + " " + textBox2.Text;

            userName = new string(userName.Reverse().ToArray());

            textBox3.Text = userName;

        }

        private void button4_Click(object sender, EventArgs e) // Length
        {
            textBox4.Text = Convert.ToString(textBox3.Text.Length);
        }

        private void button8_Click(object sender, EventArgs e) // Clear
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e) // Rename File
        {
            DoTasks task2 = new DoTasks();

            task2.Task2_Rename(textBox5.Text);
        }

        private void button7_Click(object sender, EventArgs e) // Write to File
        {
            DoTasks task2 = new DoTasks();

            task2.values.Add(textBox1.Text);
            task2.values.Add(textBox2.Text);

            task2.Task2_Write(textBox5.Text, task2.values);
        }

        private void button6_Click(object sender, EventArgs e) // Read File
        {
            
            DoTasks task2 = new DoTasks();

            textBox6.Text = task2.Task2_Read(textBox5.Text);
        }
    }
}
