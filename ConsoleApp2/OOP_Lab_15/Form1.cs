using System.Windows.Forms;

namespace OOP_Lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:\\Users\\bogda\\Downloads\\FireKreml.jpg");
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}