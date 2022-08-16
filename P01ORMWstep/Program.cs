using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ORMWstep
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * LINQ to SQL - wbudowane w .net  (tylko do ms sql)
             * Entity Framework - wbudowane w .net (inne bazy danych np postgres)
             * NHibernate - mamy możliwośc łaczenia innymi bazami danych
            
             generalnie zapytania tworzone przez ORM są wolniejsze niż zapytania natywne w SQL
             */ 



            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            Zawodnik[] zawodnicy = db.Zawodnik.ToArray();

            //foreach (var item in zawodnicy)
            //    Console.WriteLine(item.imie + " " + item.nazwisko);
            

         

            Zawodnik[] wynik1=
                db.Zawodnik.OrderBy(x => x.kraj).ToArray();

 
            Zawodnik[] wynik2 =
                db.Zawodnik
                .OrderBy(x => x.kraj)
                .ThenBy(x=>x.imie)
                .ToArray();

            Zawodnik[] wynik3 =
                db.Zawodnik
                .OrderBy(x => x.imie + " " + x.nazwisko + " " + x.kraj)
                .ToArray();


            string[] wynik4 =
                db.Zawodnik.Select(x => x.imie).ToArray();

            string[] wynik5 =
               db.Zawodnik
               .OrderBy(x=>x.imie + " " + " " + x.nazwisko + " " + x.kraj)
               .Select(x => x.imie + " " + x.nazwisko + " " + x.kraj).ToArray();

            string[] wynik6 =
               db.Zawodnik
               .Select(x => x.imie + " " + x.nazwisko + " " + x.kraj)
               .OrderBy(x => x).ToArray();

            Zawodnik[] wynik7 =
              db.Zawodnik
              .OrderBy(x => x.data_ur).ToArray();

            string[] wynik8 =
                db.Zawodnik.ToArray()
                 .OrderBy(x=> (double)x.waga / Math.Pow((double)x.wzrost / 100, 2)) 
                .Select(x => x.imie + " " + x.nazwisko + "  " +
                     string.Format("{0:0.00}",
                      Math.Round( (double)x.waga / Math.Pow((double)x.wzrost / 100, 2),2, MidpointRounding.AwayFromZero )
                        )
                      )
                    .ToArray();

            //foreach (var item in wynik8)
            //    Console.WriteLine(item);


            string[] wynik9 =
            db.Zawodnik
                .OrderBy(x => x.nazwisko)
                .Select(x => x.imie + " " + x.nazwisko + " (" + x.kraj + ")")
                .ToArray();

            //string[] wynik10 =
            //    db.Zawodnik
            // .Select(x => x.imie + " " + x.nazwisko + " (" + x.kraj + ")")
            // .OrderBy(x=>x)
            // .ToArray();


            ZawodnikMini[] wynik11=
            db.Zawodnik
                .Select(x => new ZawodnikMini()
                {
                    Imie = x.imie,
                    Nazwisko = x.nazwisko,
                    Kraj = x.kraj
                }).ToArray();

            var wynik12=
                db.Zawodnik
                    .Select(x => new
                    {
                        MojeImie = x.imie,
                        MojeNazwisko = x.nazwisko,
                        x.kraj
                    }).ToArray();

            var wynik13= 
                db.Zawodnik
                    .GroupBy(x => x.kraj)
                    .Select(x => new { Kraj = x.Key, Srednia = x.Average(y => y.wzrost) })
                    .ToArray();

            var wynik14 =
            db.Zawodnik
                .Where(x=>x.wzrost>180)
                .GroupBy(x=>x.kraj)
                .Select(x => new { Kraj = x.Key, Ile = x.Count() })
                .ToArray();





            //foreach (var item in wynik14)
            //    Console.WriteLine(item.Kraj + " " + item.Ile);


            string[] tablica = { "ala", "ma", "kota" };

            string[] wynik15=
                tablica
                .Where(x => x.Length > 2)
                .Select(x=>x.ToUpper())
                .ToArray();


            foreach (var item in wynik15)
                Console.WriteLine(item);



            Console.ReadKey();

        }
    }
}
