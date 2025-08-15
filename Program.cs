using Feilsøk;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
 

class Program
{
    static void Main(string[] args)
    {
        List<Vare> lagerbeholdning = new List<Vare>();
        lagerbeholdning.Add(new Matvare { Navn = "Melk", Pris = 20.0, ID = 1, Utlopsdato = new DateTime(2025, 8, 22) });
        lagerbeholdning.Add(new Elektronikk { Navn = "TV", Pris = 5000.0, ID = 2, Garanti = 24 });

        while (true)
        {
            Console.WriteLine("Velg en handling:");
            Console.WriteLine("1. Vis alle varer");
            Console.WriteLine("2. Legg til ny vare");
            Console.WriteLine("3. Søk etter vare");
            Console.WriteLine("4. Avslutt");

            string valg = Console.ReadLine();

            if (valg == "1")
            {
                VisAlleVare(lagerbeholdning);
            } else if (valg == "2")
            {
                leggTilNyVare(lagerbeholdning);
            }
            else if (valg == "3")
            {
                SøkEtterVare(lagerbeholdning);
            }
            else if (valg == "4")
            {
                Console.WriteLine("Avslutter programmet...");
                break;
            }
            else
            {
                Console.WriteLine("Ugyldig valg, prøv igjen.");
               
            }


        }
    }
    public static void VisAlleVare(List<Vare> lagerbeholdning)
    {
        Console.WriteLine("Lagerbeholdning:");
        foreach (var vare in lagerbeholdning)
        {
            vare.SkrivUtInfo();
        }
    }
    public static void leggTilNyVare(List<Vare> vare)
    {         Console.WriteLine("Velg type vare (1 for Matvare, 2 for Elektronikk):");
        string type = Console.ReadLine();
        Vare nyVare = null;
        if (type == "1")
        {
            nyVare = new Matvare();
            Console.WriteLine("Skriv inn navn på matvaren:");
            nyVare.Navn = Console.ReadLine();
            Console.WriteLine("Skriv inn pris på matvaren:");
            nyVare.Pris = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv inn ID for matvaren:");
            nyVare.ID = Convert.ToInt32(Console.ReadLine());
            ((Matvare)nyVare).Utlopsdato = DateTime.Now.AddMonths(6); // Eksempel på utløpsdato
        }
        else if (type == "2")
        {
            nyVare = new Elektronikk();
            Console.WriteLine("Skriv inn navn på elektronikken:");
            nyVare.Navn = Console.ReadLine();
            Console.WriteLine("Skriv inn pris på elektronikken:");
            nyVare.Pris = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv inn ID for elektronikken:");
            nyVare.ID = Convert.ToInt32(Console.ReadLine());
            ((Elektronikk)nyVare).Garanti = 24; // Eksempel på garanti
        }
        else
        {
            Console.WriteLine("Ugyldig type vare.");
            return;
        }
        vare.Add(nyVare);
        Console.WriteLine("Ny vare lagt til.");
    }

    public static void SøkEtterVare(List<Vare> lagerbeholdning)
    {
        Console.WriteLine("Skriv inn navn på varen du vil søke etter:");
        string søkNavn = Console.ReadLine();
        var resultater = lagerbeholdning.Where(v => v.Navn.Contains(søkNavn, StringComparison.OrdinalIgnoreCase)).ToList();
        if (resultater.Count > 0)
        {
            Console.WriteLine("Søkeresultater:");
            foreach (var vare in resultater)
            {
                vare.SkrivUtInfo();
            }
        }
        else
        {
            Console.WriteLine("Ingen varer funnet med det navnet.");
        }
    }  

}