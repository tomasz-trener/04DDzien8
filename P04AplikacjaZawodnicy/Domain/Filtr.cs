using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Domain
{
    public class Filtr
    {
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        
        public DateTime? DataUrOd;
        public DateTime? DataUrDo;

        public int? WzrostOd;
        public int? WzrostDo;

        public int? WagaOd;
        public int? WagaDo;
    }
}
