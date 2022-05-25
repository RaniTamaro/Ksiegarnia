using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WszystkieTowaryViewModel:WorkspaceViewModel
    {
        #region Konstruktor
        public WszystkieTowaryViewModel()
        {
            base.DisplayName = GlobalResources.TowaryWyswietl;
        }
        #endregion
    }
}
