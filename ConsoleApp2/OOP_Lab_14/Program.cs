using System;
using System.Collections.Generic;

namespace OOP_Lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emoji> emojis = new List<Emoji>();

            EmojiActions emoji = new EmojiActions();
            EmojiActions emoji1 = new EmojiActions(1.22, 2.33);
            EmojiActions emoji2 = new EmojiActions(2.33, 3.11);
            EmojiActions emoji3 = new EmojiActions(4.62, 3.1);
            EmojiActions emoji4 = new EmojiActions(5.55, 9.6);

            emoji.SetRadiusR(4.7);
            emoji.SetRadiusSmallR(2.22);
            emoji.SetSquare(emoji.GetRadiusR(), emoji.GetRadiusSmallR());

            Console.WriteLine("R:" + emoji.GetRadiusR() + " r: " + emoji.GetRadiusSmallR() + " S: " + emoji.GetSquare());

            emojis.Add(emoji);
            emojis.Add(emoji1);
            emojis.Add(emoji2);
            emojis.Add(emoji3);
            emojis.Add(emoji4);

            Console.WriteLine("\nUnsorted list:");
            foreach (var item in emojis)
            {
                Console.WriteLine(item);
            }

            emojis.Sort(new EmojiSort());

            Console.WriteLine("\nList sorted by square:");
            foreach (var item in emojis)
            {
                Console.WriteLine(item);
            }

            //emojis.Sort(x, y) => x._square.CompareTo(y._square); // not worked in C# 7.3
        }
    }
}
