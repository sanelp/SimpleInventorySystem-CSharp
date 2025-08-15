using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feilsøk
{
    public abstract class Vare
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int ID { get; set; }

        public abstract void SkrivUtInfo();
    }

}