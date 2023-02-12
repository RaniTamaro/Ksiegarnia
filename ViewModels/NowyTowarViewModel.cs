using Firma.Helpers;
using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using Firma.Models.Validators;
using Firma.Tools.Constants;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Firma.ViewModels
{
    public class NowyTowarViewModel : NowyElementViewModel<Towar>, IDataErrorInfo
    {
        #region Command
        private BaseCommand _ShowWydawcyCommand;
        public ICommand ShowWydawcyCommand
        {
            get
            {
                if (_ShowWydawcyCommand == null)
                {
                    _ShowWydawcyCommand = new BaseCommand(() => showWydawcy());
                }

                return _ShowWydawcyCommand;
            }
        }

        private BaseCommand _ShowGrupyCommand;
        public ICommand ShowGrupyCommand
        {
            get
            {
                if (_ShowGrupyCommand == null)
                {
                    _ShowGrupyCommand = new BaseCommand(() => showGrupy());
                }

                return _ShowGrupyCommand;
            }
        }

        private void showWydawcy()
        {
            Messenger.Default.Send("WydawcyAll");
        }

        private void showGrupy()
        {
            Messenger.Default.Send("GrupyAll");
        }
        #endregion

        #region Konstruktor
        public NowyTowarViewModel()
            :base("Towar")
        {
            Item = new Towar();
            Messenger.Default.Register<Wydawca>(this, getWybranyWydawca);
            Messenger.Default.Register<Grupa>(this, getWybranaGrupa);
            setInformation();
        }
        #endregion

        #region Properties
        public string KodTowaru
        {
            get
            {
                return Item.KodTowaru;
            }
            set
            {
                if (value != Item.KodTowaru)
                {
                    Item.KodTowaru = value;
                    base.OnPropertyChanged(() => KodTowaru);
                }
            }
        }

        public string NrKatalogowy
        {
            get
            {
                return Item.NrKatalogowy;
            }
            set
            {
                if (value != Item.NrKatalogowy)
                {
                    Item.NrKatalogowy = value;
                    base.OnPropertyChanged(() => NrKatalogowy);
                }
            }
        }

        private string _GrupaNazwa;
        public string GrupaNazwa
        {
            get
            {
                return _GrupaNazwa;
            }

            set
            {
                if (value != _GrupaNazwa)
                {
                    _GrupaNazwa = value;
                    base.OnPropertyChanged(() => GrupaNazwa);
                }
            }
        }

        public int? IdGrupy
        {
            get
            {
                return Item.IdGrupy;
            }
            set
            {
                if (value != Item.IdGrupy)
                {
                    Item.IdGrupy = value;
                    base.OnPropertyChanged(() => IdGrupy);
                }
            }
        }

        public IQueryable<KeyAndValue> TypComboboxItems
        {
            get
            {
                return Db.Typ
                    .Where(x => x.CzyAktywny == true)
                    .Select(typ =>
                        new KeyAndValue
                        {
                            Key = typ.IdTypu,
                            Value = typ.Zlozonosc
                        }
                    ).ToList().AsQueryable();
            }
        }

        public int? IdTypu
        {
            get
            {
                return Item.IdTypu;
            }
            set
            {
                if (value != Item.IdTypu)
                {
                    Item.IdTypu = value;
                    base.OnPropertyChanged(() => IdTypu);
                }
            }
        }

        public string EAN
        {
            get
            {
                return Item.EAN;
            }
            set
            {
                if (value != Item.EAN)
                {
                    Item.EAN = value;
                    base.OnPropertyChanged(() => EAN);
                }
            }
        }

        public string PKWiU
        {
            get
            {
                return Item.PKWiU;
            }
            set
            {
                if (value != Item.PKWiU)
                {
                    Item.PKWiU = value;
                    base.OnPropertyChanged(() => PKWiU);
                }
            }
        }

        public IQueryable<KeyAndValue> StawkaVatComboboxItems
        {
            get
            {
                return Db.StawkaVat
                    .Where(x => x.CzyAktywna == true)
                    .Select(vat =>
                        new KeyAndValue
                        {
                            Key = vat.IdVat,
                            Value = SqlFunctions.StringConvert(vat.Stawka).Trim()+"%"
                        }
                    ).ToList().AsQueryable();
            }
        }

        public int? IdVat
        {
            get
            {
                return Item.IdVat;
            }
            set
            {
                if (value != Item.IdVat)
                {
                    Item.IdVat = value;
                    base.OnPropertyChanged(() => IdVat);
                }
            }
        }

        public string NazwaTowaru
        {
            get
            {
                return Item.NazwaTowaru;
            }
            set
            {
                if (value != Item.NazwaTowaru)
                {
                    Item.NazwaTowaru = value;
                    base.OnPropertyChanged(() => NazwaTowaru);
                }
            }
        }

        public IQueryable<KeyAndValue> KategoriaComboboxItems
        {
            get
            {
                return Db.KategoriaTowaru
                    .Where(x => x.CzyAktywny == true)
                    .Select(kategoria =>
                        new KeyAndValue
                        {
                            Key = kategoria.IdKategoriiTowaru,
                            Value = kategoria.Nazwa
                        }
                    ).ToList().AsQueryable();
            }
        }

        public int? IdKategoriiSprzedazy
        {
            get
            {
                return Item.IdKategoriiSprzedazy;
            }
            set
            {
                if (value != Item.IdKategoriiSprzedazy)
                {
                    Item.IdKategoriiSprzedazy = value;
                    base.OnPropertyChanged(() => IdKategoriiSprzedazy);
                }
            }
        }

        public int? IdKategoriiZakupu
        {
            get
            {
                return Item.IdKategoriiZakupu;
            }
            set
            {
                if (value != Item.IdKategoriiZakupu)
                {
                    Item.IdKategoriiZakupu = value;
                    base.OnPropertyChanged(() => IdKategoriiZakupu);
                }
            }
        }

        public string Url
        {
            get
            {
                return Item.Url;
            }
            set
            {
                if (value != Item.Url)
                {
                    Item.Url = value;
                    base.OnPropertyChanged(() => Url);
                }
            }
        }

        public string Opis
        {
            get
            {
                return Item.Opis;
            }
            set
            {
                if (value != Item.Opis)
                {
                    Item.Opis = value;
                    base.OnPropertyChanged(() => Opis);
                }
            }
        }

        public bool? KopiujOpis
        {
            get
            {
                return Item.KopiujOpis;
            }
            set
            {
                if (value != Item.KopiujOpis)
                {
                    Item.KopiujOpis = value;
                    base.OnPropertyChanged(() => KopiujOpis);
                }
            }
        }

        public bool? EdycjaNazwy
        {
            get
            {
                return Item.EdycjaNazwy;
            }
            set
            {
                if (value != Item.EdycjaNazwy)
                {
                    Item.EdycjaNazwy = value;
                    base.OnPropertyChanged(() => EdycjaNazwy);
                }
            }
        }

        public bool? EdycjaOpisu
        {
            get
            {
                return Item.EdycjaOpisu;
            }
            set
            {
                if (value != Item.EdycjaOpisu)
                {
                    Item.EdycjaOpisu = value;
                    base.OnPropertyChanged(() => EdycjaOpisu);
                }
            }
        }

        public int? IdWydawcy
        {
            get
            {
                return Item.IdWydawcy;
            }
            set
            {
                if (value != Item.IdWydawcy)
                {
                    Item.IdWydawcy = value;
                    base.OnPropertyChanged(() => IdWydawcy);
                }
            }
        }

        private string _WydawcaNazwa;
        public string WydawcaNazwa
        {
            get
            {
                return _WydawcaNazwa;
            }

            set
            {
                if (value != _WydawcaNazwa)
                {
                    _WydawcaNazwa = value;
                    base.OnPropertyChanged(() => WydawcaNazwa);
                }
            }
        }

        public string PLU
        {
            get
            {
                return Item.PLU;
            }
            set
            {
                if (value != Item.PLU)
                {
                    Item.PLU = value;
                    base.OnPropertyChanged(() => PLU);
                }
            }
        }

        public string NazwaUrzadzenia
        {
            get
            {
                return Item.NazwaUrzadzenia;
            }
            set
            {
                if (value != Item.NazwaUrzadzenia)
                {
                    Item.NazwaUrzadzenia = value;
                    base.OnPropertyChanged(() => NazwaUrzadzenia);
                }
            }
        }

        private ObservableCollection<Cena> _ListaCen = new ObservableCollection<Cena>();
        public ObservableCollection<Cena> ListaCen
        {
            get
            {
                return _ListaCen;
            }
            set
            {
                if (_ListaCen != value)
                {
                    _ListaCen = value;
                    liczCeny(_ListaCen);
                    base.OnPropertyChanged(() => ListaCen);
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
            Db.Towar.AddObject(Item);
            Db.SaveChanges();

            addIdTowaruCena(Item.IdTowaru);
            foreach(var cena in _ListaCen)
            {
                Db.Cena.AddObject(cena);
            }

            Db.SaveChanges();
        }

        private void getWybranyWydawca(Wydawca wydawca)
        {
            IdWydawcy = wydawca.IdWydawcy;
            WydawcaNazwa = wydawca.Nazwa;
        }

        private void getWybranaGrupa(Grupa grupa)
        {
            IdGrupy = grupa.IdGrupy;
            GrupaNazwa = grupa.Nazwa;
        }

        private void addIdTowaruCena(int idTowaru)
        {
            foreach(var cena in _ListaCen)
            {
                cena.IdTowaru = idTowaru;
            }
        }
        
        private void setInformation()
        {
            SetAddedInformation();
            KopiujOpis = false;
            EdycjaNazwy = false;
            EdycjaOpisu = false;
            createCeny();
        }

        private void createCeny()
        {
            _ListaCen.Add(new Cena 
            {
                Nazwa = NazwaCeny.CenaZakupu,
                TypCeny = "Netto",
                Zaokraglenie = 0.01m,
                Offset = 0,
                CenaNetto = 0,
                CenaBrutto = 0,
                Waluta = "PLN",
                CzyAktywny = true,
                NazwaDodajacego = Environment.UserName,
                DataDodania = DateTime.Now
            });

            _ListaCen.Add(new Cena
            {
                Nazwa = NazwaCeny.CenaHurtowa2,
                TypCeny = "Netto",
                Marza = 5,
                Zaokraglenie = 0.01m,
                Offset = 0,
                CenaNetto = 0,
                CenaBrutto = 0,
                Waluta = "PLN",
                CzyAktywny = true,
                NazwaDodajacego = Environment.UserName,
                DataDodania = DateTime.Now
            });

            _ListaCen.Add(new Cena
            {
                Nazwa = NazwaCeny.CenaHurtowa2,
                TypCeny = "Netto",
                Marza = 10,
                Zaokraglenie = 0.01m,
                Offset = 0,
                CenaNetto = 0,
                CenaBrutto = 0,
                Waluta = "PLN",
                CzyAktywny = true,
                NazwaDodajacego = Environment.UserName,
                DataDodania = DateTime.Now
            });

            _ListaCen.Add(new Cena
            {
                Nazwa = NazwaCeny.CenaDetaliczna,
                TypCeny = "Brutton",
                Marza = 15,
                Zaokraglenie = 0.01m,
                Offset = 0,
                CenaNetto = 0,
                CenaBrutto = 0,
                Waluta = "PLN",
                CzyAktywny = true,
                NazwaDodajacego = Environment.UserName,
                DataDodania = DateTime.Now
            });
        }

        private void liczCeny(IEnumerable<Cena> ceny)
        {
            foreach (var cena in ceny)
            {
                decimal notNullMarza = cena.Marza != null ? (decimal)cena.Marza : 0;

                if (cena.CenaNetto != 0 && notNullMarza != 0)
                {
                    cena.CenaBrutto = cena.CenaNetto * (notNullMarza / 100);
                }

                if (cena.CenaBrutto != 0 && notNullMarza != 0)
                {
                    cena.CenaNetto = cena.CenaBrutto * (1 + (notNullMarza) / 100);

                }
            }
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
                if (name == "NazwaTowaru")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(NazwaTowaru) == null ? StringValidator.SprawdzCzyZaczynaSieOdDuzej(NazwaTowaru) : BussinessValidator.SprawdzUzupelnienie(NazwaTowaru);
                }

                if (name == "KodTowaru")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(KodTowaru);
                }

                if (name == "EAN")
                {
                    komunikat = BussinessValidator.SprawdzUzupelnienie(EAN);
                }

                return komunikat;
            }
        }

        public override bool IsValid()
        {
            if (this["KodTowaru"] == null && this["EAN"] == null && this["NazwaTowaru"] == null)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
