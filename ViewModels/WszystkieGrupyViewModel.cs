using Firma.Models.Entities;
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
    public class WszystkieGrupyViewModel : WszystkieViewModel<Grupa>
    {
        #region Properties
        private Grupa _WybranaGrupa;
        public Grupa WybranaGrupa
        {
            get
            {
                return _WybranaGrupa;
            }
            set
            {
                if (_WybranaGrupa != value)
                {
                    _WybranaGrupa = value;
                    Messenger.Default.Send(_WybranaGrupa);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konstruktor
        public WszystkieGrupyViewModel()
            :base("Grupy")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Grupa>
                (
                    from grupa in Db.Grupa
                    where grupa.CzyAktywny == true
                    select grupa
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Kod")
            {
                List = new ObservableCollection<Grupa>(List.OrderBy(item => item.Kod));
            }

            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<Grupa>(List.OrderBy(item => item.Nazwa));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Kod", "Nazwa" };
        }

        public override void Find()
        {
            if (FindField == "Kod")
            {
                List = new ObservableCollection<Grupa>(List.Where(item => item.Kod != null && item.Kod.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<Grupa>(List.Where(item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Kod", "Nazwa" };
        }
        #endregion
    }
}
