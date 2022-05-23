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
    public partial class formPregledUzorka : Form
    {
        int idUzorka = 0;
        public formPregledUzorka(int id)
        {
            idUzorka=id;
            InitializeComponent();
        }

        private void formPregledUzorka_Load(object sender, EventArgs e)
        {
            string oibZaprimio = RepozitorijUzoraka.DohvatiUzorak(idUzorka).ZaprimioOIB;
            string oibPacijent = RepozitorijUzoraka.DohvatiUzorak(idUzorka).PacijentOIB;

            cmbZaprimio.DataSource = RepozitorijDjelatnika.DohvatiDjelatnike();

            tbDatum.Text = RepozitorijUzoraka.DohvatiUzorak(idUzorka).DatumZaprimanja;
            cmbZaprimio.Text = RepozitorijDjelatnika.DohvatiDjelatnika(oibZaprimio);
            tbPacijent.Text = RepozitorijPacijenata.DohvatiPacijenta(oibPacijent);
            tbOpis.Text = RepozitorijUzoraka.DohvatiUzorak(idUzorka).Opis;
            tbOibPacijent.Text = oibPacijent;
            tbOibZaprimio.Text = oibZaprimio;
        }

        private void cmbZaprimio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imePrezime = cmbZaprimio.Text;
            string[] rijeci = imePrezime.Split(' ');
            tbOibZaprimio.Text = RepozitorijDjelatnika.DohvatiDjelatnikaOIB(rijeci[0], rijeci[1]);
        }

        private void tbOibPacijent_TextChanged(object sender, EventArgs e)
        {
            tbPacijent.Text = RepozitorijPacijenata.DohvatiPacijenta(tbOibPacijent.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RepozitorijUzoraka.SpremiPromjene(tbDatum.Text, tbOibZaprimio.Text, tbOibPacijent.Text, tbOpis.Text, idUzorka);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani uzorak?", "UPOZORENJE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RepozitorijUzoraka.DeleteUzorak(idUzorka);
                this.Close();
            }
            else if (dialogResult == DialogResult.No){}
        }
    }
}
