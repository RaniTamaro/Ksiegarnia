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
    public class WszystkieWyplatyViewModel : WszystkieViewModel<WyplatyForAllView>
    {
        #region Konstruktor
        public WszystkieWyplatyViewModel()
            :base("Wypłaty")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<WyplatyForAllView>
                (
                    from wyplata in Db.Wyplata
                    where wyplata.CzyAktywny == true
                    select new WyplatyForAllView
                    {
                        OkresOd = wyplata.OkresWyplaty.OdKiedy,
                        OkresDo = wyplata.OkresWyplaty.DoKiedy,
                        NumerDokumentu = wyplata.NumerDokumentu,
                        NazwaPracownika = wyplata.Pracownik.Nazwisko + " " + wyplata.Pracownik.Imie,
                        Kwota = wyplata.Kwota
                    }
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Okres Od")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.OrderBy(item => item.OkresOd));
            }

            if (SortField == "Okres Do")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.OrderBy(item => item.OkresDo));
            }

            if (SortField == "Numer Dokumentu")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.OrderBy(item => item.NumerDokumentu));
            }

            if (SortField == "Nazwa Pracownika")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.OrderBy(item => item.NazwaPracownika));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Okres Od", "Okres Do", "Numer Dokumentu", "Nazwa Pracownika" };
        }

        public override void Find()
        {
            if (FindField == "Numer Dokumentu")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.Where(item => item.NumerDokumentu != null && item.NumerDokumentu.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa Pracownika")
            {
                List = new ObservableCollection<WyplatyForAllView>(List.Where(item => item.NazwaPracownika != null && item.NazwaPracownika.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Numer Dokumentu", "Nazwa Pracownika" };
        }
        #endregion
    }
}
