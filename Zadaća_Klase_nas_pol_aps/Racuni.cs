using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_Klase_nas_pol_aps
{
    public class Racuni
    {
        public int BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public List<StavkaRacuna> Stavke { get; set; }

        public Racuni(int brojRacuna, DateTime datum)
        {
            BrojRacuna = brojRacuna;
            Datum = datum;
            Stavke = new List<StavkaRacuna>();
        }

        public void DodajStavku(StavkaRacuna stavka)
        {
            Stavke.Add(stavka);
        }

        public double IzracunajUkupanIznos()
        {
            double ukupno = 0;
            foreach (var stavka in Stavke)
            {
                ukupno += stavka.Cijena * stavka.Kolicina;
            }
            return ukupno;
        }

        public override string ToString()
        {
            string ispis = $"Račun br. {BrojRacuna}, Datum: {Datum}\n";
            foreach (var stavka in Stavke)
            {
                ispis += stavka.ToString() + "\n";
            }
            ispis += $"Ukupan iznos: {IzracunajUkupanIznos()} EUR";
            return ispis;
        }
    }
}
