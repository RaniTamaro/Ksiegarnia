using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class MagazynForAllView : Magazyn
    {
        public string Numer { get; set; }
        public string NazwaMagazynu { get; set; }
        public DateTime DataWystawienia { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal Cena { get; set; }
    }
}
