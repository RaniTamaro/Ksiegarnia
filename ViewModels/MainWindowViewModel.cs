using Firma.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        //Bedzie zawierala kolekcje komend, ktore pojawiaja sie w menu lewym oraz kolekcje zakladek
        #region Komendy menu i paska narzedzi
        public ICommand NowyTowarCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowyTowarViewModel()));//To jest komenda, ktora wywoluje funkcje createTowar
            }
        }
        public ICommand TowaryCommand
        {
            get
            {
                return new BaseCommand(showAllTowar);
            }
        }
        public ICommand NowaFakturaCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaFakturaViewModel()));
            }
        }
        public ICommand FakturyCommand
        {
            get
            {
                return new BaseCommand(showAllFaktury);
            }
        }

        public ICommand ZamknijAplikacje
        {
            get
            {
                return new BaseCommand(closeWindow);
            }
        }

        public ICommand NowyPracownikCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowyPracownikViewModel()));
            }
        }
        
        public ICommand PracownicyCommand
        {
            get
            {
                return new BaseCommand(showAllPracownicy);
            }
        }
        
        public ICommand PrzyjecieCommand
        {
            get
            {
                return new BaseCommand(() => createView(new PrzyjecieViewModel()));
            }
        }
        
        public ICommand WydanieCommand
        {
            get
            {
                return new BaseCommand(() => createView(new WydanieViewModel()));
            }
        }
        #endregion

        #region Przyciski w menu z lewej strony
        private ReadOnlyCollection<CommandViewModel> _Commands; //To jest kolekcja komend w menu lewym
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get 
            {
                if (_Commands == null)//Sprawdzam, czy przyciski z lewej strony menu nie zostaly zainicjalizowane
                {
                    List<CommandViewModel> cmds = this.CreateCommands();//Tworze liste przyciskowza pomoca funkcji CreateCommands
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);//Te liste przypisuje do ReadOnlyCollection, bo ReadOnlyCollection mozna tylko tworzyc, nie mozna jej dodawac
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()//Tu decydujemy, jakie przyciski sa w lewym menu
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel("Towary", new BaseCommand(showAllTowar)), //To tworzy pierwszy przycisk o nazwie Towary, ktory pokaze zakladke WszystkieTowary
                new CommandViewModel("Towar", new BaseCommand(()=>createView(new NowyTowarViewModel()))),
                new CommandViewModel("Faktura", new BaseCommand(()=>createView(new NowaFakturaViewModel()))),
                new CommandViewModel("Faktury", new BaseCommand(showAllFaktury)),
            };
        }
        #endregion

        #region Zakładki
        private ObservableCollection<WorkspaceViewModel> _Workspaces;//To jest kolekcja zakladek
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e) 
        { 
            if (e.NewItems != null && e.NewItems.Count != 0) 
                foreach (WorkspaceViewModel workspace in e.NewItems) 
                    workspace.RequestClose += this.OnWorkspaceRequestClose; 
            if (e.OldItems != null && e.OldItems.Count != 0) 
                foreach (WorkspaceViewModel workspace in e.OldItems) 
                    workspace.RequestClose -= this.OnWorkspaceRequestClose; 
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel; 
            //workspace.Dispos(); 
            this.Workspaces.Remove(workspace); 
        }
        #endregion

        #region Funkcje pomocnicze
        //Wersja uniwersalna funkcji create
        private void createView(WorkspaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.setActiveWorkspace(workspace);
        }

        private void showAllFaktury()
        {
            WszystkieFakturyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieFakturyViewModel) as WszystkieFakturyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieFakturyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }

        private void showAllTowar()
        {
            WszystkieTowaryViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieTowaryViewModel) as WszystkieTowaryViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieTowaryViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        
        private void showAllPracownicy()
        {
            WszyscyPracownicyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszyscyPracownicyViewModel) as WszyscyPracownicyViewModel;
            if (workspace == null)
            {
                workspace = new WszyscyPracownicyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }

        private void closeWindow()
        {
            App.Current.Shutdown();
        }

        private void setActiveWorkspace(WorkspaceViewModel workspace) 
        { 
            Debug.Assert(this.Workspaces.Contains(workspace));
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null) 
                collectionView.MoveCurrentTo(workspace); 
        }
        #endregion
    }
}
