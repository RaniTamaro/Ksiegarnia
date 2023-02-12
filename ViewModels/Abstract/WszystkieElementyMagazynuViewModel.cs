using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels.Abstract
{
    public abstract class WszystkieElementyMagazynuViewModel : WszystkieViewModel<Magazyn>
    {
        #region Konstruktor
        protected WszystkieElementyMagazynuViewModel(string displayName)
            : base(displayName)
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
