using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05LaczenieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            //Zawodnik[] zawodnicy = db.Zawodnik.ToArray();

            //foreach (var z in zawodnicy)
            //{
            //    Console.Write(z.imie + " " + z.nazwisko + " " );
            //    Trener t = db.Trener.FirstOrDefault(x => x.id_trenera == z.id_trenera);
            //    Console.Write(t?.imie_t + " " + t?.nazwisko_t + Environment.NewLine);
            //}


            Zawodnik[] zawodnicy = db.Zawodnik.ToArray();
            foreach (var z in zawodnicy)
            {
                Console.WriteLine(z.imie + " " + z.nazwisko + " " + z.Trener?.imie_t + " " + z.Trener?.nazwisko_t);
            }

            Console.ReadKey();
        }
    }
}
