using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Repositories
{
    class TrenerzyRepo
    {
        public int DodajTrenera(Trener z)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            db.Trener.InsertOnSubmit(z);
            db.SubmitChanges();
            return z.id_trenera;
        }

        public void EdytujTrenera(Trener t)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Trener doEdycji= db.Trener.FirstOrDefault(x => x.id_trenera == t.id_trenera);

            doEdycji.imie_t = t.imie_t;
            doEdycji.nazwisko_t = t.nazwisko_t;

            db.SubmitChanges();
        }
    }
}
