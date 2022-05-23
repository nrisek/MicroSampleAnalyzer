using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroSampleAnalyzer.Models
{
    public class Pacijent : Osoba
    {
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string GodinaRodenja { get; set; }
        public string PovijestBolesti { get; set; }
        public string PrijasnjeAnalize { get; set; }

    }
}
