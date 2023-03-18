using System;
using System.Xml.Serialization;

namespace OOP_Lab_13
{
    [XmlInclude(typeof(Rap)), XmlInclude(typeof(Metal)), XmlInclude(typeof(Music))]
    public abstract class Music
    {
        internal string CompositionName { get; set; }
        internal string CompositionAuthor { get; set; }
        internal double PlaybackTime { get; set; }
        internal virtual string Genre { get; } 

        public Music()
        {
            CompositionName = "Defoult";
            CompositionAuthor = "Def";
            PlaybackTime = 2.35;
            Genre = "Rap";
        }
        public Music(string compositionName, string compositionAuthor, double playbackTime)
        {
            CompositionName = compositionName;
            CompositionAuthor = compositionAuthor;
            PlaybackTime = playbackTime;
        }
        public override string ToString()
        {
            return "\nComposition name: " + CompositionName + "\nComposition author: " + CompositionAuthor
                + "\nComposition playback time: " + PlaybackTime + "\nGenre: " + Genre;
        }
        public virtual bool Equals(Music firstObject, Music secondObject)
        {
            if (firstObject.CompositionName == secondObject.CompositionName && firstObject.CompositionAuthor
                == secondObject.CompositionAuthor && firstObject.PlaybackTime == secondObject.PlaybackTime 
                && firstObject.Genre == secondObject.Genre)
            {
                Console.WriteLine("YES");
                return true;
            }
            else
            {
                Console.WriteLine("NO");
                return false;
            }
            
        }
    }
}
