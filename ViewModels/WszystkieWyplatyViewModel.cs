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
            :base("Wyplaty")
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
                    //select wyplata
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
    }
}
