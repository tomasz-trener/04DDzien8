using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03OperacjeCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            // dodawanie rekordu
            //Zawodnik nowy = new Zawodnik();
            //nowy.imie = "Jan^";
            //nowy.nazwisko = "Kowalski";
            //nowy.kraj = "Pol";

            //db.Zawodnik.InsertOnSubmit(nowy);
            //db.SubmitChanges();

            // edycja rekordu 
            // najpierw musimy z bazy danych pobrac zawodnika, ktrego cchemy edytować
            // zmieniamy jego pola
            // ostatecznie zapisujemy rekord w bazue (submit)

            //Zawodnik doEdycji = db.Zawodnik.Where(x => x.imie == "Jan^").ToArray()[0];

            //doEdycji.kraj = "GER";
            //db.SubmitChanges();

            //Zawodnik oId5 = db.Zawodnik.Where(x => x.id_zawodnika == 5).ToArray()[0];
            // Zawodnik oId5 = db.Zawodnik.Where(x => x.id_zawodnika == 5).FirstOrDefault(); // gdy nie ma w bazie zwraca null

            // Zawodnik oId5 = db.Zawodnik.Where(x => x.id_zawodnika == 5).First(); // gdy nie ma to błąd

            Zawodnik oId5 = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == 5);

            // usuwanie rekordu

            // najpierw trzeba pobrać tego który chcemy usunac
            // dopiero potem usuwamy z bazy

            Zawodnik doUsuniecia = db.Zawodnik.OrderBy(x=>x.id_zawodnika).FirstOrDefault(x => x.imie == "Jan^");
            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();




        }
    }
}
