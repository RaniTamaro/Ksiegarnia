using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    //To jest klasa, ktora jest po to zeby tworzyc komendy w menu z lewej strony
    public class CommandViewModel:BaseViewModel
    {
        #region Wlasciwosci
        public string NazwaIkony { get; set; }
        public string DisplayName { get; set; } //To jest nazwa przycisku w menu z lewej strony
        public ICommand Command { get; set; } //Kazdy przycisk zawiera komende, ktora wywoluje funkcje, ktora otwiera zakladke
        #endregion
        #region Konstruktor
        public CommandViewModel(string nazwaIkony, string displayName, ICommand command)
        {
            if (command == null)
                throw new ArgumentNullException("Command");
            this.NazwaIkony = nazwaIkony;
            this.DisplayName = displayName;
            this.Command = command;
        }
        #endregion
    }
}
