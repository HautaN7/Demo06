using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an album
            Album album = new Album { Artist = "Artisti", Name = "Levy", Price = 19.99 };

            // Create songs
            Song song1 = new Song { Name = "Eka", Duration = "05:23" };
            Song song2 = new Song { Name = "Toka", Duration = "02:26" };
            Song song3 = new Song { Name = "Kolmas", Duration = "16:32" };
            Song song4 = new Song { Name = "Neljäs", Duration = "69:69" };
            Song song5 = new Song { Name = "Viides", Duration = "03:35" };
            Song song6 = new Song { Name = "Kuudes", Duration = "01:33" };

            // Add songs to Album
            album.AddSong(song1);
            album.AddSong(song2);
            album.AddSong(song3);
            album.AddSong(song4);
            album.AddSong(song5);
            album.AddSong(song6);

        }
    }
}
