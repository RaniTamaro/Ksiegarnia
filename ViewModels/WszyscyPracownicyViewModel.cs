using Firma.Models.Entities;
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
    internal class WszyscyPracownicyViewModel : WszystkieViewModel<Pracownik>
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
            List = new ObservableCollection<Pracownik>
                (
                    from pracownik in Db.Pracownik
                    where pracownik.CzyAktywny == true
                    select pracownik
                );
        }
        #endregion
    }
}
