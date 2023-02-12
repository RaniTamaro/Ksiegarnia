using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels.Abstract
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        private readonly KsiegarniaEntities db;
        public KsiegarniaEntities Db
        {
            get
            {
                return db;
            }
        }

        private BaseCommand _AddCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand is null)
                {
                    _AddCommand = new BaseCommand(() => Add());
                }

                return _AddCommand;
            }
        }

        private BaseCommand _LoadComand;
        public ICommand LoadComand
        {
            get
            {
                if (_LoadComand is null)
                {
                    _LoadComand = new BaseCommand(() => Load());
                }

                return _LoadComand;
            }
        }

        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List is null)
                    Load();

                return _List;
            }

            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion

        #region Konstruktor
        public WszystkieViewModel(string displayName)
        {
            base.DisplayName = displayName;
            this.db = new KsiegarniaEntities();
        }
        #endregion

        #region Properties
        public IQueryable<KeyAndValue> MagazynComboboxItems
        {
            get
            {
                return Db.Oddzial
                    .Where(x => x.CzyAktywny == true && x.Rodzaj.StartsWith("M"))
                    .Select(oddzial =>
                        new KeyAndValue
                        {
                            Key = oddzial.IdOddzialu,
                            Value = oddzial.Nazwa
                        }
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable<KeyAndValue> KontrahentComboboxItems
        {
            get
            {
                return Db.Kontrahent
                    .Where(x => x.CzyAktywny == true)
                    .Select(oddzial =>
                        new KeyAndValue
                        {
                            Key = oddzial.IdKontrahenta,
                            Value = oddzial.Nazwa
                        }
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable TypCenyComboboxItems
        {
            get
            {
                return Enum.GetValues(typeof(Tools.Constants.TypCeny)).AsQueryable();
            }
        }
        #endregion

        #region Sort
        private BaseCommand _SortCommand;
        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand is null)
                {
                    _SortCommand = new BaseCommand(() => Sort());
                }

                return _SortCommand;
            }
        }

        public abstract void Sort();
        public string SortField { get; set; }
        public List<string> SortComboboxItems
        {
            get
            {
                return GetComboboxSortList();
            }
        }
        public abstract List<string> GetComboboxSortList();
        #endregion

        #region Find
        private BaseCommand _FindCommand;
        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand is null)
                {
                    _FindCommand = new BaseCommand(() => Find());
                }

                return _FindCommand;
            }
        }

        public abstract void Find();
        public string FindField { get; set; }
        public string FindTextBox { get; set; }

        public List<string> FindComboboxItems
        {
            get
            {
                return GetComboboxFindList();
            }
        }
        public abstract List<string> GetComboboxFindList();
        #endregion

        #region Helpers
        public abstract void Load();
        public void Add()
        {
            Messenger.Default.Send(DisplayName + "Add");
        }
        #endregion
    }
}
