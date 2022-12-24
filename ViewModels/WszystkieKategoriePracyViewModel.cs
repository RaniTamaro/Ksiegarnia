using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszystkieKategoriePracyViewModel : WszystkieViewModel<KategoriaPracy>
    {
        #region Konstruktor
        public WszystkieKategoriePracyViewModel()
            : base("Kategorie Pracy")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KategoriaPracy>
                (
                    from kategoria in Db.KategoriaPracy
                    where kategoria.CzyAktywny == true
                    select kategoria
                );
        }
        #endregion
    }
}
