using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class TowaryForAllView
    {
        public int IdTowaru { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }

        public string NazwaGrupy { get; set; }

        public decimal? Cena { get; set; }
        public decimal CenaNetto { get; set; }
        public string Ean { get; set; }
    }
}
