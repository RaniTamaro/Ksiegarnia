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
    public class RaportPrzyjecWydanViewModel : WorkspaceViewModel
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

        private int _IdRodzajuDokumentu;
        public int IdRodzajuDokumentu
        {
            get
            {
                return _IdRodzajuDokumentu;
            }
            set
            {
                if (value != _IdRodzajuDokumentu)
                    _IdRodzajuDokumentu = value;

                OnPropertyChanged(() => IdRodzajuDokumentu);
            }
        }

        private decimal? _IloscAkcji;
        public decimal? IloscAkcji
        {
            get
            {
                return _IloscAkcji;
            }
            set
            {
                if (value != _IloscAkcji)
                    _IloscAkcji = value;

                OnPropertyChanged(() => IloscAkcji);
            }
        }

        public IQueryable<KeyAndValue> RodzajAkcjiMagazynowejComboboxItems
        {
            get
            {
                return new RodzajDokumentuBusiness(Db).GetNazwyAkcji();
            }
        }
        #endregion

        #region Konstruktor
        public RaportPrzyjecWydanViewModel()
        {
            base.DisplayName = "Raport Przyjęć i Wydań";
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
                    _ObliczCommand = new BaseCommand(() => obliczIlośćClick());
                }
                return _ObliczCommand;
            }
        }
        #endregion

        #region Helpers
        private void obliczIlośćClick()
        {
            IloscAkcji = new IloscAkcjiBusiness(Db).IloscAkcjiOkres(IdRodzajuDokumentu, DataOd, DataDo);
        }
        #endregion
    }
}
