using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszystkiePrzyjeciaViewModel : WszystkieViewModel<MagazynForAllView>
    {
        #region Konstruktor
        public WszystkiePrzyjeciaViewModel()
            : base("Przyjęcia")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<MagazynForAllView>
                (
                    from magazyn in Db.Magazyn
                    where magazyn.CzyAktywny == true && magazyn.RodzajDokumentu.Kod.StartsWith("P")
                    select new MagazynForAllView
                    {
                        Numer = magazyn.NumerGlowny.Trim() + "/" + magazyn.NumerRok,
                        NazwaMagazynu = magazyn.Oddzial.Nazwa,
                        DataWystawienia = magazyn.DataWystawienia,
                        CenaNetto = magazyn.Netto,
                        Cena = magazyn.Razem
                    }
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Numer")
            {
                List = new ObservableCollection<MagazynForAllView>(List.OrderBy(item => item.Numer));
            }

            if (SortField == "Nazwa Magazynu")
            {
                List = new ObservableCollection<MagazynForAllView>(List.OrderBy(item => item.NazwaMagazynu));
            }

            if (SortField == "Data Wystawienia")
            {
                List = new ObservableCollection<MagazynForAllView>(List.OrderBy(item => item.DataWystawienia));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Numer", "Nazwa Magazynu", "Data Wystawienia" };
        }

        public override void Find()
        {
            if (FindField == "Numer")
            {
                List = new ObservableCollection<MagazynForAllView>(List.Where(item => item.Numer != null && item.Numer.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa Magazynu")
            {
                List = new ObservableCollection<MagazynForAllView>(List.Where(item => item.NazwaMagazynu != null && item.NazwaMagazynu.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Numer", "Nazwa Magazynu" };
        }
        #endregion
    }
}
