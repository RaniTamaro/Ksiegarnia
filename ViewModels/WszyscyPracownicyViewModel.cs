using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WszyscyPracownicyViewModel : WorkspaceViewModel
    {
        #region Konstruktor

        public WszyscyPracownicyViewModel()
        {
            base.DisplayName = GlobalResources.PracownicyWyswietl;
        }
        #endregion
    }
}
