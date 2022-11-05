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
    public class WszyscyWydawcyViewModel : WszystkieViewModel<Wydawca>
    {
        #region Konsturktor
        public WszyscyWydawcyViewModel()
            :base("Wszyscy wydawcy")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Wydawca>
                (
                    from wyd in Db.Wydawca
                    where wyd.CzyAktywny == true
                    select wyd
                );
        }
        #endregion
    }
}
