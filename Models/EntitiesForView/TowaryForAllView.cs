using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class TowaryForAllView
    {
        public string Kod { get; set; }
        public string Nazwa { get; set; }

        public string NazwaGrupy { get; set; }

        public int Ilosc { get; set; }
        public string Ean { get; set; }
    }
}
