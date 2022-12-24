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
    public class WszystkieGrupyViewModel : WszystkieViewModel<Grupa>
    {
        #region Konstruktor
        public WszystkieGrupyViewModel()
            :base("Grupy")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Grupa>
                (
                    from grupa in Db.Grupa
                    where grupa.CzyAktywny == true
                    select grupa
                );
        }
        #endregion
    }
}
