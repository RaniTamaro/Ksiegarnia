using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowaWyplataViewModel:WorkspaceViewModel
    {
        #region Konstruktor
        public NowaWyplataViewModel()
        {
            base.DisplayName = GlobalResources.Wyplata;
        }
        #endregion
    }
}
