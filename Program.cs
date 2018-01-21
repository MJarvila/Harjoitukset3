using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Artist, AlbumName, Year, TotalLenght, Genre, Price, TrackList

namespace Har3Teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            CD joku = new CD("Jokuset", "Jaskattelua", 1990, 68, "Nu Metal", 200.2, "\n--- 1. Jaska Jokunen 12:19 \n--- 2. Comeback 5:23 \n--- 3. Vaikkei missään oltukaan 6:66 \n--- 4. Kökkö loppubiisi 5:43 \n--- 5. Loppusuhinaa kun ei muutakaan keksitty bändin kanssa (feat. Masan Pieru) 37:29");
            joku.LookAtCd();
        }
    }
}
