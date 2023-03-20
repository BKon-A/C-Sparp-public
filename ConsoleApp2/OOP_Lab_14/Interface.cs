using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_14
{
    public interface IEmoji
    {
        double _radiusR { get; }
        double _radiusSmallR { get; }
        double _square { get; }
    }
    public interface IEmojiActions
    {
        double GetRadiusR();
        double GetRadiusSmallR();
        double GetSquare();
        void SetRadiusR(double radius);
        void SetRadiusSmallR(double radius);
        void SetSquare(double radiusR, double radiusSmallR);
    }
}
