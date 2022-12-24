using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class FakturyForAllView
    {
        public string NumerDokumentu { get; set; }
        public string NazwaKontrahenta { get; set; }
        public DateTime DataWystawienia { get; set; }
        public string SposobPlatnosci { get; set; }
        public decimal? Netto { get; set; }
        public decimal? Brutto { get; set; }
    }
}
