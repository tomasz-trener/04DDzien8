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
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyController zc = new ZawodnicyController();
            lbDane.DataSource = zc.PodajZawodnikowZTrenerami();
            lbDane.DisplayMember = "ImieNazwiskoKrajTrenerzy";


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly();
            fs.Show();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            ZawodnikVM zaznaczony = (ZawodnikVM)lbDane.SelectedItem;
            FrmSzczegoly fs = new FrmSzczegoly(zaznaczony);
            fs.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            ZawodnikVM zaznaczony = (ZawodnikVM)lbDane.SelectedItem;

            ZawodnicyController zc = new ZawodnicyController();
            zc.UsunZawodnika(zaznaczony);
        }
    }
}
