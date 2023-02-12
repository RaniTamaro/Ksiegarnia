using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{
    public class KontrahentForAllView
    {
        #region Properties
        public int IdKontrahenta { get; set; }
        public string Kod { get; set; }
        public string NipLubPesel { get; set; }
        public string Nazwa { get; set; }

        public string KontrahentAdres { get; set; }
        #endregion
    }
}
