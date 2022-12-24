using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowyKontrahentViewModel : NowyElementViewModel<Kontrahent>
    {
        #region Konstruktor
        public NowyKontrahentViewModel()
            :base("Kontrahent")
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Helpers
        public override void Save()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
