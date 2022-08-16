using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaOkienkowa
{
    class ZawodnikVM
    {
        public string Imie;
        public string Nazwisko;
        public int Wzrost;
        public int Waga;
        public double BMI;

        public string ImieNazwiskoBMI
        {
            get {
                return Imie + " " + Nazwisko + " " +
                 string.Format("{0:0.00}", BMI);                 
                    }
        }
    }
}
