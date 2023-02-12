using Firma.Helpers;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Firma.ViewModels.Abstract
{
    public abstract class NowyElementViewModel<T> : WorkspaceViewModel
    {
        #region Fields
        public KsiegarniaEntities Db { get; set; }
        public T Item { get; set; }
        #endregion

        #region Konstruktor
        public NowyElementViewModel(string displayName)
        {
            base.DisplayName = displayName;
            Db = new KsiegarniaEntities();
        }
        #endregion

        #region Properties
        public abstract string NazwaDodajacego { get; set; }
        public abstract DateTime? DataDodania { get; set; }
        public abstract string NazwaModyfikujacego { get; set; }
        public abstract DateTime? DataModyfikacji { get; set; }
        #endregion

        #region Command
        private BaseCommand _SaveAndCommad;
        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (_SaveAndCommad is null)
                {
                    _SaveAndCommad = new BaseCommand(() => saveAndClose());
                }

                return _SaveAndCommad;
            }
        }
        #endregion

        #region Validation
        public virtual bool IsValid()
        {
            return true;
        }
        #endregion

        #region Helpers
        public abstract void Save();
        private void saveAndClose()
        {
            if (IsValid())
            {
                Save();
                base.OnRequestClose();
            }
            else
            {
                MessageBox.Show("Popraw wszystkie dane");
            }
        }

        protected void SetAddedInformation()
        {
            NazwaDodajacego = Environment.UserName;
            DataDodania = DateTime.Now.Date;
        }
        #endregion
    }
}
