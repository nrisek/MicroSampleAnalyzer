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
    public partial class formUnosPacijenta : Form
    {
        public formUnosPacijenta()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            RepozitorijPacijenata.UnesiPacijenta(tbOib.Text, tbImePrezime.Text, 
                tbAdresa.Text, tbBrojTelefona.Text, tbGodinaRodenja.Text, tbPovijest.Text, tbAnalize.Text);
            this.Close();
        }

        private void formUnosPacijenta_Load(object sender, EventArgs e)
        {
            tbAnalize.Text = " ";
            tbPovijest.Text = " ";
        }
    }
}
