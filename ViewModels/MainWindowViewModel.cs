using AutoMapper;
using Firma.Helpers;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Kontruktor
        public MainWindowViewModel(IMapper mapper)
        {
            _mapper = mapper;
        }
        #endregion

        #region Pola i Wlasciwosci
        private IMapper _mapper;

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
                return new BaseCommand(() => createView(new NowaFakturaViewModel(_mapper)));
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
        
        public ICommand NowyKontrahentCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowyKontrahentViewModel()));
            }
        }

        public ICommand KontrahenciCommand
        {
            get
            {
                return new BaseCommand(showAllKontrahenci);
            }
        }

        public ICommand NowyWydawcaCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowyWydawcaViewModel()));
            }
        }

        public ICommand WydawcyCommand
        {
            get
            {
                return new BaseCommand(showAllWydawcy);
            }
        }

        public ICommand PrzyjecieCommand
        {
            get
            {
                return new BaseCommand(() => createView(new PrzyjecieViewModel(_mapper)));
            }
        }

        public ICommand WszystkiePrzyjeciaCommand
        {
            get
            {
                return new BaseCommand(showAllPrzyjecia);
            }
        }

        public ICommand WydanieCommand
        {
            get
            {
                return new BaseCommand(() => createView(new WydanieViewModel(_mapper)));
            }
        }

        public ICommand WszystkieWydaniaCommand
        {
            get
            {
                return new BaseCommand(showAllWydania);
            }
        }

        public ICommand NowaWyplataCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaWyplataViewModel()));
            }
        }

        public ICommand WyplatyCommand
        {
            get
            {
                return new BaseCommand(showAllWyplaty);
            }
        }

        public ICommand NowaGrupaCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaGrupaViewModel()));
            }
        }

        public ICommand GrupyCommand
        {
            get
            {
                return new BaseCommand(showAllGrupy);
            }
        }

        public ICommand NowyOddzialCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowyOddzialViewModel()));
            }
        }

        public ICommand OddzialyCommand
        {
            get
            {
                return new BaseCommand(showAllOddzialy);
            }
        }

        public ICommand NowaKategoriaTowaruCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaKategoriaTowaruViewModel()));
            }
        }

        public ICommand KategorieTowaruCommand
        {
            get
            {
                return new BaseCommand(showAllKategorieTowaru);
            }
        }

        public ICommand NowaKategoriaPracyCommand
        {
            get
            {
                return new BaseCommand(() => createView(new NowaKategoriaPracyViewModel()));
            }
        }

        public ICommand KategoriePracyCommand
        {
            get
            {
                return new BaseCommand(showAllKategoriePracy);
            }
        }

        public ICommand RaportSprzedazyCommand
        {
            get
            {
                return new BaseCommand(showRaportSprzedazy);
            }
        }

        public ICommand KosztyPracowniczeCommand
        {
            get
            {
                return new BaseCommand(showKosztyPracownicze);
            }
        }

        public ICommand RaportPrzyjecWydanCommand
        {
            get
            {
                return new BaseCommand(showRaportPrzyjecWydan);
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
            Messenger.Default.Register<string>(this, open);
            return new List<CommandViewModel>
            {
                new CommandViewModel("IconNowyTowar.png","Dodaj Towar",new BaseCommand(()=>createView(new NowyTowarViewModel()))),
                new CommandViewModel("IconPrzyjecie.png","Nowe Przyjęcie",new BaseCommand(()=>createView(new PrzyjecieViewModel(_mapper)))),
                new CommandViewModel("IconWydanie.png","Nowe Wydanie",new BaseCommand(()=>createView(new WydanieViewModel(_mapper)))),
                new CommandViewModel("IconPracownicy.png","Pracownicy",new BaseCommand(showAllPracownicy)),
                new CommandViewModel("IconNowaFaktura.png","Dodaj Fakturę",new BaseCommand(()=>createView(new NowaFakturaViewModel(_mapper)))),
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

        private void showAllKontrahenci()
        {
            WszyscyKontrahenciViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszyscyKontrahenciViewModel) as WszyscyKontrahenciViewModel;
            if (workspace == null)
            {
                workspace = new WszyscyKontrahenciViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllPrzyjecia()
        {
            WszystkiePrzyjeciaViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkiePrzyjeciaViewModel) as WszystkiePrzyjeciaViewModel;
            if (workspace == null)
            {
                workspace = new WszystkiePrzyjeciaViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllWydania()
        {
            WszystkieWydaniaViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieWydaniaViewModel) as WszystkieWydaniaViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieWydaniaViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllWydawcy()
        {
            WszyscyWydawcyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszyscyWydawcyViewModel) as WszyscyWydawcyViewModel;
            if (workspace == null)
            {
                workspace = new WszyscyWydawcyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllWyplaty()
        {
            WszystkieWyplatyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieWyplatyViewModel) as WszystkieWyplatyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieWyplatyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllGrupy()
        {
            WszystkieGrupyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieGrupyViewModel) as WszystkieGrupyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieGrupyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }
        
        private void showAllOddzialy()
        {
            WszystkieOddzialyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieOddzialyViewModel) as WszystkieOddzialyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieOddzialyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showAllKategorieTowaru()
        {
            WszystkieKategorieTowaruViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieKategorieTowaruViewModel) as WszystkieKategorieTowaruViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieKategorieTowaruViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }
        
        private void showAllKategoriePracy()
        {
            WszystkieKategoriePracyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is WszystkieKategoriePracyViewModel) as WszystkieKategoriePracyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieKategoriePracyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showRaportSprzedazy()
        {
            RaportSprzedazyViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is RaportSprzedazyViewModel) as RaportSprzedazyViewModel;
            if (workspace == null)
            {
                workspace = new RaportSprzedazyViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showKosztyPracownicze()
        {
            KosztyPracowniczeViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is KosztyPracowniczeViewModel) as KosztyPracowniczeViewModel;
            if (workspace == null)
            {
                workspace = new KosztyPracowniczeViewModel();
                this.Workspaces.Add(workspace);
            }

            this.setActiveWorkspace(workspace);
        }

        private void showRaportPrzyjecWydan()
        {
            RaportPrzyjecWydanViewModel workspace = this.Workspaces.FirstOrDefault(vm => vm is RaportPrzyjecWydanViewModel) as RaportPrzyjecWydanViewModel;
            if (workspace == null)
            {
                workspace = new RaportPrzyjecWydanViewModel();
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

        private void open(string name)
        {
            if (name == "TowaryAdd")
            {
                createView(new NowyTowarViewModel());
            }

            if (name == "FakturyAdd")
            {
                createView(new NowaFakturaViewModel(_mapper));
            }

            if (name == "KontrahenciAdd")
            {
                createView(new NowyKontrahentViewModel());
            }

            if (name == "PrzyjęciaAdd")
            {
                createView(new PrzyjecieViewModel(_mapper));
            }

            if (name == "WydaniaAdd")
            {
                createView(new WydanieViewModel(_mapper));
            }

            if (name == "PracownicyAdd")
            {
                createView(new NowyPracownikViewModel());
            }

            if (name == "WypłatyAdd")
            {
                createView(new NowaWyplataViewModel());  
            }

            if (name == "WydawcyAdd")
            {
                createView(new NowyWydawcaViewModel());
            }

            if (name == "GrupyAdd")
            {
                createView(new NowaGrupaViewModel());
            }

            if (name == "OddziałyAdd")
            {
                createView(new NowyOddzialViewModel());
            }

            if (name == "KategorieAdd")
            {
                createView(new NowaKategoriaTowaruViewModel());
            }

            if (name == "Kategorie PracyAdd")
            {
                createView(new NowaKategoriaPracyViewModel());
            }

            if (name == "GrupyAll")
            {
                showAllGrupy();
            }

            if (name == "WydawcyAll")
            {
                showAllWydawcy();
            }

            if (name == "OddziałyAll")
            {
                showAllOddzialy();
            }

            if (name == "KontrahenciAll")
            {
                showAllKontrahenci();
            }

            if (name == "PracownicyAll")
            {
                showAllPracownicy();
            }

            if (name == "TowaryAll")
            {
                showAllTowar();
            }
        }
        #endregion

    }
}
