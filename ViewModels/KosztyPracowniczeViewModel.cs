using Firma.Helpers;
using Firma.Models.BusinessLogic;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class KosztyPracowniczeViewModel : WorkspaceViewModel
    {
        #region Wlasciwosci
        public KsiegarniaEntities Db { get; set; }

        private int _idOkresu;
        public int IdOkresu
        {
            get
            {
                return _idOkresu;
            }
            set
            {
                if (value != _idOkresu)
                    _idOkresu = value;

                OnPropertyChanged(() => IdOkresu);
            }
        }

        private decimal? _koszt;
        public decimal? Koszt
        {
            get
            {
                return _koszt;
            }
            set
            {
                if (value != _koszt)
                    _koszt = value;

                OnPropertyChanged(() => Koszt);
            }
        }

        public IQueryable<KeyAndValue> OkresyComboboxItems
        {
            get
            {
                return new OkresBusiness(Db).GetAktywneOkresy();
            }
        }
        #endregion

        #region Konstruktor
        public KosztyPracowniczeViewModel()
        {
            base.DisplayName = "Koszty pracownicze";
            Db = new KsiegarniaEntities();
        }
        #endregion

        #region Command
        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand(() => obliczKosztClick());
                }
                return _ObliczCommand;
            }
        }
        #endregion

        #region Helpers
        private void obliczKosztClick()
        {
            Koszt = new KosztyPracowniczeBusiness(Db).KosztyPracownicyOkres(IdOkresu);
        }
        #endregion
    }
}
