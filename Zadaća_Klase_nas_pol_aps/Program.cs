using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_Klase_nas_pol_aps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racuni racun = new Racuni(1001, DateTime.Now);
            racun.DodajStavku(new StavkaRacuna(1, "Laptop", 499, 1));
            racun.DodajStavku(new StavkaRacuna(2, "Miš", 4.88, 2));

            racun.DodajStavku(new StavkaRacuna(3, "Tastatura", 7.50, 1));

            Console.WriteLine(racun);
            Console.ReadKey();
        }
    }
}
