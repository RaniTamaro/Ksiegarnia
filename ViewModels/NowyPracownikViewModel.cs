using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class NowyPracownikViewModel : WorkspaceViewModel
    {
        #region Konstruktor

        public NowyPracownikViewModel()
        {
            base.DisplayName = GlobalResources.PracodwnikDodaj;
                //"Dodaj Pracownika";
        }
        #endregion
    }
}
