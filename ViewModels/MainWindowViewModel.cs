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
        #region Pola i Wlasciwosci
        private int _szerokoscKolumnyMenu = 35;
        private bool _dostepnoscPrzycisku = true;

        public int SzerokoscKolumnyMenu
        {
            get
            {
                return _szerokoscKolumnyMenu;
            }
            set
            {
                if (_szerokoscKolumnyMenu != value)
                {
                    _szerokoscKolumnyMenu = value;
                    OnPropertyChanged(() => SzerokoscKolumnyMenu);
                }
            }
        }

        public bool DostepnoscPrzycisku
        {
            get
            {
                return _dostepnoscPrzycisku;
            }
            set
            {
                if (_dostepnoscPrzycisku != value)
                {
                    _dostepnoscPrzycisku = value;
                    OnPropertyChanged(() => DostepnoscPrzycisku);
                }
            }
        }
        #endregion

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

        public ICommand ZamknijAplikacjeCommand
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

        public ICommand NowaWyplataCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaWyplataViewModel()));
            }
        }

        public ICommand PokazUkryjMenuBoczneAsyncCommand
        {
            get
            {
                return new BaseCommand(async () => await PokazUkrujMenuBoczneAsync());
            }
        }
        #endregion

        #region Przyciski w menu z lewej strony
        private ReadOnlyCollection<CommandViewModel> _Commands;
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = this.CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }

        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
            {
                new CommandViewModel("IconNowyTowar.png","Dodaj Towar",new BaseCommand(()=>createView(new NowyTowarViewModel()))),
                new CommandViewModel("IconPrzyjecie.png","Nowe Przyjęcie",new BaseCommand(()=>createView(new PrzyjecieViewModel()))),
                new CommandViewModel("IconWydanie.png","Nowe Wydanie",new BaseCommand(()=>createView(new WydanieViewModel()))),
                new CommandViewModel("IconWydanie.png","Nowe Wydanie",new BaseCommand(()=>createView(new WydanieViewModel()))),
                new CommandViewModel("IconNowaFaktura.png","Dodaj Fakturę",new BaseCommand(()=>createView(new NowaFakturaViewModel()))),
                new CommandViewModel("IconFaktury.png","Wyświetl Faktury",new BaseCommand(showAllFaktury)),
                new CommandViewModel("IconZamknij.png","Zamknij",new BaseCommand(closeWindow))
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
        private async Task PokazUkrujMenuBoczneAsync()
        {
            DostepnoscPrzycisku = false;
            if (SzerokoscKolumnyMenu > 35)
            {
                while (SzerokoscKolumnyMenu > 35)
                {
                    SzerokoscKolumnyMenu -= 5;
                    await Task.Delay(5);
                }
            }
            else
            {
                while (SzerokoscKolumnyMenu < 150)
                {
                    SzerokoscKolumnyMenu += 5;
                    await Task.Delay(5);
                }
            }

            DostepnoscPrzycisku = true;
        }

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
