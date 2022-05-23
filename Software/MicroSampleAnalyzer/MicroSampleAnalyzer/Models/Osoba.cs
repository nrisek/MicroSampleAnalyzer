using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroSampleAnalyzer.Models
{
    public abstract class Osoba
    {
        public string Oib { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString() {
			return Ime + " " + Prezime;
		}
	}
}

