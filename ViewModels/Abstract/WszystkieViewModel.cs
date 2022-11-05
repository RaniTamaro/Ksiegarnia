using Firma.Helpers;
using Firma.Models.Entities;
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

        private BaseCommand _LoadComand;
        public ICommand LoadComand
        {
            get
            {
                if (_LoadComand is null)
                {
                    _LoadComand = new BaseCommand(() => Load());//Pusta wywołuje load
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

        #region Helpers
        public abstract void Load();
        #endregion
    }
}
