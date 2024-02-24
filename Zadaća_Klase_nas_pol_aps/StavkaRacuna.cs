using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_Klase_nas_pol_aps
{
    public class StavkaRacuna
    {
        protected private string naziv;
        protected private double cijena;

        public int RedniBroj { get; set; }

        public string Naziv
        {
            get { return naziv; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    naziv = value;
                else
                    throw new ArgumentException("Naziv stavke ne može biti prazan.");
            }
        }

        public double Cijena
        {
            get { return cijena; }
            set
            {
                if (value >= 0)
                    cijena = value;
                else
                    throw new ArgumentException("Cijena stavke mora biti nenegativan broj.");
            }
        }

        public int Kolicina { get; set; }

        public StavkaRacuna(int redniBroj, string naziv, double cijena, int kolicina)
        {
            RedniBroj = redniBroj;
            Naziv = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
        }

        public override string ToString()
        {
            return $"Stavka #{RedniBroj}: {Naziv} - {Cijena} EUR x {Kolicina} kom";
        }
    }
}
