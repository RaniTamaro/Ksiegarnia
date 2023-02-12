using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.Models.Validators;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class NowyPracownikViewModel : NowyElementViewModel<Pracownik>, IDataErrorInfo
    {
        #region Command
        private BaseCommand _ShowOddzialyCommand;
        public ICommand ShowOddzialyCommand
        {
            get
            {
                if (_ShowOddzialyCommand == null)
                {
                    _ShowOddzialyCommand = new BaseCommand(() => showOddzialy());
                }

                return _ShowOddzialyCommand;
            }
        }

        private void showOddzialy()
        {
            Messenger.Default.Send("OddziałyAll");
        }
        #endregion

        #region Konstruktor

        public NowyPracownikViewModel()
            :base(GlobalResources.PracodwnikDodaj)
        {
            Item = new Pracownik();
            setInformation();
            Messenger.Default.Register<Oddzial>(this, getWybranyOddzial);
        }
        #endregion

        #region Properties
        public string Akronim
        {
            get
            {
                return Item.Akronim;
            }
            set
            {
                if (value != Item.Akronim)
                {
                    Item.Akronim = value;
                    base.OnPropertyChanged(() => Akronim);
                }
            }
        }

        public string Imie
        {
            get
            {
                return Item.Imie;
            }
            set
            {
                if (value != Item.Imie)
                {
                    Item.Imie = value;
                    base.OnPropertyChanged(() => Imie);
                }
            }
        }

        public string Nazwisko
        {
            get
            {
                return Item.Nazwisko;
            }
            set
            {
                if (value != Item.Nazwisko)
                {
                    Item.Nazwisko = value;
                    base.OnPropertyChanged(() => Nazwisko);
                }
            }
        }

        public string DrugieImie
        {
            get
            {
                return Item.DrugieImie;
            }
            set
            {
                if (value != Item.DrugieImie)
                {
                    Item.DrugieImie = value;
                    base.OnPropertyChanged(() => DrugieImie);
                }
            }
        }

        public string PeselPracownika
        {
            get
            {
                return Item.PeselPracownika;
            }
            set
            {
                if (value != Item.PeselPracownika)
                {
                    Item.PeselPracownika = value;
                    base.OnPropertyChanged(() => PeselPracownika);
                }
            }
        }

        public string Nip
        {
            get
            {
                return Item.Nip;
            }
            set
            {
                if (value != Item.Nip)
                {
                    Item.Nip = value;
                    base.OnPropertyChanged(() => Nip);
                }
            }
        }

        public DateTime? DataUrodzenia
        {
            get
            {
                return Item.DataUrodzenia;
            }
            set
            {
                if (value != Item.DataUrodzenia)
                {
                    Item.DataUrodzenia = value;
                    base.OnPropertyChanged(() => DataUrodzenia);
                }
            }
        }

        public string MiejsceUrodzenia
        {
            get
            {
                return Item.MiejsceUrodzenia;
            }
            set
            {
                if (value != Item.MiejsceUrodzenia)
                {
                    Item.MiejsceUrodzenia = value;
                    base.OnPropertyChanged(() => MiejsceUrodzenia);
                }
            }
        }

        public string ImieOjca
        {
            get
            {
                return Item.ImieOjca;
            }
            set
            {
                if (value != Item.ImieOjca)
                {
                    Item.ImieOjca = value;
                    base.OnPropertyChanged(() => ImieOjca);
                }
            }
        }

        public string ImieMatki
        {
            get
            {
                return Item.ImieMatki;
            }
            set
            {
                if (value != Item.ImieMatki)
                {
                    Item.ImieMatki = value;
                    base.OnPropertyChanged(() => ImieMatki);
                }
            }
        }

        public string NazwiskoRodowe
        {
            get
            {
                return Item.NazwiskoRodowe;
            }
            set
            {
                if (value != Item.NazwiskoRodowe)
                {
                    Item.NazwiskoRodowe = value;
                    base.OnPropertyChanged(() => NazwiskoRodowe);
                }
            }
        }

        public string NazwiskoRodoweMatki
        {
            get
            {
                return Item.NazwiskoRodoweMatki;
            }
            set
            {
                if (value != Item.NazwiskoRodoweMatki)
                {
                    Item.NazwiskoRodoweMatki = value;
                    base.OnPropertyChanged(() => NazwiskoRodoweMatki);
                }
            }
        }

        //Tu jest dodanie danych kontaktowych
        private DaneKontaktowe _DaneKontaktowe = new DaneKontaktowe();
        public string TelefonKomorkowy
        {
            get
            {
                return _DaneKontaktowe.TelefonKomorkowy;
            }
            set
            {
                if (value != _DaneKontaktowe.TelefonKomorkowy)
                {
                    _DaneKontaktowe.TelefonKomorkowy = value;
                    base.OnPropertyChanged(() => TelefonKomorkowy);
                }
            }
        }

        public string TelefonDomowy
        {
            get
            {
                return _DaneKontaktowe.TelefonDomowy;
            }
            set
            {
                if (value != _DaneKontaktowe.TelefonDomowy)
                {
                    _DaneKontaktowe.TelefonDomowy = value;
                    base.OnPropertyChanged(() => TelefonDomowy);
                }
            }
        }

        public string Email1
        {
            get
            {
                return _DaneKontaktowe.Email1;
            }
            set
            {
                if (value != _DaneKontaktowe.Email1)
                {
                    _DaneKontaktowe.Email1 = value;
                    base.OnPropertyChanged(() => Email1);
                }
            }
        }

        public string Email2
        {
            get
            {
                return _DaneKontaktowe.Email2;
            }
            set
            {
                if (value != _DaneKontaktowe.Email2)
                {
                    _DaneKontaktowe.Email2 = value;
                    base.OnPropertyChanged(() => Email2);
                }
            }
        }

        public string AdresStrony
        {
            get
            {
                return _DaneKontaktowe.AdresStrony;
            }
            set
            {
                if (value != _DaneKontaktowe.AdresStrony)
                {
                    _DaneKontaktowe.AdresStrony = value;
                    base.OnPropertyChanged(() => AdresStrony);
                }
            }
        }
        //Tu kończy się dodanie danych kontaktowych

        //Tu jest dodanie adresu
        private Adres _AdresZameldowania = new Adres();
        public string Kraj
        {
            get
            {
                return _AdresZameldowania.Kraj;
            }
            set
            {
                if (value != _AdresZameldowania.Kraj)
                {
                    _AdresZameldowania.Kraj = value;
                    base.OnPropertyChanged(() => Kraj);
                }
            }
        }

        public string KodKraju
        {
            get
            {
                return _AdresZameldowania.KodKraju;
            }
            set
            {
                if (value != _AdresZameldowania.KodKraju)
                {
                    _AdresZameldowania.KodKraju = value;
                    base.OnPropertyChanged(() => KodKraju);
                }
            }
        }

        public string Wojewodztwo
        {
            get
            {
                return _AdresZameldowania.Wojewodztwo;
            }
            set
            {
                if (value != _AdresZameldowania.Wojewodztwo)
                {
                    _AdresZameldowania.Wojewodztwo = value;
                    base.OnPropertyChanged(() => Wojewodztwo);
                }
            }
        }

        public string Powiat
        {
            get
            {
                return _AdresZameldowania.Powiat;
            }
            set
            {
                if (value != _AdresZameldowania.Powiat)
                {
                    _AdresZameldowania.Powiat = value;
                    base.OnPropertyChanged(() => Powiat);
                }
            }
        }

        public string Gmina
        {
            get
            {
                return _AdresZameldowania.Gmina;
            }
            set
            {
                if (value != _AdresZameldowania.Gmina)
                {
                    _AdresZameldowania.Gmina = value;
                    base.OnPropertyChanged(() => Gmina);
                }
            }
        }

        public string Ulica
        {
            get
            {
                return _AdresZameldowania.Ulica;
            }
            set
            {
                if (value != _AdresZameldowania.Ulica)
                {
                    _AdresZameldowania.Ulica = value;
                    base.OnPropertyChanged(() => Ulica);
                }
            }
        }

        public string NrDomu
        {
            get
            {
                return _AdresZameldowania.NrDomu;
            }
            set
            {
                if (value != _AdresZameldowania.NrDomu)
                {
                    _AdresZameldowania.NrDomu = value;
                    base.OnPropertyChanged(() => NrDomu);
                }
            }
        }

        public string NrLokalu
        {
            get
            {
                return _AdresZameldowania.NrLokalu;
            }
            set
            {
                if (value != _AdresZameldowania.NrLokalu)
                {
                    _AdresZameldowania.NrLokalu = value;
                    base.OnPropertyChanged(() => NrLokalu);
                }
            }
        }

        public string Miejscowosc
        {
            get
            {
                return _AdresZameldowania.Miejscowosc;
            }
            set
            {
                if (value != _AdresZameldowania.Miejscowosc)
                {
                    _AdresZameldowania.Miejscowosc = value;
                    base.OnPropertyChanged(() => Miejscowosc);
                }
            }
        }

        public string KodPocztowy
        {
            get
            {
                return _AdresZameldowania.KodPocztowy;
            }
            set
            {
                if (value != _AdresZameldowania.KodPocztowy)
                {
                    _AdresZameldowania.KodPocztowy = value;
                    base.OnPropertyChanged(() => KodPocztowy);
                }
            }
        }

        public string Poczta
        {
            get
            {
                return _AdresZameldowania.Poczta;
            }
            set
            {
                if (value != _AdresZameldowania.Poczta)
                {
                    _AdresZameldowania.Poczta = value;
                    base.OnPropertyChanged(() => Poczta);
                }
            }
        }
        //Tu kończy się dodanie adresu

        //Tu jest dodanie adresu zamieszkania
        private Adres _AdresZamieszkania = new Adres();
        public string Kraj2
        {
            get
            {
                return _AdresZamieszkania.Kraj;
            }
            set
            {
                if (value != _AdresZamieszkania.Kraj)
                {
                    _AdresZamieszkania.Kraj = value;
                    base.OnPropertyChanged(() => Kraj2);
                }
            }
        }

        public string KodKraju2
        {
            get
            {
                return _AdresZamieszkania.KodKraju;
            }
            set
            {
                if (value != _AdresZamieszkania.KodKraju)
                {
                    _AdresZamieszkania.KodKraju = value;
                    base.OnPropertyChanged(() => KodKraju2);
                }
            }
        }

        public string Wojewodztwo2
        {
            get
            {
                return _AdresZamieszkania.Wojewodztwo;
            }
            set
            {
                if (value != _AdresZamieszkania.Wojewodztwo)
                {
                    _AdresZamieszkania.Wojewodztwo = value;
                    base.OnPropertyChanged(() => Wojewodztwo2);
                }
            }
        }

        public string Powiat2
        {
            get
            {
                return _AdresZamieszkania.Powiat;
            }
            set
            {
                if (value != _AdresZamieszkania.Powiat)
                {
                    _AdresZamieszkania.Powiat = value;
                    base.OnPropertyChanged(() => Powiat2);
                }
            }
        }

        public string Gmina2
        {
            get
            {
                return _AdresZamieszkania.Gmina;
            }
            set
            {
                if (value != _AdresZamieszkania.Gmina)
                {
                    _AdresZamieszkania.Gmina = value;
                    base.OnPropertyChanged(() => Gmina2);
                }
            }
        }

        public string Ulica2
        {
            get
            {
                return _AdresZamieszkania.Ulica;
            }
            set
            {
                if (value != _AdresZamieszkania.Ulica)
                {
                    _AdresZamieszkania.Ulica = value;
                    base.OnPropertyChanged(() => Ulica2);
                }
            }
        }

        public string NrDomu2
        {
            get
            {
                return _AdresZamieszkania.NrDomu;
            }
            set
            {
                if (value != _AdresZamieszkania.NrDomu)
                {
                    _AdresZamieszkania.NrDomu = value;
                    base.OnPropertyChanged(() => NrDomu2);
                }
            }
        }

        public string NrLokalu2
        {
            get
            {
                return _AdresZamieszkania.NrLokalu;
            }
            set
            {
                if (value != _AdresZamieszkania.NrLokalu)
                {
                    _AdresZamieszkania.NrLokalu = value;
                    base.OnPropertyChanged(() => NrLokalu2);
                }
            }
        }

        public string Miejscowosc2
        {
            get
            {
                return _AdresZamieszkania.Miejscowosc;
            }
            set
            {
                if (value != _AdresZamieszkania.Miejscowosc)
                {
                    _AdresZamieszkania.Miejscowosc = value;
                    base.OnPropertyChanged(() => Miejscowosc2);
                }
            }
        }

        public string KodPocztowy2
        {
            get
            {
                return _AdresZamieszkania.KodPocztowy;
            }
            set
            {
                if (value != _AdresZamieszkania.KodPocztowy)
                {
                    _AdresZamieszkania.KodPocztowy = value;
                    base.OnPropertyChanged(() => KodPocztowy2);
                }
            }
        }

        public string Poczta2
        {
            get
            {
                return _AdresZamieszkania.Poczta;
            }
            set
            {
                if (value != _AdresZamieszkania.Poczta)
                {
                    _AdresZamieszkania.Poczta = value;
                    base.OnPropertyChanged(() => Poczta2);
                }
            }
        }
        //Tu kończy się dodanie adresu

        public DateTime? DataZatrudnienia
        {
            get
            {
                return Item.DataZatrudnienia;
            }
            set
            {
                if (value != Item.DataZatrudnienia)
                {
                    Item.DataZatrudnienia = value;
                    base.OnPropertyChanged(() => DataZatrudnienia);
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

        public int? IdSposobuPlatnosci
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

        public string UrzadSkarbowy
        {
            get
            {
                return Item.UrzadSkarbowy;
            }
            set
            {
                if (value != Item.UrzadSkarbowy)
                {
                    Item.UrzadSkarbowy = value;
                    base.OnPropertyChanged(() => UrzadSkarbowy);
                }
            }
        }

        public IQueryable<KeyAndValue> KategoriaComboboxItems
        {
            get
            {
                return Db.KategoriaPracy
                    .Where(x => x.CzyAktywny == true)
                    .Select(kategoria =>
                        new KeyAndValue
                        {
                            Key = kategoria.IdKategoriiPracy,
                            Value = kategoria.NazwaDzialu
                        }
                    ).ToList().AsQueryable();
            }
        }

        public int? IdKategoriiPracy
        {
            get
            {
                return Item.IdKategoriiPracy;
            }
            set
            {
                if (value != Item.IdKategoriiPracy)
                {
                    Item.IdKategoriiPracy = value;
                    base.OnPropertyChanged(() => IdKategoriiPracy);
                }
            }
        }

        public decimal? Stawka
        {
            get
            {
                return Item.Stawka;
            }
            set
            {
                if (value != Item.Stawka)
                {
                    Item.Stawka = value;
                    base.OnPropertyChanged(() => Stawka);
                }
            }
        }

        public IQueryable RodzajUmowyComboboxItems
        {
            get
            {
                return Db.RodzajUmowy
                    .Where(x => x.CzyAktywny == true)
                    .Select(umowa => 
                        new KeyAndValue
                        {
                            Key = umowa.IdRodzajuUmowy,
                            Value = umowa.Nazwa
                        }
                    )
                    .ToList().AsQueryable();
            }
        }

        public int? IdRodzajUmowy
        {
            get
            {
                return Item.IdRodzajUmowy;
            }
            set
            {
                if (value != Item.IdRodzajUmowy)
                {
                    Item.IdRodzajUmowy = value;
                    base.OnPropertyChanged(() => IdRodzajUmowy);
                }
            }
        }

        private RachunekBankowy _RachunekBankowy = new RachunekBankowy();
        public string NazwaBanku
        {
            get
            {
                return _RachunekBankowy.NazwaBanku;

            }
            set
            {
                if (value != _RachunekBankowy.NazwaBanku)
                {
                    _RachunekBankowy.NazwaBanku = value;
                    base.OnPropertyChanged(() => NazwaBanku);
                }
            }
        }

        public string NumerRachunku
        {
            get
            {
                return _RachunekBankowy.NumerRachunku;

            }
            set
            {
                if (value != _RachunekBankowy.NumerRachunku)
                {
                    _RachunekBankowy.NumerRachunku = value;
                    base.OnPropertyChanged(() => NumerRachunku);
                }
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
                    base.OnPropertyChanged(() => IdOddzialu);
                }
            }
        }

        private string _OddzialNazwa;
        public string OddzialNazwa
        {
            get
            {
                return _OddzialNazwa;
            }

            set
            {
                if (value != _OddzialNazwa)
                {
                    _OddzialNazwa = value;
                    base.OnPropertyChanged(() => OddzialNazwa);
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

            if (_AdresZameldowania.Miejscowosc != null)
            {
                _AdresZameldowania.NazwaDodajacego = Environment.UserName;
                _AdresZameldowania.CzyAktywny = true;
                Db.Adres.AddObject(_AdresZameldowania);
                Item.Adres = _AdresZameldowania;
            }

            if (_AdresZamieszkania.Miejscowosc != null)
            {
                _AdresZamieszkania.NazwaDodajacego = Environment.UserName;
                _AdresZamieszkania.CzyAktywny = true;
                Db.Adres.AddObject(_AdresZamieszkania);
                Item.Adres1 = _AdresZamieszkania;
            }

            _DaneKontaktowe.NazwaDodajacego = Environment.UserName;
            _DaneKontaktowe.CzyAktywny = true;
            Db.DaneKontaktowe.AddObject(_DaneKontaktowe);

            _RachunekBankowy.NazwaDodajacego = Environment.UserName;
            _RachunekBankowy.CzyAktywny = true;
            Db.RachunekBankowy.AddObject(_RachunekBankowy);

            Item.DaneKontaktowe = _DaneKontaktowe;
            Item.RachunekBankowy = _RachunekBankowy;
            Item.CzyAktywny = true;
            Db.Pracownik.AddObject(Item);
            Db.SaveChanges();
        }

        private void getWybranyOddzial(Oddzial oddzial)
        {
            IdOddzialu = oddzial.IdOddzialu;
            OddzialNazwa = oddzial.Nazwa + " " + oddzial.Adres.Ulica + " " + oddzial.Adres.NrDomu + " " + oddzial.Adres.Miejscowosc;
        }

        private void setInformation()
        {
            DataUrodzenia = DateTime.Now.Date;
            DataZatrudnienia = DateTime.Now.Date;
            SetAddedInformation();
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
                if (name == "Akronim")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(Akronim);
                }

                if (name == "Imie")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(Imie) == null ? StringValidator.SprawdzCzyZaczynaSieOdDuzej(Imie) : BussinessValidator.SprawdzUzupelnienie(Imie);
                }

                if (name == "Nazwisko")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(Nazwisko) == null ? StringValidator.SprawdzCzyZaczynaSieOdDuzej(Nazwisko) : BussinessValidator.SprawdzUzupelnienie(Nazwisko);
                }

                if (name == "DrugieImie")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(DrugieImie);
                }

                if (name == "PeselPracownika")
                {
                    komunikat = BussinessValidator.PeselValidator(PeselPracownika);
                }

                if (name == "ImieOjca")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(ImieOjca);
                }

                if (name == "ImieMatki")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(ImieMatki);
                }

                if (name == "NazwiskoRodowe")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(NazwiskoRodowe);
                }

                if (name == "NazwiskoRodoweMatki")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(NazwiskoRodoweMatki);
                }

                if (name == "Email1")
                {
                    komunikat = StringValidator.SprawdzEmail(Email1);
                }

                if (name == "Email2")
                {
                    komunikat = StringValidator.SprawdzEmail(Email2);
                }

                if (name == "AdresStrony")
                {
                    komunikat = StringValidator.SprawdzAdresWWW(AdresStrony);
                }

                if (name == "MiejsceUrodzenia")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(MiejsceUrodzenia);
                }

                if (name == "Miejscowosc")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Miejscowosc);
                }

                if (name == "Miejscowosc2")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Miejscowosc2);
                }

                if (name == "Kraj")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Kraj);
                }

                if (name == "Kraj2")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Kraj2);
                }

                if (name == "Stawka")
                {
                    komunikat = BussinessValidator.SprawdzNieujemnosc(Stawka);
                }

                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["Akronim"] == null && this["Imie"] == null && this["Nazwisko"] == null)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
