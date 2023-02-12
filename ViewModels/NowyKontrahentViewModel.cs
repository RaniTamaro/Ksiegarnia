using Firma.Models.Entities;
using Firma.Models.Validators;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowyKontrahentViewModel : NowyElementViewModel<Kontrahent>, IDataErrorInfo
    {
        #region Konstruktor
        public NowyKontrahentViewModel()
            :base("Kontrahent")
        {
            Item = new Kontrahent();
            SetAddedInformation();
        }
        #endregion

        #region Properties
        public string Kod
        {
            get
            {
                return Item.Kod;
            }
            set
            {
                if (value != Item.Kod)
                {
                    Item.Kod = value;
                    base.OnPropertyChanged(() => Kod);
                }
            }
        }

        public string NIP
        {
            get
            {
                return Item.NIP;
            }
            set
            {
                if (value != Item.NIP)
                {
                    Item.NIP = value;
                    base.OnPropertyChanged(() => NIP);
                }
            }
        }

        public string PESEL
        {
            get
            {
                return Item.PESEL;
            }
            set
            {
                if (value != Item.PESEL)
                {
                    Item.PESEL = value;
                    base.OnPropertyChanged(() => PESEL);
                }
            }
        }

        public string Regon
        {
            get
            {
                return Item.Regon;
            }
            set
            {
                if (value != Item.Regon)
                {
                    Item.Regon = value;
                    base.OnPropertyChanged(() => Regon);
                }
            }
        }

        public string Nazwa
        {
            get
            {
                return Item.Nazwa;
            }
            set
            {
                if (value != Item.Nazwa)
                {
                    Item.Nazwa = value;
                    base.OnPropertyChanged(() => Nazwa);
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
        private Adres _Adres = new Adres();
        public string Kraj
        {
            get
            {
                return _Adres.Kraj;
            }
            set
            {
                if (value != _Adres.Kraj)
                {
                    _Adres.Kraj = value;
                    base.OnPropertyChanged(() => Kraj);
                }
            }
        }

        public string KodKraju
        {
            get
            {
                return _Adres.KodKraju;
            }
            set
            {
                if (value != _Adres.KodKraju)
                {
                    _Adres.KodKraju = value;
                    base.OnPropertyChanged(() => KodKraju);
                }
            }
        }

        public string Wojewodztwo
        {
            get
            {
                return _Adres.Wojewodztwo;
            }
            set
            {
                if (value != _Adres.Wojewodztwo)
                {
                    _Adres.Wojewodztwo = value;
                    base.OnPropertyChanged(() => Wojewodztwo);
                }
            }
        }

        public string Powiat
        {
            get
            {
                return _Adres.Powiat;
            }
            set
            {
                if (value != _Adres.Powiat)
                {
                    _Adres.Powiat = value;
                    base.OnPropertyChanged(() => Powiat);
                }
            }
        }

        public string Gmina
        {
            get
            {
                return _Adres.Gmina;
            }
            set
            {
                if (value != _Adres.Gmina)
                {
                    _Adres.Gmina = value;
                    base.OnPropertyChanged(() => Gmina);
                }
            }
        }

        public string Ulica
        {
            get
            {
                return _Adres.Ulica;
            }
            set
            {
                if (value != _Adres.Ulica)
                {
                    _Adres.Ulica = value;
                    base.OnPropertyChanged(() => Ulica);
                }
            }
        }

        public string NrDomu
        {
            get
            {
                return _Adres.NrDomu;
            }
            set
            {
                if (value != _Adres.NrDomu)
                {
                    _Adres.NrDomu = value;
                    base.OnPropertyChanged(() => NrDomu);
                }
            }
        }

        public string NrLokalu
        {
            get
            {
                return _Adres.NrLokalu;
            }
            set
            {
                if (value != _Adres.NrLokalu)
                {
                    _Adres.NrLokalu = value;
                    base.OnPropertyChanged(() => NrLokalu);
                }
            }
        }

        public string Miejscowosc
        {
            get
            {
                return _Adres.Miejscowosc;
            }
            set
            {
                if (value != _Adres.Miejscowosc)
                {
                    _Adres.Miejscowosc = value;
                    base.OnPropertyChanged(() => Miejscowosc);
                }
            }
        }

        public string KodPocztowy
        {
            get
            {
                return _Adres.KodPocztowy;
            }
            set
            {
                if (value != _Adres.KodPocztowy)
                {
                    _Adres.KodPocztowy = value;
                    base.OnPropertyChanged(() => KodPocztowy);
                }
            }
        }

        public string Poczta
        {
            get
            {
                return _Adres.Poczta;
            }
            set
            {
                if (value != _Adres.Poczta)
                {
                    _Adres.Poczta = value;
                    base.OnPropertyChanged(() => Poczta);
                }
            }
        }
        //Tu kończy się dodanie adresu

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
            if(_Adres.Miejscowosc != null)
            {
                _Adres.NazwaDodajacego = Environment.UserName;
                _Adres.CzyAktywny = true;
                Db.Adres.AddObject(_Adres);
                Db.SaveChanges();
                Item.Adres = _Adres;
            }

            _DaneKontaktowe.NazwaDodajacego = Environment.UserName;
            _DaneKontaktowe.CzyAktywny = true;
            Db.DaneKontaktowe.AddObject(_DaneKontaktowe);

            Item.DaneKontaktowe = _DaneKontaktowe;
            Item.CzyAktywny = true;
            Db.Kontrahent.AddObject(Item);
            Db.SaveChanges();
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
                if (name == "Kod")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(Kod);
                }

                if (name == "Nazwa")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(Nazwa) == null ? StringValidator.SprawdzCzyZaczynaSieOdDuzej(Nazwa) : BussinessValidator.SprawdzUzupelnienie(Nazwa);
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

                if (name == "Miejscowosc")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Miejscowosc);
                }

                if (name == "Kraj")
                {
                    komunikat = StringValidator.SprawdzCzyZaczynaSieOdDuzej(Kraj);
                }

                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["Kod"] == null && this["Nazwa"] == null)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
