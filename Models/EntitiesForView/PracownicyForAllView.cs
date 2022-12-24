using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class PracownicyForAllView : Pracownik
    {
        public string Akronim { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string PeselPracownika { get; set; }
        public string AdresGlowny { get; set; }
        public decimal? Stawka { get; set; }
        public DateTime DataZatrudnienia { get; set; }
    }
}
