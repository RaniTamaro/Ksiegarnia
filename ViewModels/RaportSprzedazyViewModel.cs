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
    public class RaportSprzedazyViewModel : WorkspaceViewModel
    {
        #region Wlasciwosci
        public KsiegarniaEntities Db { get; set; }
        private DateTime _dataOd;
        public DateTime DataOd
        {
            get
            {
                return _dataOd;
            }
            set
            {
                if (value != _dataOd)
                    _dataOd = value;

                OnPropertyChanged(() => DataOd);
            }
        }

        private DateTime _dataDo;
        public DateTime DataDo
        {
            get
            {
                return _dataDo;
            }
            set
            {
                if (value != _dataDo)
                    _dataDo = value;

                OnPropertyChanged(() => DataDo);
            }
        }

        private int _idTowaru;
        public int IdTowaru
        {
            get
            {
                return _idTowaru;
            }
            set
            {
                if (value != _idTowaru)
                    _idTowaru = value;

                OnPropertyChanged(() => IdTowaru);
            }
        }

        private decimal? _utarg;
        public decimal? Utarg
        {
            get
            {
                return _utarg;
            }
            set
            {
                if (value != _utarg)
                    _utarg = value;

                OnPropertyChanged(() => Utarg);
            }
        }

        public IQueryable<KeyAndValue> TowaryComboboxItems
        {
            get
            {
                return new TowarBusiness(Db).GetAktywneTowary();
            }
        }
        #endregion

        #region Konstruktor
        public RaportSprzedazyViewModel()
        {
            base.DisplayName = "Raport Sprzedazy";
            Db = new KsiegarniaEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
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
                    _ObliczCommand = new BaseCommand(() => obliczUtargClick());
                }
                return _ObliczCommand;
            }
        }
        #endregion

        #region Helpers
        private void obliczUtargClick()
        {
            Utarg = new UtargBusiness(Db).UtargOkresTowar(IdTowaru, DataOd, DataDo);
        }
        #endregion
    }
}
