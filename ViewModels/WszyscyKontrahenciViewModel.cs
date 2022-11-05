using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszyscyKontrahenciViewModel : WszystkieViewModel<Kontrahent>
    {
        #region Konstruktor
        public WszyscyKontrahenciViewModel()
            :base("Wszyscy kontrahenci")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Kontrahent>
                (
                    from kontrahent in Db.Kontrahent
                    where kontrahent.CzyAktywny == true
                    select kontrahent
                );
        }
        #endregion
    }
}
