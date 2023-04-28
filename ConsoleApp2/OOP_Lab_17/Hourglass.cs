using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml.Serialization;
#pragma warning disable SYSLIB0011

namespace OOP_Lab_17
{
    [Serializable]
    internal class Hourglass
    {
        [XmlAttribute]
        public int Width { get; set; }
        [XmlAttribute]
        public int Height { get; set; }
        [JsonIgnore]
        public string Path { get; set; }

        public Hourglass()
        {
            Width = 0;
            Height = 0;
            Path = "hourglass";
        }
        public Hourglass(int width, int height)
        {
            Width = width;
            Height = height;
            Path = "hourglass";
        }
        public Hourglass(int width, int height, string path)
        {
            Width = width;
            Height = height;
            Path = path;
        }
    }

    [Serializable]
    internal class HourglassSerialization : Hourglass
    {
        public HourglassSerialization() : base()
        {

        }
        public HourglassSerialization(int width, int height) : base(width, height)
        {

        }
        public HourglassSerialization(int width, int height, string path) : base(width, height, path)
        {

        }

        public void JsonSerialization(string path)
        {
            string jsonString = JsonConvert.SerializeObject(this);
            File.WriteAllText(path + ".json", jsonString);
        }
        public static HourglassSerialization JsonDeserialization(string path)
        {

            string jsonString = File.ReadAllText(path + ".json");

            return JsonConvert.DeserializeObject<HourglassSerialization>(jsonString)!;

        }

        //public void BinarySerialization(int width, int height, string path)
        //{
        //    Hourglass serializeHourglass = new HourglassSerialization(width, height);

        //    BinaryFormatter binaryFormatter = new BinaryFormatter();

        //    using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        binaryFormatter.Serialize(fileStream, serializeHourglass);
        //    }
        //}
        //public void BinaryDeserialization(string path)
        //{
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();

        //    using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        Hourglass deserializeHouglass = (HourglassSerialization)binaryFormatter.Deserialize(fileStream);

        //    }
        //}

        public void XmlSerialization(string path)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(HourglassSerialization));

            using (FileStream fileStream = new FileStream(path + ".xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, this);
            }
        }
        public static HourglassSerialization? XmlDeserialization(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(HourglassSerialization));

            using FileStream fileStream = new FileStream(path + ".xml", FileMode.OpenOrCreate);

            return xmlSerializer.Deserialize(fileStream) as HourglassSerialization;
        }

        public override string ToString()
        {
            return $"Width: {Width}\nHeight: {Height}\n";
        }
    }
    internal class HourglassDraw : Hourglass
    {

        public HourglassDraw() : base()
        {

        }
        public HourglassDraw(int width, int height) : base(width, height)
        {

        }

        public void BuildHouglass(Canvas canvas, double centerX, double centerY, int width, int height)
        {
            canvas.Children.Clear(); // clear canvas

            var houglassContainer = new Grid(); // main cont. for houglass

            houglassContainer.Width = width;
            houglassContainer.Height = height;

            var topTriangle = new Polygon();
            topTriangle.Points = new PointCollection()
            {
                new Point(0, 0),
                new Point(width, 0),
                new Point(width / 2, height / 2)
            };
            topTriangle.Fill = Brushes.Black;

            var bottomTriangle = new Polygon();
            bottomTriangle.Points = new PointCollection()
            {
                new Point(0, height),
                new Point(width, height),
                new Point(width / 2, height / 2)
            };
            bottomTriangle.Fill = Brushes.Black;

            houglassContainer.Children.Add(topTriangle);
            houglassContainer.Children.Add(bottomTriangle);

            // Set container on form
            Canvas.SetLeft(houglassContainer, centerX - width / 2);
            Canvas.SetTop(houglassContainer, centerY - height / 2);

            canvas.Children.Add(houglassContainer);
        }
    }
}
