using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_14
{
    internal class EmojiSort : Emoji, IComparer<Emoji>
    {
        public int Compare(Emoji emoji1, Emoji emoji2)
        {
            if (object.ReferenceEquals(emoji1, emoji2))
            {
                return 0;
            }
            if (emoji1 == null)
            {
                return -1;
            }
            if (emoji2 == null)
            {
                return 1;
            }

            return emoji1._square.CompareTo(emoji2._square);
        }
    }
}
