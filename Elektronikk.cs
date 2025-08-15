using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feilsøk
{
    public class Elektronikk : Vare
    {
        public int Garanti { get; set; } // Antall måneder garanti

        public override void SkrivUtInfo()
        {
            Console.WriteLine($"Elektronikk - Navn: {Navn}, Pris: {Pris}, ID: {ID}, Garanti: {Garanti} måneder");
        }
    }
}
