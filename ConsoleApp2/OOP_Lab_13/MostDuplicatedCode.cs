using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP_Lab_13
{
    public class MostDuplicatedCode : Music
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

        public void SerializeList(List<Music> playlist, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Music>));

            using (var writer = new StreamWriter(path, true))
            {
                serializer.Serialize(writer, playlist);
            }
        }
        public List<Music> DeserializeList(string path)
        {

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Music>));

            var reader = new StreamReader(path);

            var trytemp = deserializer.Deserialize(reader);

            return (List<Music>)trytemp;
        }
    }
}
