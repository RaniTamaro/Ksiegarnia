using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class NowyPracownikViewModel : NowyElementViewModel<Pracownik>
    {
        #region Konstruktor

        public NowyPracownikViewModel()
            :base(GlobalResources.PracodwnikDodaj)
        {
            Item = new Pracownik();
        }
        #endregion

        #region Properties
        public string Aktonim
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
                    base.OnPropertyChanged(() => Aktonim);
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

        public DateTime DataUrodzenia
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

        public int IdAdresu1
        {
            get
            {
                return Item.IdAdresu1;
            }
            set
            {
                if (value != Item.IdAdresu1)
                {
                    Item.IdAdresu1 = value;
                    base.OnPropertyChanged(() => IdAdresu1);
                }
            }
        }

        public int? IdAdresu2
        {
            get
            {
                return Item.IdAdresu2;
            }
            set
            {
                if (value != Item.IdAdresu2)
                {
                    Item.IdAdresu2 = value;
                    base.OnPropertyChanged(() => IdAdresu2);
                }
            }
        }

        public DateTime DataZatrudnienia
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

        public decimal? WspolczynnikKosztow
        {
            get
            {
                return Item.WspolczynnikKosztow;
            }
            set
            {
                if (value != Item.WspolczynnikKosztow)
                {
                    Item.WspolczynnikKosztow = value;
                    base.OnPropertyChanged(() => WspolczynnikKosztow);
                }
            }
        }

        public decimal? WspolczynnikUlgi
        {
            get
            {
                return Item.WspolczynnikUlgi;
            }
            set
            {
                if (value != Item.WspolczynnikUlgi)
                {
                    Item.WspolczynnikUlgi = value;
                    base.OnPropertyChanged(() => WspolczynnikUlgi);
                }
            }
        }

        public string KodPracy
        {
            get
            {
                return Item.KodPracy;
            }
            set
            {
                if (value != Item.KodPracy)
                {
                    Item.KodPracy = value;
                    base.OnPropertyChanged(() => KodPracy);
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

        public string RodzajUmowy
        {
            get
            {
                return Item.RodzajUmowy;
            }
            set
            {
                if (value != Item.RodzajUmowy)
                {
                    Item.RodzajUmowy = value;
                    base.OnPropertyChanged(() => RodzajUmowy);
                }
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Item.NazwaDodajacego = Environment.UserName;
            Db.Pracownik.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
