using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroSampleAnalyzer.Repositories;

namespace MicroSampleAnalyzer
{
    public partial class formUnosUzorka : Form
    {
        string OIBPrijavljenog = "";
        public formUnosUzorka(string oib)
        {
            OIBPrijavljenog = oib;
            InitializeComponent();
        }

        private void btnUnesiIGenerirajQR_Click(object sender, EventArgs e)
        {
            //Unos u bazu
            RepozitorijUzoraka.UnesiUzorak(OIBPrijavljenog, cmbPacijenti.Text.ToString(), tbOpis.Text.ToString());
            this.Close();

            //QR kod
            int idUzorka = RepozitorijUzoraka.DohvatiIdUnesenogUzorka();
            var formQRKod = new formQRKod(idUzorka);
            formQRKod.Show();
        }

        private void formUnosUzorka_Load(object sender, EventArgs e)
        {
            tbZaprimio.Text = RepozitorijDjelatnika.DohvatiDjelatnika(OIBPrijavljenog);
            cmbPacijenti.DataSource = RepozitorijPacijenata.DohvatiPacijenteOIB();
        }

        private void cmbPacijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPacijent.Text = RepozitorijPacijenata.DohvatiPacijenta(cmbPacijenti.Text);
        }
    }
}
