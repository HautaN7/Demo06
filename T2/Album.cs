using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Album
    {
        public List<Song> album;

        public string Artist { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Album()
        {
            album = new List<Song>();
        }

        public void AddSong(Song song)
        {
            album.Add(song);
        }
        public void PrintCollection()
        {
            Console.WriteLine("Songs in album");
            foreach (Song song in album)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
