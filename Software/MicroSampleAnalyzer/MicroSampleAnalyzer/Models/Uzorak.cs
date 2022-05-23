using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroSampleAnalyzer.Models
{
    public class Uzorak
    {
        public int Id { get; set; }
        public string DatumZaprimanja { get; set; }
        public string ZaprimioOIB { get; set; }
        public string PacijentOIB { get; set; }
        public string Opis { get; set; }

    }
}
