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

        #region Helpers
        public abstract void Save();
        private void saveAndClose()
        {
            Save();
            base.OnRequestClose();
        }
        #endregion
    }
}
