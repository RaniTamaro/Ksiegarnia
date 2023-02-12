using AutoMapper;
using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForSpecialView;
using Firma.Models.EntitiesForView;
using Firma.Models.Validators;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels.Abstract
{
    public abstract class NowaAkcjaMagazynowaViewModel : NowyElementViewModel<Magazyn>, IDataErrorInfo
    {
        #region Command
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

        private void showTowary()
        {
            Messenger.Default.Send("TowaryAll");
        }
        #endregion

        #region Konstruktor
        public NowaAkcjaMagazynowaViewModel(string displayName, IMapper mapper)
            : base(displayName)
        {
            Item = new Magazyn();
            Messenger.Default.Register<TowaryForAllView>(this, addPozycja);
            setInformation();
            Pozycje.CollectionChanged += Pozycje_CollectionChanged;
            _mapper = mapper;
        }
        #endregion

        #region Properties
        private readonly IMapper _mapper;
        public abstract IQueryable<KeyAndValue> RodzajDokumentuComboboxItems { get; }
       
        public int IdRodzajuDokumentu
        {
            get
            {
                return Item.IdRodzajuDokumentu;
            }
            set
            {
                if (value != Item.IdRodzajuDokumentu)
                {
                    Item.IdRodzajuDokumentu = value;
                    var prefix = Db.RodzajDokumentu.Where(x => x.IdRodzajuDokumentu == value).Single();
                    NumerPrefix = prefix.Kod;
                    base.OnPropertyChanged(() => IdRodzajuDokumentu);
                }
            }
        }

        private string _NumerPrefix;
        public string NumerPrefix
        {
            get
            {
                return _NumerPrefix;
            }
            set
            {
                if (value != _NumerPrefix)
                {
                    _NumerPrefix = value;
                    base.OnPropertyChanged(() => NumerPrefix);
                }
            }
        }

        public string NumerGlowny
        {
            get
            {
                return Item.NumerGlowny;
            }
            set
            {
                if (value != Item.NumerGlowny)
                {
                    Item.NumerGlowny = value;
                    base.OnPropertyChanged(() => NumerGlowny);
                }
            }
        }

        public string NumerRok
        {
            get
            {
                return Item.NumerRok;
            }
            set
            {
                if (value != Item.NumerRok)
                {
                    Item.NumerRok = DateTime.Now.Year.ToString();
                    base.OnPropertyChanged(() => NumerRok);
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
                    var magazyn = Db.Oddzial.Where(x => x.IdOddzialu == value).Single();
                    MagazynNazwa = magazyn.Nazwa + " " + magazyn.Adres.Ulica + " " + magazyn.Adres.NrDomu + " " + magazyn.Adres.Miejscowosc;
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

        public string NumerObcy
        {
            get
            {
                return Item.NumerObcy;
            }
            set
            {
                if (value != Item.NumerObcy)
                {
                    Item.NumerObcy = value;
                    base.OnPropertyChanged(() => NumerObcy);
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

        public DateTime? DataWplywu
        {
            get
            {
                return Item.DataWplywu;
            }
            set
            {
                if (value != Item.DataWplywu)
                {
                    Item.DataWplywu = value;
                    base.OnPropertyChanged(() => DataWplywu);
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
                    base.OnPropertyChanged(() => DataPrzyjecia);
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

        public decimal Netto
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

        public decimal Razem
        {
            get
            {
                return Item.Razem;
            }
            set
            {
                if (value != Item.Razem)
                {
                    Item.Razem = value;
                    base.OnPropertyChanged(() => Razem);
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

        private ObservableCollection<PozycjaMagazynuForSpecialView> _Pozycje = new ObservableCollection<PozycjaMagazynuForSpecialView>();
        public ObservableCollection<PozycjaMagazynuForSpecialView> Pozycje
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
            Item.NumerGlowny = NumerPrefix.Trim() + NumerGlowny;
            Db.Magazyn.AddObject(Item);
            Db.SaveChanges();

            addPozycjaInfo(Item.IdMagazynu);
            foreach (var pozycja in _Pozycje)
            {
                var pozycjaDb = _mapper.Map<PozycjaMagazynu>(pozycja);
                Db.PozycjaMagazynu.AddObject(pozycjaDb);
            }

            Db.SaveChanges();
        }

        private void setInformation()
        {
            DataWystawienia = DateTime.Now;
            NumerRok = DateTime.Now.Year.ToString();
            SetAddedInformation();
        }

        private void addPozycjaInfo(int idMagazynu)
        {
            foreach (var pozycja in _Pozycje)
            {   
                pozycja.DataDodania = DateTime.Now.Date;
                pozycja.NazwaDodajacego = Environment.UserName;
                pozycja.CzyAktywny = true;
                pozycja.IdMagazynu = idMagazynu;
                pozycja.Wartosc = pozycja.ObliczonaWartosc;
            }
        }

        private void addPozycja(TowaryForAllView towar)
        {
            var pozycja = _mapper.Map<PozycjaMagazynuForSpecialView>(towar);
            pozycja.CenaPoczatkowa = (decimal)towar.Cena;
            pozycja.Ilosc = 1;
            pozycja.Cena = (decimal)towar.Cena;

            _Pozycje.Add(pozycja);
        }

        private void Pozycje_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (PozycjaMagazynuForSpecialView pozycja in e.NewItems)
                {
                    pozycja.PropertyChanged += PozycjaFaktury_PropertyChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (PozycjaMagazynuForSpecialView pozycja in e.OldItems)
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
            foreach (PozycjaMagazynuForSpecialView pozycja in Pozycje)
            {
                netto += pozycja.CenaNetto * pozycja.Ilosc;
                brutto += pozycja.CenaPoczatkowa * pozycja.Ilosc;
                pozycja.ObliczonaWartosc = pozycja.CenaPoczatkowa * pozycja.Ilosc;
            }

            Netto = netto;
            Razem = brutto;
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
                if (name == "NumerGlowny")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(NumerGlowny);
                }

                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["NumerGlowny"] == null)
            {
                return true;
            }

            return false;
        }
#endregion
    }
}
