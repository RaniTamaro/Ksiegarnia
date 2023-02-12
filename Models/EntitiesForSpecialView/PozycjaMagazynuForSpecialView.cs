using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForSpecialView
{
    public class PozycjaMagazynuForSpecialView : PozycjaMagazynu
    {
        public decimal CenaNetto { get; set; }

        public decimal ObliczonaWartosc { get; set; }
    }
}
