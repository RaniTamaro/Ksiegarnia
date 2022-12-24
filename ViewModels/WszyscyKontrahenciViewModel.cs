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
    public class WszyscyKontrahenciViewModel : WszystkieViewModel<KontrahentForAllView>
    {
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
    }
}
