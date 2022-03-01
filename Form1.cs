using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fPripremaZaIspit
{

    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void BTNunesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(CMBvrsta.Text, TXTnaziv.Text, TXTmarka.Text, DTPdatum.Value, TRBsnaga.Value);
            listaVozila.Add(vozilo);
            MessageBox.Show("Unos je uspješan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TRBsnaga_Scroll(object sender, EventArgs e)
        {
            LBLsnagabroj.Text = Convert.ToString(TRBsnaga.Value);
        }

        private void BTNispis_Click(object sender, EventArgs e)
        {
            RTBispis.Clear();
            foreach(Vozilo vozilo in listaVozila)
            {
                RTBispis.AppendText(vozilo.ToString());
            }
        }
    }
}
