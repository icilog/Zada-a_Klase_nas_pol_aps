using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_osobe
{
    // Klasa Profesor
    public sealed class Profesor : Osoba
    {
        // Konstruktor
        public Profesor(string ime, string prezime, string predmet) : base(ime, prezime)
        {
            Predmet = predmet;
        }

        // Dodatno svojstvo klase Profesor
        public string Predmet { get; }

        // Implementacija polimorfne metode PredstaviSe
        public override void PredstaviSe()
        {
            Console.WriteLine($"Ja sam profesor {Ime} {Prezime} i predajem predmet {Predmet}.");
        }

        // Implementacija polimorfne metode PrijaviIspit
        public override void PrijaviIspit()
        {
            Console.WriteLine($"Profesor {Ime} {Prezime} nije u mogućnosti prijaviti ispit.");
        }
    }
}
