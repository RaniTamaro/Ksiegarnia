using Firma.Models.Entities;
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
    internal class WszyscyPracownicyViewModel : WszystkieViewModel<PracownicyForAllView>
    {
        #region Konstruktor

        public WszyscyPracownicyViewModel()
            : base("Wszyscy pracownicy")
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
                        DataZatrudnienia = pracownik.DataZatrudnienia
                    }
                );
        }
        #endregion
    }
}
