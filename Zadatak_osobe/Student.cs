using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_osobe
{
    // Klasa Student nasljeduje klasu Osoba
    public class Student : Osoba
    {
        // Konstruktor
        public Student(string ime, string prezime, int brojIndeksa) : base(ime, prezime)
        {
            BrojIndeksa = brojIndeksa;
        }

        // Dodatno svojstvo klase Student
        public int BrojIndeksa { get; }

        // Implementacija polimorfne metode PredstaviSe
        public override void PredstaviSe()
        {
            Console.WriteLine($"Ja sam student {Ime} {Prezime} sa brojem indeksa {BrojIndeksa}.");
        }

        // Implementacija polimorfne metode PrijaviIspit
        public override void PrijaviIspit()
        {
            Console.WriteLine($"Student {Ime} {Prezime} prijavio je ispit.");
        }
    }
}
