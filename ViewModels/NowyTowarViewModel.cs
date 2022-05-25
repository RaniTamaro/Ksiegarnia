using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class NowyTowarViewModel :WorkspaceViewModel
    {
        #region Konstruktor
        public NowyTowarViewModel()
        {
            base.DisplayName = GlobalResources.Towar;
        }
        #endregion
    }
}
