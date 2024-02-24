using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_osobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primjer korištenja
            Osoba student = new Student("Marko", "Marković", 12345);
            Osoba apsolvent = new Apsolvent("Ana", "Anić", "Implementacija algoritma");
            Osoba profesor = new Profesor("Ivan", "Ivanić", "Matematika");

            student.PredstaviSe();
            student.PrijaviIspit();

            apsolvent.PredstaviSe();
            apsolvent.PrijaviIspit();

            profesor.PredstaviSe();
            profesor.PrijaviIspit();

            Console.ReadKey();
        }
    }
}
