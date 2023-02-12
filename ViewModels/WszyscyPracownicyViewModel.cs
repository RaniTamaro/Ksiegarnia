using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class WszyscyPracownicyViewModel : WszystkieViewModel<PracownicyForAllView>
    {
        #region Properties
        private PracownicyForAllView _WybranyPracownik;
        public PracownicyForAllView WybranyPracownik
        {
            get
            {
                return _WybranyPracownik;
            }
            set
            {
                if (_WybranyPracownik != value)
                {
                    _WybranyPracownik = value;
                    Messenger.Default.Send(_WybranyPracownik);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konstruktor

        public WszyscyPracownicyViewModel()
            : base(GlobalResources.PracownicyWyswietl)
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<PracownicyForAllView>
                (
                    from pracownik in Db.Pracownik
                    where pracownik.CzyAktywny == true
                    select new PracownicyForAllView
                    {
                        IdPracownika = pracownik.IdPracownika,
                        Akronim = pracownik.Akronim,
                        Nazwisko = pracownik.Nazwisko,
                        Imie = pracownik.Imie,
                        PeselPracownika = pracownik.PeselPracownika,
                        AdresGlowny =
                            pracownik.Adres.KodPocztowy + " " +
                            pracownik.Adres.Miejscowosc + ", " +
                            pracownik.Adres.Ulica + " " +
                            pracownik.Adres.NrDomu +
                            (!string.IsNullOrEmpty(pracownik.Adres.NrLokalu) ? ("/" + pracownik.Adres.NrLokalu) : ""),
                        Stawka = pracownik.Stawka,
                        DataZatrudnienia = pracownik.DataZatrudnienia != null ? (DateTime)pracownik.DataZatrudnienia : DateTime.MinValue
                    }
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Akronim")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.OrderBy(item => item.Akronim));
            }

            if (SortField == "Nazwisko")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.OrderBy(item => item.Nazwisko));
            }

            if (SortField == "Imie")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.OrderBy(item => item.Imie));
            }

            if (SortField == "Pesel Pracownika")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.OrderBy(item => item.PeselPracownika));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Akronim", "Nazwisko", "Imie", "Pesel Pracownika" };
        }

        public override void Find()
        {
            if (FindField == "Akronim")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.Where(item => item.Akronim != null && item.Akronim.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwisko")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.Where(item => item.Nazwisko != null && item.Nazwisko.StartsWith(FindTextBox)));
            }

            if (FindField == "Imie")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.Where(item => item.Imie != null && item.Imie.StartsWith(FindTextBox)));
            }

            if (FindField == "Pesel Pracownika")
            {
                List = new ObservableCollection<PracownicyForAllView>(List.Where(item => item.PeselPracownika != null && item.PeselPracownika.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Akronim", "Nazwisko", "Imie", "Pesel Pracownika" };
        }
        #endregion
    }
}
