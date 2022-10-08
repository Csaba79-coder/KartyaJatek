using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyaJatek
{
    internal class Kartya
    {
        public int MAX_KARTYA = 52;

        List<string> szinek = new List<string> { "treff", "karo", "pikk", "kor" };
        List<string> ertekek = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbo", "Dama", "Kiraly", "Asz" };

        List<string> lapok = new List<string>();

       public Kartya()
        {
            foreach (string szin in szinek)
            {
                foreach (string ertek in ertekek)
                {
                    lapok.Add(szin + " " + ertek);
                }
            }
        }

        public List<string> Osztas(int lapokSzama)
        {
            Random random = new Random();

            List<string> osztottLapok = new List<string>();
            for (int i = 0; i < lapokSzama; i++)
            {
                int randomNumber = random.Next(0, lapok.Count());
                osztottLapok.Add(lapok.ElementAt(randomNumber));
                lapok.RemoveAt(randomNumber);
            }
            return osztottLapok;
        }
    }
}
