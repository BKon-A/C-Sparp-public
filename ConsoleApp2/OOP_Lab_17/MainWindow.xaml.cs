using System.Windows;
using System.Windows.Controls;

namespace OOP_Lab_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBoxWidth.Text = "0";
            TextBoxHeight.Text = "0";
        }

        private void Button_ClickDrawFigure(object sender, RoutedEventArgs e)
        {
            int centerX = 250;
            int centerY = 250;

            HourglassDraw hourglassDraw = new HourglassDraw(int.Parse(TextBoxWidth.Text), int.Parse(TextBoxHeight.Text));

            hourglassDraw.BuildHouglass(CanvasDraw, centerX, centerY, int.Parse(TextBoxWidth.Text), int.Parse(TextBoxHeight.Text));
        }

        private void Button_ClickReadFile(object sender, RoutedEventArgs e)
        {
            HourglassSerialization hourglass;

            if (Action.SelectedIndex == 0 && SerializeType.SelectedIndex == 1)
            {
                hourglass = HourglassSerialization.JsonDeserialization(TextBoxFileName.Text);
                
            }
            else if (Action.SelectedIndex == 1 && SerializeType.SelectedIndex == 1)
            {
                hourglass = HourglassSerialization.XmlDeserialization(TextBoxFileName.Text) ?? new();
   
            }
            else
            {
                return;
            }    
            TextBoxHeight.Text = hourglass.Height.ToString();
            TextBoxWidth.Text = hourglass.Width.ToString();
        }

        private void Button_ClickWriteToFile(object sender, RoutedEventArgs e)
        {
            var hourglassSerialization = new HourglassSerialization(int.Parse(TextBoxWidth.Text), int.Parse(TextBoxHeight.Text), TextBoxFileName.Text);

            if (SerializeType.SelectedIndex == 0)
            {
                hourglassSerialization.JsonSerialization(TextBoxFileName.Text);
            }
            else
            {
                hourglassSerialization.XmlSerialization(TextBoxFileName.Text);
            }
        }
    }
}
