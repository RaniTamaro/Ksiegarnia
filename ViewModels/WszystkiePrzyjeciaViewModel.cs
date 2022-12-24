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
                    where magazyn.CzyAktywny == true && magazyn.RodzajDokumentu.Kod.StartsWith("PZ")
                    select new MagazynForAllView
                    {
                        Numer = magazyn.RodzajDokumentu.Kod + "/" + magazyn.NumerGlowny + "/" + magazyn.NumerRok,
                        NazwaMagazynu = magazyn.Oddzial.Nazwa,
                        DataWystawienia = magazyn.DataWystawienia,
                        CenaNetto = magazyn.Netto,
                        Cena = magazyn.Razem
                    }
                );
        }
        #endregion
    }
}
