using System;

namespace OOP_Lab_14
{
    internal class EmojiActions : Emoji, IEmojiActions
    {
        public EmojiActions() : base()
        {
            _square = 0;
        }
        public EmojiActions(double radiusR, double radiusSmallR) : base(radiusR, radiusSmallR)
        {
            _square = (Math.PI * Math.Pow(radiusR, 2)) + (Math.PI * Math.Pow(radiusSmallR, 2));
        }
        public double GetRadiusR()
        {
            return _radiusR;
        }
        public double GetRadiusSmallR()
        {
            return _radiusSmallR;
        }
        public double GetSquare()
        {
            return _square;
        }
        public void SetRadiusR(double radius)
        {
            _radiusR = radius;
        }
        public void SetRadiusSmallR(double radius)
        {
            _radiusSmallR = radius;
        }
        public void SetSquare(double radiusR, double radiusSmallR)
        {
            _radiusR = radiusR;
            _radiusSmallR = radiusSmallR;
            _square = (Math.PI * Math.Pow(_radiusR, 2)) + (Math.PI * Math.Pow(_radiusSmallR, 2));
        }

        public override string ToString() // instead of print_sqrt
        {
            return "Square: " + _square;
        }
    }
}
