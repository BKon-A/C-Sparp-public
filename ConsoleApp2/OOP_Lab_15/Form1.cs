using System.Windows.Forms;

namespace OOP_Lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskForm1 taskForm1 = new TaskForm1();
            taskForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskForm2 taskForm2 = new TaskForm2();
            taskForm2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:\\Users\\bogda\\Downloads\\BurningKreml.jpg");
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}