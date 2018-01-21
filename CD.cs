using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Har3Teht7
{
    class CD
    {
        public string Artist { get; set; }

        public string AlbumName { get; set; }

        public int Year { get; set; }

        public float TotalLenght { get; set; }

        public string Genre { get; set; }

        public double Price { get; set; }

        public string Tracklist { get; set; }

        public CD(string artist, string albumName, int year, float totalLenght, string genre, double price, string tracklist)
        {
            Artist = artist;
            AlbumName = albumName;
            Year = year;
            TotalLenght = totalLenght;
            Genre = genre;
            Price = price;
            Tracklist = tracklist;
        }
        public void LookAtCd()
        {
            Console.WriteLine("Artist - " + Artist);
            Console.WriteLine("Album - " + AlbumName);
            Console.WriteLine("Year - " + Year);
            Console.WriteLine("Lenght - " + TotalLenght + " min");
            Console.WriteLine("Genre - " + Genre);
            Console.WriteLine("Price - " + Price + " $");
            Console.WriteLine("Songs: " + Tracklist);
        }
    }
}