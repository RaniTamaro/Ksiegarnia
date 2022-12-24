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
    public class WszystkieFakturyViewModel : WszystkieViewModel<FakturyForAllView>
    {
        #region Konstruktor
        public WszystkieFakturyViewModel()
            :base (GlobalResources.FakturyWyswietl)
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<FakturyForAllView>
                (
                    from faktura in Db.Faktura
                    where faktura.CzyAktywny == true
                    select new FakturyForAllView
                    {
                        NumerDokumentu = faktura.NumerFaktury,
                        NazwaKontrahenta = faktura.Kontrahent.Nazwa,
                        DataWystawienia = faktura.DataWystawienia,
                        SposobPlatnosci = faktura.SposobPlatnosci.Nazwa,
                        Netto = faktura.Netto,
                        Brutto = faktura.Brutto
                    }
                );
        }
        #endregion
    }
}
