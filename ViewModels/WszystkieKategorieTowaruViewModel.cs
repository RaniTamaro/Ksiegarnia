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
    public class WszystkieKategorieTowaruViewModel : WszystkieViewModel<KategoriaTowaru>
    {
        #region Konstruktor
        public WszystkieKategorieTowaruViewModel()
            : base("Kategorie")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<KategoriaTowaru>
                (
                    from kategoria in Db.KategoriaTowaru
                    where kategoria.CzyAktywny == true
                    select kategoria
                );
        }
        #endregion
    }
}
