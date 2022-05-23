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
    public partial class formPregledPacijenata : Form
    {
        public formPregledPacijenata()
        {
            InitializeComponent();
        }

        private void formPregledPacijenata_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgvPacijenti.DataSource = RepozitorijPacijenata.DohvatiPacijente();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPacijenti.DataSource = RepozitorijPacijenata.DohvatiPacijente();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPacijenti.DataSource = RepozitorijPacijenata.PretraziPacijente(tbImeIPrezime.Text);
        }
    }
}
