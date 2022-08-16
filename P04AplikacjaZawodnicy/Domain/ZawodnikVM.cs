using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaZawodnicy.Domain
{
    public class ZawodnikVM
    {
        public int Id;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public int? Wzrost;
        public TrenerVM Trener;

        public string ImieNazwiskoKrajTrenerzy
        {
            get
            {
                return Imie + " " + Nazwisko + " " + Kraj + " - " +
                    Trener?.Imie + " " + Trener?.Nazwisko;
            }
        }
        public string ImieNazwiskoKraj {  get 
            { 
                return Imie + " " + Nazwisko + " " + Kraj + " " + (Wzrost == null ? "-" : Wzrost.ToString()) ; 
            } 
        }

        public int Wzrost2
        {
            get { return Wzrost ?? 0; }
        }
    }
}
