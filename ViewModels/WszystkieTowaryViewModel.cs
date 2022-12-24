using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WszystkieTowaryViewModel : WszystkieViewModel<TowaryForAllView>
    {
        #region Konstruktor
        public WszystkieTowaryViewModel()
            :base(GlobalResources.TowaryWyswietl)
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<TowaryForAllView>
                (
                    from towar in Db.Towar
                    where towar.CzyAktywny == true
                    select new TowaryForAllView
                    {
                        Kod = towar.KodTowaru,
                        Nazwa = towar.NazwaTowaru,
                        NazwaGrupy = towar.Grupa.Nazwa,
                        Ean = towar.EAN
                    }
                );
        }
        #endregion
    }
}
