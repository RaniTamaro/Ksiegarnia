using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WydanieViewModel : WorkspaceViewModel
    {
        #region Kontruktor

        public WydanieViewModel()
        {
            base.DisplayName = GlobalResources.Wydanie;
        }
        #endregion
    }
}
