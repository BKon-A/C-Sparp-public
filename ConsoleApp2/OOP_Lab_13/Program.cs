using System;
using System.IO;

namespace OOP_Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int caseChoise, genre, compositionNumber = 1;
            bool cycleCondition = true;
            MelomaniacPlaylist playlist = new MelomaniacPlaylist("Full");
            MostDuplicatedCode duplicates = new MostDuplicatedCode();
            string path = "XMLFile1.xml";
            while (cycleCondition)
            {
                
                Console.WriteLine("\nWhat you want to do:\n1. Add musicaly composition to playlist" +
                "\n2. Delete selected composition\n3. Show compositions in playlist\n4. Compare compositions" +
                "\n5. Calculate total playback time\n6. Write to file\n7. Read from file\n8. Comlete program");
                caseChoise = Convert.ToInt32(Console.ReadLine());

                switch (caseChoise)
                {
                    case 1: // додати пісню до попереднього плейлисту

                        Console.WriteLine("\nChoose genre of music:\n1. Rap\n2. Metal\n3. Classic\n4. Back");
                        genre = Convert.ToInt32(Console.ReadLine());

                        switch (genre)
                        {
                            case 1:
                                duplicates.CompositionCreation(playlist, genre);
                                break;

                            case 2:
                                duplicates.CompositionCreation(playlist, genre);
                                break;

                            case 3:
                                duplicates.CompositionCreation(playlist, genre);
                                break;

                            case 4:
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2: // видалити післю з попереднього плейлисту

                        duplicates.playlistOutput(playlist);
                        Console.WriteLine("\nSelect the number of the composition you wish to delete");
                        compositionNumber = Convert.ToInt32(Console.ReadLine());
                        playlist.Playlist.RemoveAt(compositionNumber - 1);
                        break;

                    case 3: // показати композиції у плейлисті

                        duplicates.playlistOutput(playlist);
                        break;

                    case 4:
                        int tempCompositionNumber;

                        duplicates.playlistOutput(playlist);

                        Console.WriteLine("\nWhich compositions should be compared?\n");
                        Console.Write("First composition: ");
                        compositionNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nSecond composition: ");
                        tempCompositionNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        playlist.Equals(playlist.Playlist[compositionNumber - 1],
                            playlist.Playlist[tempCompositionNumber - 1]);
                        break;

                    case 5:
                        double totalDuration = 0;

                        foreach (var duration in playlist.Playlist)
                        {
                            totalDuration += duration.PlaybackTime;
                        }

                        Console.WriteLine("\nTotal duration {0} seconds", totalDuration);
                        break;

                    case 6:

                        duplicates.SerializeList(playlist.Playlist, path);
                        break;

                    case 7:

                        duplicates.DeserializeList(path);
                        break;

                    case 8:
                        Console.WriteLine("\nProgram completed...\n");
                        cycleCondition = false;
                        break;
                    
                    default:
                        Console.WriteLine("\nProgram completed...\n");
                        cycleCondition = false;
                        break;
                }
            }
        }
    }
}
