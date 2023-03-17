using System;

namespace OOP_Lab_13
{
    internal class MostDuplicatedCode : Music
    {
        private int compositionNumber { get; set; } = 1;

        public void playlistOutput(MelomaniacPlaylist playlist)
        {
            foreach (var music in playlist.Playlist)
            {
                Console.WriteLine("\n------------ Playlist: " + playlist.PlaylistName
                     + " - Comp.#{0}", compositionNumber + "-----------");
                compositionNumber++;
                Console.WriteLine(music.ToString());
            }
            compositionNumber = 1;
        }
        public void CompositionCreation(MelomaniacPlaylist playlist, int choise)
        {
            Music composition;

            if (choise == 1)
            {
                composition = new Rap();
            }
            else if (choise == 2)
            {
                composition = new Metal();
            }
            else
            {
                composition = new ClassicMusic();
            }

            Console.WriteLine("\nEnter composition name: ");
            composition.CompositionName = Console.ReadLine();
            Console.WriteLine("Enter author name: ");
            composition.CompositionAuthor = Console.ReadLine();
            Console.WriteLine("Enter playback time: ");
            composition.PlaybackTime = Convert.ToDouble(Console.ReadLine());

            playlist.Playlist.Add(composition);
        }
    }
}
