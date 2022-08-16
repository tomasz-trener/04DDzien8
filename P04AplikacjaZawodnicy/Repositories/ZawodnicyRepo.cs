using P04AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Repositories
{
    public class ZawodnicyRepo
    {
       

        //CRUD 
        // Create , Read, Update, Delete 

       public ZawodnikVM[] PobierzZawodnikowZTrenerami()
       {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            ZawodnikVM[] zawodnicy =
            db.Zawodnik.Select(x => new ZawodnikVM() 
            { 
                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj,
                Trener = new TrenerVM() { Id=x.Trener.id_trenera, Imie = x.Trener.imie_t, Nazwisko = x.Trener.nazwisko_t}

            }
            ).ToArray();

            return zawodnicy;


       }

       public Zawodnik[] PobierzZawodnikow()
       {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.ToArray();
       }

        public Zawodnik[] PobierzZawodnikow(Filtr filtr)
        {

            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            var zawodnicy = db.Zawodnik.ToArray();
            if (!string.IsNullOrWhiteSpace(filtr.Imie))
            {
                zawodnicy = zawodnicy.Where(x => x.imie.Contains(filtr.Imie)).ToArray();
            }
            if (!string.IsNullOrWhiteSpace(filtr.Nazwisko))
            {
                zawodnicy = zawodnicy.Where(x => x.nazwisko.Contains(filtr.Nazwisko)).ToArray();
            }
            if (!string.IsNullOrWhiteSpace(filtr.Kraj))
            {
                zawodnicy = zawodnicy.Where(x => x.kraj.Contains(filtr.Kraj)).ToArray();
            }
            if (filtr.WzrostOd != null)
            {
                zawodnicy = zawodnicy.Where(x => x.wzrost > filtr.WzrostOd).ToArray();
            }
            if (filtr.WzrostDo != null)
            {
                zawodnicy = zawodnicy.Where(x => x.wzrost > filtr.WzrostDo).ToArray();
            }
            if (filtr.WagaOd != null)
            {
                zawodnicy = zawodnicy.Where(x => x.waga > filtr.WagaOd).ToArray();
            }
            if (filtr.WagaDo != null)
            {
                zawodnicy = zawodnicy.Where(x => x.waga > filtr.WagaDo).ToArray();
            }
            if (filtr.DataUrOd != null)
            {
                zawodnicy = zawodnicy.Where(x => x.data_ur > filtr.DataUrOd).ToArray();
            }
            if (filtr.DataUrDo != null)
            {
                zawodnicy = zawodnicy.Where(x => x.data_ur > filtr.DataUrDo).ToArray();
            }
            return zawodnicy;
        }


        public void DodajZawodnika(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            db.Zawodnik.InsertOnSubmit(z);
            db.SubmitChanges();
        }

        public void UsunZawodnika(int id)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doUsuniecia = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == id);
            db.Zawodnik.DeleteOnSubmit(doUsuniecia);
            db.SubmitChanges();
        }

        public void EdytujZawodnika(Zawodnik z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik doEdycji = db.Zawodnik.FirstOrDefault(x => x.id_zawodnika == z.id_zawodnika);

            doEdycji.imie = z.imie;
            doEdycji.nazwisko = z.nazwisko;
            doEdycji.kraj = z.kraj;
            doEdycji.wzrost = z.wzrost;
            doEdycji.waga = z.waga;
            doEdycji.data_ur = z.data_ur;

            db.SubmitChanges();
        }

        public string[] PodajKraje()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            return db.Zawodnik.Select(x => x.kraj).Distinct().ToArray();
        }
    }
}
