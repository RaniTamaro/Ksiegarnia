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

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Numer Dokumentu")
            {
                List = new ObservableCollection<FakturyForAllView>(List.OrderBy(item => item.NumerDokumentu));
            }

            if (SortField == "Nazwa Kontrahenta")
            {
                List = new ObservableCollection<FakturyForAllView>(List.OrderBy(item => item.NazwaKontrahenta));
            }

            if (SortField == "Data Wystawienia")
            {
                List = new ObservableCollection<FakturyForAllView>(List.OrderBy(item => item.DataWystawienia));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Numer Dokumentu", "Nazwa Kontrahenta", "Data Wystawienia" };
        }

        public override void Find()
        {
            if (FindField == "Numer Dokumentu")
            {
                List = new ObservableCollection<FakturyForAllView>(List.Where(item => item.NumerDokumentu != null && item.NumerDokumentu.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa Kontrahenta")
            {
                List = new ObservableCollection<FakturyForAllView>(List.Where(item => item.NazwaKontrahenta != null && item.NazwaKontrahenta.StartsWith(FindTextBox)));
            }

            if (FindField == "Sposob Platnosci")
            {
                List = new ObservableCollection<FakturyForAllView>(List.Where(item => item.SposobPlatnosci != null && item.SposobPlatnosci.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Numer Dokumentu", "Nazwa Kontrahenta", "Sposob Platnosci" };
        }
        #endregion
    }
}
