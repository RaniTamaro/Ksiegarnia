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
    public class WszyscyWydawcyViewModel : WszystkieViewModel<Wydawca>
    {
        #region Properties
        private Wydawca _WybranyWydawca;
        public Wydawca WybranyWydawca
        {
            get
            {
                return _WybranyWydawca;
            }
            set
            {
                if (_WybranyWydawca != value)
                {
                    _WybranyWydawca = value;
                    Messenger.Default.Send(_WybranyWydawca);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konsturktor
        public WszyscyWydawcyViewModel()
            :base("Wydawcy")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Wydawca>
                (
                    from wyd in Db.Wydawca
                    where wyd.CzyAktywny == true
                    select wyd
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Kod")
            {
                List = new ObservableCollection<Wydawca>(List.OrderBy(item => item.Kod));
            }

            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<Wydawca>(List.OrderBy(item => item.Nazwa));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Kod", "Nazwa"};
        }

        public override void Find()
        {
            if (FindField == "Kod")
            {
                List = new ObservableCollection<Wydawca>(List.Where(item => item.Kod != null && item.Kod.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<Wydawca>(List.Where(item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Kod", "Nazwa" };
        }
        #endregion
    }
}