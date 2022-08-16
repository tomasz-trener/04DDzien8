using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();

            ZawodnikVM[] zawodnicy = db
                .Zawodnik
                .Select(x=>new ZawodnikVM()
                {
                    Imie = x.imie,
                    Nazwisko = x.nazwisko,
                    Wzrost =(int) x.wzrost,
                    Waga = (int)x.waga,
                    BMI = (double)x.waga/Math.Pow((double)x.wzrost/100,2)
                })
                .ToArray();



            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoBMI";
        }
    }
}
