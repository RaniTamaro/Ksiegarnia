using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowaFakturaViewModel:WorkspaceViewModel //Bo wszystkie zakladki dziedzicza po workspaceVM
    {
        #region Konstruktor
        public NowaFakturaViewModel()
        {
            base.DisplayName = GlobalResources.Faktura;
        }
        #endregion
    }
}
