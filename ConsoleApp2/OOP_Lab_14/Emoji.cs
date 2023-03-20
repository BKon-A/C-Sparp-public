namespace OOP_Lab_14
{
    abstract class Emoji : IEmoji
    {
        public double _radiusR { get; set; }
        public double _radiusSmallR { get; set; }
        public double _square { get; set; }

        public Emoji()
        {
            _radiusR = 0;
            _radiusSmallR = 0;
        }
        public Emoji(double radiusR, double radiusSmallR)
        {
            _radiusR = radiusR;
            _radiusSmallR = radiusSmallR;
        }
    }
}
