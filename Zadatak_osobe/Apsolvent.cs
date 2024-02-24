using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_osobe
{
    // Klasa Apsolvent
    public sealed class Apsolvent : Osoba
    {
        // Konstruktor
        public Apsolvent(string ime, string prezime, string temaZavrsnogRada) : base(ime, prezime)
        {
            TemaZavrsnogRada = temaZavrsnogRada;
        }

        // Dodatno svojstvo klase Apsolvent
        public string TemaZavrsnogRada { get; }

        // Implementacija polimorfne metode PredstaviSe
        public override void PredstaviSe()
        {
            Console.WriteLine($"Ja sam apsolvent {Ime} {Prezime} i radim na temi završnog rada '{TemaZavrsnogRada}'.");
        }

        // Implementacija polimorfne metode PrijaviIspit
        public override void PrijaviIspit()
        {
            Console.WriteLine($"Apsolvent {Ime} {Prezime} prijavio je ispit.");
        }
    }

}
