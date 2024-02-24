using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_osobe
{
    public abstract class Osoba
    {
        protected Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        // Svojstva
        public string Ime { get; }
        public string Prezime { get; }

        // Polimorfna metoda PredstaviSe
        public abstract void PredstaviSe();

        // Polimorfna metoda PrijaviIspit
        public abstract void PrijaviIspit();

        // Premosti metodu ToString
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
