using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class WyplatyForAllView
    {
        public DateTime? OkresOd { get; set; }
        public DateTime? OkresDo { get; set; }
        public string NumerDokumentu { get; set; }
        public string MiesiacDeklaracji { get; set; }
        public string NazwaPracownika { get; set; }
        public decimal Kwota { get; set; }
    }
}
