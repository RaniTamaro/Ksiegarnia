using Firma.Models.EntitiesForView;
using Firma.Tools.Constants;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class WszystkieTowaryViewModel : WszystkieViewModel<TowaryForAllView>
    {
        #region Properties
        private TowaryForAllView _WybranyTowar;
        public TowaryForAllView WybranyTowar
        {
            get
            {
                return _WybranyTowar;
            }
            set
            {
                if (_WybranyTowar != value)
                {
                    _WybranyTowar = value;
                    Messenger.Default.Send(_WybranyTowar);
                    OnRequestClose();
                }
            }
        }
        #endregion

        #region Konstruktor
        public WszystkieTowaryViewModel()
            :base(GlobalResources.TowaryWyswietl)
        {
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<TowaryForAllView>
                (
                    from towar in Db.Towar
                    where towar.CzyAktywny == true
                    select new TowaryForAllView
                    {
                        IdTowaru = towar.IdTowaru,
                        Kod = towar.KodTowaru,
                        Nazwa = towar.NazwaTowaru,
                        NazwaGrupy = towar.Grupa.Nazwa,
                        Ean = towar.EAN,
                        Cena = (towar.Cena.Where(x => x.Nazwa == NazwaCeny.CenaDetaliczna).FirstOrDefault()).CenaBrutto,
                        CenaNetto = (towar.Cena.Where(x => x.Nazwa == NazwaCeny.CenaDetaliczna).FirstOrDefault()).CenaNetto
                    }
                );
        }
        #endregion

        #region FindAndSort
        public override void Sort()
        {
            if (SortField == "Kod")
            {
                List = new ObservableCollection<TowaryForAllView>(List.OrderBy(item => item.Kod));
            }

            if (SortField == "Nazwa")
            {
                List = new ObservableCollection<TowaryForAllView>(List.OrderBy(item => item.Nazwa));
            }

            if (SortField == "Nazwa Grupy")
            {
                List = new ObservableCollection<TowaryForAllView>(List.OrderBy(item => item.NazwaGrupy));
            }
        }

        public override List<string> GetComboboxSortList()
        {
            return new List<string> { "Kod", "Nazwa", "Nazwa Grupy" };
        }

        public override void Find()
        {
            if (FindField == "Kod")
            {
                List = new ObservableCollection<TowaryForAllView>(List.Where(item => item.Kod != null && item.Kod.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa")
            {
                List = new ObservableCollection<TowaryForAllView>(List.Where(item => item.Nazwa != null && item.Nazwa.StartsWith(FindTextBox)));
            }

            if (FindField == "Nazwa Grupy")
            {
                List = new ObservableCollection<TowaryForAllView>(List.Where(item => item.NazwaGrupy != null && item.NazwaGrupy.StartsWith(FindTextBox)));
            }
        }

        public override List<string> GetComboboxFindList()
        {
            return new List<string> { "Kod", "Nazwa", "Nazwa Grupy" };
        }
        #endregion
    }
}
