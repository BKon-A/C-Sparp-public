namespace OOP_Lab_13
{
    class Rap : Music
    {
        internal override string Genre { get; }
        public Rap() : base()
        {
            Genre = "Rap";
        }
        public Rap(string compositionName, string compositionAuthor, double playbackTime) 
            : base(compositionName, compositionAuthor, playbackTime)
        {
            Genre = "Rap";
        }
        
    }
    class Metal : Music
    {
        internal override string Genre { get; }
        public Metal() : base()
        {
            Genre = "Metal";
        }
        public Metal(string compositionName, string compositionAuthor, double playbackTime) 
            : base(compositionName, compositionAuthor, playbackTime)
        {
            Genre = "Metal";
        }
        
    }
    class ClassicMusic : Music
    {
        internal override string Genre { get; }
        public ClassicMusic() : base()
        {
            Genre = "ClassicMusic";
        }
        public ClassicMusic(string compositionName, string compositionAuthor, double playbackTime)
            : base(compositionName, compositionAuthor, playbackTime)
        {
            Genre = "ClassicMusic";
        }
    }
}
