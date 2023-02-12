using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszyscyKontrahenciViewModel : WszystkieViewModel<KontrahentForAllView>
    {
        #region Properties
        private KontrahentForAllView _WybranyKontrahent;
        public KontrahentForAllView WybranyKontrahent
        {
            get
            {
                return _WybranyKontrahent;
            }
            set
            {
                if (_WybranyKontrahent != value)
                {
                    _WybranyKontrahent = value;
                    Messenger.Default.Send(_WybranyKontrahent);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konstruktor
        public WszyscyKontrahenciViewModel()
            :base("Kontrahenci")
        {
        }
        #endregion


        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KontrahentForAllView>
                (
                    from kontrahent in Db.Kontrahent
                    where kontrahent.CzyAktywny == true
                    select new KontrahentForAllView
                    {
                        IdKontrahenta = kontrahent.IdKontrahenta,
                        Kod = kontrahent.Kod,
                        NipLubPesel = kontrahent.NIP != null ? kontrahent.NIP : kontrahent.PESEL,
                        Nazwa = kontrahent.Nazwa,
                        KontrahentAdres =
                            kontrahent.Adres.KodPocztowy + " " +
                            kontrahent.Adres.Miejscowosc + ", " +
                            kontrahent.Adres.Ulica + " " +
                            kontrahent.Adres.NrDomu
                    }
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Kod")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.Kod));
            }

            if (SortField == "NIP lub Pesel")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.NipLubPesel));
            }

            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.OrderBy(item => item.Nazwa));
            }

        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Kod", "NIP lub Pesel", "Nazwa" };
        }

        public override void Find()
        {
            if (FindField == "Kod")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.Kod != null && item.Kod.StartsWith(FindTextBox)));
            }

            if (FindField == "NIP lub Pesel")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.NipLubPesel != null && item.NipLubPesel.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<KontrahentForAllView>(List.Where(item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Kod", "NIP lub Pesel", "Nazwa" };
        }
        #endregion
    }
}
