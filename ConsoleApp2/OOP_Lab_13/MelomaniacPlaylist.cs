using System.Collections.Generic;

namespace OOP_Lab_13
{
    sealed class MelomaniacPlaylist : Music
    {
        internal List<Music> Playlist { get; set; }
        internal string PlaylistName { get; set; }

        public MelomaniacPlaylist() : base()
        { 
            PlaylistName = "DancingMusic";
            Playlist = new List<Music>();
        }
        public MelomaniacPlaylist(string playlistName)
        {
            PlaylistName = playlistName;
            Playlist = new List<Music>();
        }
    }
}
