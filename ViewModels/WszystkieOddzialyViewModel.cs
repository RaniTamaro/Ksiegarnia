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
    public class WszystkieOddzialyViewModel : WszystkieViewModel<Oddzial>
    {
        #region Properties
        private Oddzial _WybranyOddzial;
        public Oddzial WybranyOddzial
        {
            get
            {
                return _WybranyOddzial;
            }
            set
            {
                if (_WybranyOddzial != value)
                {
                    _WybranyOddzial = value;
                    Messenger.Default.Send(_WybranyOddzial);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konstruktor
        public WszystkieOddzialyViewModel()
            : base("Oddziały")
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<Oddzial>
                (
                    from oddzial in Db.Oddzial
                    where oddzial.CzyAktywny == true
                    select oddzial
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<Oddzial>(List.OrderBy(item => item.Nazwa));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Nazwa" };
        }

        public override void Find()
        {
            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<Oddzial>(List.Where(item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Nazwa" };
        }
        #endregion
    }
}
