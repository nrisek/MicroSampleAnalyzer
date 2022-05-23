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
    public partial class formPregledUzoraka : Form
    {
        public formPregledUzoraka()
        {
            InitializeComponent();
        }

        private void formPregledUzoraka_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgvUzorci.DataSource = RepozitorijUzoraka.DohvatiUzorke();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUzorci.DataSource = RepozitorijUzoraka.PretraziUzorke(tbImeIPrezime.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvUzorci.DataSource = RepozitorijUzoraka.DohvatiUzorke();
        }

        private void dgvUzorci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string arg = dgvUzorci.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idUzorka = int.Parse(arg);
            var formPregledUzorka = new formPregledUzorka(idUzorka);
            formPregledUzorka.Show();
        }
    }
}
