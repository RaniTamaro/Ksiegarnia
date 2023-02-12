using AutoMapper;
using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForSpecialView;
using Firma.Models.EntitiesForView;
using Firma.Models.Validators;
using Firma.Tools.Constants;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class NowaFakturaViewModel : NowyElementViewModel<Faktura>, IDataErrorInfo
    {
        #region Command
        private BaseCommand _ShowKontrahenciCommand;
        public ICommand ShowKontrahenciCommand
        {
            get
            {
                if (_ShowKontrahenciCommand == null)
                {
                    _ShowKontrahenciCommand = new BaseCommand(() => showKontrahenci());
                }

                return _ShowKontrahenciCommand;
            }
        }

        private BaseCommand _ShowTowaryCommand;
        public ICommand ShowTowaryCommand
        {
            get
            {
                if (_ShowTowaryCommand == null)
                {
                    _ShowTowaryCommand = new BaseCommand(() => showTowary());
                }

                return _ShowTowaryCommand;
            }
        }

        private void showKontrahenci()
        {
            Messenger.Default.Send("KontrahenciAll");
        }

        private void showTowary()
        {
            Messenger.Default.Send("TowaryAll");
        }
        #endregion

        #region Konstruktor
        public NowaFakturaViewModel(IMapper mapper)
            : base(GlobalResources.Faktura)
        {
            Item = new Faktura();
            Messenger.Default.Register<KontrahentForAllView>(this, getWybranyKontrahent);
            Messenger.Default.Register<TowaryForAllView>(this, addPozycja);
            setInfromation();
            Pozycje.CollectionChanged += Pozycje_CollectionChanged;
            _mapper = mapper;
        }
        #endregion

        #region Properties
        private readonly IMapper _mapper;
        public string NumerFaktury
        {
            get
            {
                return Item.NumerFaktury;
            }
            set
            {
                if (value != Item.NumerFaktury)
                {
                    Item.NumerFaktury = value;
                    base.OnPropertyChanged(() => NumerFaktury);
                }
            }
        }

        public int? IdKontrahenta
        {
            get
            {
                return Item.IdKontrahenta;
            }
            set
            {
                if (value != Item.IdKontrahenta)
                {
                    Item.IdKontrahenta = value;
                    base.OnPropertyChanged(() => IdKontrahenta);
                }
            }
        }

        private string _KontrahentNazwa;
        public string KontrahentNazwa
        {
            get
            {
                return _KontrahentNazwa;
            }

            set
            {
                if (value != _KontrahentNazwa)
                {
                    _KontrahentNazwa = value;
                    base.OnPropertyChanged(() => KontrahentNazwa);
                }
            }
        }

        private string _KontrahentAdres;
        public string KontrahentAdres
        {
            get
            {
                return _KontrahentAdres;
            }

            set
            {
                if (value != _KontrahentAdres)
                {
                    _KontrahentAdres = value;
                    base.OnPropertyChanged(() => KontrahentAdres);
                }
            }
        }

        public IQueryable<KeyAndValue> OddzialComboboxItems
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

        public int? IdOddzialu
        {
            get
            {
                return Item.IdOddzialu;
            }
            set
            {
                if (value != Item.IdOddzialu)
                {
                    Item.IdOddzialu = value;
                    MagazynNazwa = Db.Oddzial.Where(x => x.IdOddzialu == value).Select(oddzial => oddzial.Nazwa).Single();
                    base.OnPropertyChanged(() => IdOddzialu);
                }
            }
        }

        private string _MagazynNazwa;
        public string MagazynNazwa
        {
            get
            {
                return _MagazynNazwa;
            }

            set
            {
                if (value != _MagazynNazwa)
                {
                    _MagazynNazwa = value;
                    base.OnPropertyChanged(() => MagazynNazwa);
                }
            }
        }

        public DateTime DataWystawienia
        {
            get
            {
                return Item.DataWystawienia;
            }
            set
            {
                if (value != Item.DataWystawienia)
                {
                    Item.DataWystawienia = value;
                    base.OnPropertyChanged(() => DataWystawienia);
                }
            }
        }

        public DateTime? DataPrzyjecia
        {
            get
            {
                return Item.DataPrzyjecia;
            }
            set
            {
                if (value != Item.DataPrzyjecia)
                {
                    Item.DataPrzyjecia = value;
                    PoTerminie = ((DateTime)DataPrzyjecia - DataWystawienia).Days;
                    base.OnPropertyChanged(() => DataPrzyjecia);
                }
            }
        }

        public int? PoTerminie
        {
            get
            {
                return Item.PoTerminie;
            }
            set
            {
                if (value != Item.PoTerminie)
                {
                    Item.PoTerminie = value;
                    base.OnPropertyChanged(() => PoTerminie);
                }
            }
        }

        public IQueryable TypCenyComboboxItems
        {
            get
            {
                return Enum.GetValues(typeof(Tools.Constants.TypCeny)).AsQueryable();
            }
        }

        public string TypCeny
        {
            get
            {
                return Item.TypCeny;
            }
            set
            {
                if (value != Item.TypCeny)
                {
                    Item.TypCeny = value;
                    base.OnPropertyChanged(() => TypCeny);
                }
            }
        }


        public DateTime? DataPlatnosci
        {
            get
            {
                return Item.DataPlatnosci;
            }
            set
            {
                if (value != Item.DataPlatnosci)
                {
                    Item.DataPlatnosci = value;
                    base.OnPropertyChanged(() => DataPlatnosci);
                }
            }
        }

        public decimal? Zadluzenie
        {
            get
            {
                return Item.Zadluzenie;
            }
            set
            {
                if (value != Item.Zadluzenie)
                {
                    Item.Zadluzenie = value;
                    base.OnPropertyChanged(() => Zadluzenie);
                }
            }
        }

        public IQueryable<KeyAndValue> SposobPlatnosciComboboxItems
        {
            get
            {
                return Db.SposobPlatnosci
                    .Where(x => x.CzyAktywny == true)
                    .Select(sposob =>
                        new KeyAndValue
                        {
                            Key = sposob.IdSposobuPlatnosci,
                            Value = sposob.Nazwa
                        }
                    ).ToList().AsQueryable();
            }
        }

        public int IdSposobuPlatnosci
        {
            get
            {
                return Item.IdSposobuPlatnosci;
            }
            set
            {
                if (value != Item.IdSposobuPlatnosci)
                {
                    Item.IdSposobuPlatnosci = value;
                    base.OnPropertyChanged(() => IdSposobuPlatnosci);
                }
            }
        }

        public decimal? Netto
        {
            get
            {
                return Item.Netto;
            }
            set
            {
                if (value != Item.Netto)
                {
                    Item.Netto = value;
                    base.OnPropertyChanged(() => Netto);
                }
            }
        }

        public decimal? Brutto
        {
            get
            {
                return Item.Brutto;
            }
            set
            {
                if (value != Item.Brutto)
                {
                    Item.Brutto = value;
                    base.OnPropertyChanged(() => Brutto);
                }
            }
        }

        public decimal? Zaplacono
        {
            get
            {
                return Item.Zaplacono;
            }
            set
            {
                if (value != Item.Zaplacono)
                {
                    Item.Zaplacono = value;
                    Pozostalo = (Brutto - Zaplacono) >= 0 ? Brutto - Zaplacono : 0;
                    base.OnPropertyChanged(() => Zaplacono);
                }
            }
        }

        public decimal? Pozostalo
        {
            get
            {
                return Item.Pozostalo;
            }
            set
            {
                if (value != Item.Pozostalo)
                {
                    Item.Pozostalo = value;
                    base.OnPropertyChanged(() => Pozostalo);
                }
            }
        }

        public bool CzyPodzielonaPlatnosc
        {
            get
            {
                return Item.CzyPodzielonaPlatnosc;
            }
            set
            {
                if (value != Item.CzyPodzielonaPlatnosc)
                {
                    Item.CzyPodzielonaPlatnosc = value;
                    base.OnPropertyChanged(() => CzyPodzielonaPlatnosc);
                }
            }
        }

        public decimal? WartoscMPP
        {
            get
            {
                return Item.WartoscMPP;
            }
            set
            {
                if (value != Item.WartoscMPP)
                {
                    Item.WartoscMPP = value;
                    base.OnPropertyChanged(() => WartoscMPP);
                }
            }
        }

        private ObservableCollection<PozycjaFakturyForSpecialView> _Pozycje = new ObservableCollection<PozycjaFakturyForSpecialView>();
        public ObservableCollection<PozycjaFakturyForSpecialView> Pozycje
        {
            get
            {
                return _Pozycje;
            }
            set
            {
                if (value != _Pozycje)
                {
                    _Pozycje = value;
                    base.OnPropertyChanged(() => Pozycje);
                }
            }
        }

        public override string NazwaDodajacego
        {
            get
            {
                return Item.NazwaDodajacego;
            }
            set
            {
                if (value != Item.NazwaDodajacego)
                {
                    Item.NazwaDodajacego = value;
                    base.OnPropertyChanged(() => NazwaDodajacego);
                }
            }
        }

        public override DateTime? DataDodania
        {
            get
            {
                return Item.DataDodania;
            }
            set
            {
                if (value != Item.DataDodania)
                {
                    Item.DataDodania = value;
                    base.OnPropertyChanged(() => DataDodania);
                }
            }
        }

        public override string NazwaModyfikujacego
        {
            get
            {
                return Item.NazwaModyfikujacego;
            }
            set
            {
                if (value != Item.NazwaModyfikujacego)
                {
                    Item.NazwaModyfikujacego = value;
                    base.OnPropertyChanged(() => NazwaModyfikujacego);
                }
            }
        }

        public override DateTime? DataModyfikacji
        {
            get
            {
                return Item.DataModyfikacji;
            }
            set
            {
                if (value != Item.DataModyfikacji)
                {
                    Item.DataModyfikacji = value;
                    base.OnPropertyChanged(() => DataModyfikacji);
                }
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Db.Faktura.AddObject(Item);
            Db.SaveChanges();

            addPozycjaInfo(Item.IdFaktury);
            foreach (var pozycja in _Pozycje)
            {
                var pozycjaDb = _mapper.Map<PozycjaFaktury>(pozycja);
                Db.PozycjaFaktury.AddObject(pozycjaDb);
            }

            Db.SaveChanges();
        }

        private void getWybranyKontrahent(KontrahentForAllView kontrahent)
        {
            IdKontrahenta = kontrahent.IdKontrahenta;
            KontrahentNazwa = kontrahent.Nazwa;
            KontrahentAdres = kontrahent.KontrahentAdres;
        }

        private void addPozycjaInfo(int idFaktury)
        {
            foreach(var pozycja in _Pozycje)
            {
                pozycja.DataDodania = DateTime.Now.Date;
                pozycja.NazwaDodajacego = Environment.UserName;
                pozycja.CzyAktywna = true;
                pozycja.IdFaktury = idFaktury;
                pozycja.Wartosc = pozycja.ObliczonaWartosc;
            }
        }

        private void addPozycja(TowaryForAllView towar)
        {
            var pozycja = _mapper.Map<PozycjaFakturyForSpecialView>(towar);
            pozycja.NazwaTowaru = towar.Nazwa;
            pozycja.CenaPoczatkowa = (decimal)towar.Cena;
            pozycja.Ilosc = 1;
            pozycja.Cena = (decimal)towar.Cena;

            _Pozycje.Add(pozycja);
        }

        private void setInfromation()
        {
            DataWystawienia = DateTime.Now.Date;
            SetAddedInformation();
        }

        private void Pozycje_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (PozycjaFakturyForSpecialView pozycja in e.NewItems)
                {
                    pozycja.PropertyChanged += PozycjaFaktury_PropertyChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (PozycjaFakturyForSpecialView pozycja in e.OldItems)
                {
                    pozycja.PropertyChanged -= PozycjaFaktury_PropertyChanged;
                }
            }

            zmienCeny();
        }

        private void PozycjaFaktury_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            zmienCeny();
        }


        private void zmienCeny()
        {
            decimal netto = 0;
            decimal brutto = 0;
            foreach (PozycjaFakturyForSpecialView pozycja in Pozycje)
            {
                netto += pozycja.CenaNetto * pozycja.Ilosc;
                brutto += pozycja.CenaPoczatkowa * pozycja.Ilosc;
                pozycja.ObliczonaWartosc = pozycja.CenaPoczatkowa * pozycja.Ilosc;
            }

            Netto = netto;
            Brutto = brutto;
        }
        #endregion

        #region Validation
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string name]
        {
            get
            {
                string komunikat = null;
                if (name == "NumerFaktury")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(NumerFaktury);
                }

                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["NumerFaktury"] == null)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
