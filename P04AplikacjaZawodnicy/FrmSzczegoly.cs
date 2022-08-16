using P04AplikacjaZawodnicy.Controllers;
using P04AplikacjaZawodnicy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        ZawodnikVM edytowany;

        public FrmSzczegoly()
        {
            InitializeComponent();
        }
        public FrmSzczegoly(ZawodnikVM edytowany) : this()
        {
            this.edytowany = edytowany;

            txtImieZawodnika.Text = edytowany.Imie;
            txtNazwiskoZawodnika.Text = edytowany.Nazwisko;
            txtKrajZawodnika.Text = edytowany.Kraj;
            txtImieTrenera.Text = edytowany.Trener.Imie;
            txtNazwiskoTrenera.Text = edytowany.Trener.Nazwisko;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ZawodnikVM z = new ZawodnikVM();
            z.Id = edytowany.Id;
            z.Imie = txtImieZawodnika.Text;
            z.Nazwisko = txtNazwiskoZawodnika.Text;
            z.Kraj = txtKrajZawodnika.Text;
            z.Trener = new TrenerVM()
            {
                Id = edytowany.Trener.Id,
                Imie = txtImieTrenera.Text,
                Nazwisko = txtNazwiskoTrenera.Text
            };

            ZawodnicyController zc = new ZawodnicyController();

            if (edytowany==null)
            {
                zc.DodajZawodnikaITrenera(z);
            }
            else
            {
                zc.EdytujZawodnikaITrenera(z);
            }
           


        }
    }
}
