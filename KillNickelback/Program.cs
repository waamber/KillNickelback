using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new HashSet<Song>();

            allSongs.Add(new Song { Artist = "Nickleback", Name = "Photograph" });
            allSongs.Add(new Song { Artist = "NSYNC", Name = "Merry Christmas" });
            allSongs.Add(new Song { Artist = "Nickleback", Name = "How You Remind Me" });
            allSongs.Add(new Song { Artist = "Nickleback", Name = "Rockstar" });
            allSongs.Add(new Song { Artist = "Mariah Carey", Name = "All I Want For Christmas Is You" });
            allSongs.Add(new Song { Artist = "Frank Sinatra", Name= "Jingle Bells" });
            allSongs.Add(new Song { Artist = "The Temptations", Name = "Silent Night" });

            foreach (var song in allSongs)
            {
                if( song.Artist != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist}.");
            }

            Console.ReadLine();

        }
    }
}
