using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace MicroSampleAnalyzer
{
    public partial class formPocetna : Form
    {
        public formPocetna()
        {
            InitializeComponent();
        }

        private void btnUzorci_Click(object sender, EventArgs e)
        {
            var formPregledUzoraka = new formPregledUzoraka();
            formPregledUzoraka.Show();
        }

        private void btnNoviUzorak_Click(object sender, EventArgs e)
        {
            string oibPrijavljenog = "35526617281"; //ovo bi se spremalo kod login-a
            var formUnosUzorka = new formUnosUzorka(oibPrijavljenog);
            formUnosUzorka.Show();
        }

        private void formPocetna_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("nrisek20_DB", "nrisek20", "Xw#8csU)");
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPregledPacijenata_Click(object sender, EventArgs e)
        {
            var formPregledPacijenata = new formPregledPacijenata();
            formPregledPacijenata.Show();
        }

        private void btnUnosPacijenta_Click(object sender, EventArgs e)
        {
            var formUnosPacijenta = new formUnosPacijenta();
            formUnosPacijenta.Show();
        }
    }
}
