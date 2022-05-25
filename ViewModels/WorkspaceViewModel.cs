using Firma.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    //To jest klasa z ktorej beda dziedziczyc wszystkie ViewModele zakladek
    public class WorkspaceViewModel : BaseViewModel
    {
        #region Pola i Komendy
        //Kazda zakladka ma min nazwe i zamknij
        public string DisplayName { get; set; } //w tym propertisie bedzie przechowywana nazwa zakladki
        private BaseCommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(() => this.OnRequestClose()); //Ta komenda wywola funkcje zamykajaca zakladke
                return _CloseCommand;
            }
        }
        #endregion
        #region RequestClose [event] 
        public event EventHandler RequestClose;
        private void OnRequestClose() 
        { 
            EventHandler handler = this.RequestClose;
            if (handler != null) 
                handler(this, EventArgs.Empty); 
        } 
        #endregion
    }
}
