using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feilsøk
{
    public class Matvare : Vare 
    {

        public DateTime Utlopsdato { get; set; }

        public override void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare - Navn: {Navn}, Pris: {Pris}, ID: {ID}");
        }
    }
}
