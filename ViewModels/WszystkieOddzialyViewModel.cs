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
    public class WszystkieOddzialyViewModel : WszystkieViewModel<Oddzial>
    {
        #region Konstruktor
        public WszystkieOddzialyViewModel()
            : base("Oddziały")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Oddzial>
                (
                    from oddzial in Db.Oddzial
                    where oddzial.CzyAktywny == true
                    select oddzial
                );
        }
        #endregion
    }
}
