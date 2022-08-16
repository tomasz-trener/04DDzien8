using P04AplikacjaZawodnicy.Domain;
using P04AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Controllers
{
    class ZawodnicyController
    {
        ZawodnicyRepo zr = new ZawodnicyRepo();
        TrenerzyRepo tr = new TrenerzyRepo();

        public ZawodnikVM[] PodajZawodnikow()
        {
            return
                zr.PobierzZawodnikow().Select(x => new ZawodnikVM()
                {
                    Imie = x.imie,
                    Nazwisko = x.nazwisko,
                    Kraj = x.kraj,
                    Wzrost = x.wzrost
                }).ToArray();
        }

        public ZawodnikVM[] PodajZawodnikowZTrenerami()
        {
            return zr.PobierzZawodnikowZTrenerami();
        }


        public void DodajZawodnikaITrenera(ZawodnikVM z)
        {
            Trener tdb = new Trener()
            {
                imie_t = z.Trener.Imie,
                nazwisko_t = z.Trener.Nazwisko
            };

            int idTrenera= tr.DodajTrenera(tdb);


            Zawodnik zdb = new Zawodnik()
            {
                imie = z.Imie,
                nazwisko = z.Nazwisko,
                kraj = z.Kraj,
                id_trenera = idTrenera
            };

            zr.DodajZawodnika(zdb);


        }

        public void EdytujZawodnikaITrenera(ZawodnikVM z)
        {
            Zawodnik zdb = new Zawodnik();
            zdb.id_zawodnika = z.Id;
            zdb.imie = z.Imie;
            zdb.nazwisko = z.Nazwisko;
            zdb.kraj = z.Kraj;
            zr.EdytujZawodnika(zdb);

            Trener tdb = new Trener();
            tdb.id_trenera = z.Trener.Id;
            tdb.imie_t = z.Trener.Imie;
            tdb.nazwisko_t = z.Trener.Nazwisko;
            tr.EdytujTrenera(tdb);


             

        }

        public void UsunZawodnika(ZawodnikVM z)
        {
            zr.UsunZawodnika(z.Id);
        }
    }
}
