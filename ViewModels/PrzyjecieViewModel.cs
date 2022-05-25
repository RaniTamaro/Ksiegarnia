using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class PrzyjecieViewModel : WorkspaceViewModel
    {
        #region Konstruktor

        public PrzyjecieViewModel()
        {
            base.DisplayName = GlobalResources.Przyjęcie;
        }
        #endregion
    }
}
