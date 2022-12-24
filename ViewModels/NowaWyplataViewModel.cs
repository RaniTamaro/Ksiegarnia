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
    public class NowaWyplataViewModel : NowyElementViewModel<Wyplata>
    {
        #region Konstruktor
        public NowaWyplataViewModel()
            :base(GlobalResources.Wyplata)
        {
            Item = new Wyplata();
        }
        #endregion

        #region Properties
        public string TytulPrzelewu
        {
            get
            {
                return Item.TytulPrzelewu;
            }
            set
            {
                if (value != Item.TytulPrzelewu)
                {
                    Item.TytulPrzelewu = value;
                    base.OnPropertyChanged(() => TytulPrzelewu);
                }
            }
        }

        public string Skrot
        {
            get
            {
                return Item.Skrot;
            }
            set
            {
                if (value != Item.Skrot)
                {
                    Item.Skrot = value;
                    base.OnPropertyChanged(() => Skrot);
                }
            }
        }

        public bool? Potracenie
        {
            get
            {
                return Item.Potracenie;
            }
            set
            {
                if (value != Item.Potracenie)
                {
                    Item.Potracenie = value;
                    base.OnPropertyChanged(() => Potracenie);
                }
            }
        }

        public bool? PrzychodPPK
        {
            get
            {
                return Item.PrzychodPPK;
            }
            set
            {
                if (value != Item.PrzychodPPK)
                {
                    Item.PrzychodPPK = value;
                    base.OnPropertyChanged(() => PrzychodPPK);
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

        public decimal? ProcentWynagrodzenia
        {
            get
            {
                return Item.ProcentWynagrodzenia;
            }
            set
            {
                if (value != Item.ProcentWynagrodzenia)
                {
                    Item.ProcentWynagrodzenia = value;
                    base.OnPropertyChanged(() => ProcentWynagrodzenia);
                }
            }
        }

        public string RodzajWynagrodzenia
        {
            get
            {
                return Item.RodzajWynagrodzenia;
            }
            set
            {
                if (value != Item.RodzajWynagrodzenia)
                {
                    Item.RodzajWynagrodzenia = value;
                    base.OnPropertyChanged(() => RodzajWynagrodzenia);
                }
            }
        }

        public bool? AutomatyczneKorygowanie
        {
            get
            {
                return Item.AutomatyczneKorygowanie;
            }
            set
            {
                if (value != Item.AutomatyczneKorygowanie)
                {
                    Item.AutomatyczneKorygowanie = value;
                    base.OnPropertyChanged(() => AutomatyczneKorygowanie);
                }
            }
        }

        public bool? Urlop
        {
            get
            {
                return Item.Urlop;
            }
            set
            {
                if (value != Item.Urlop)
                {
                    Item.Urlop = value;
                    base.OnPropertyChanged(() => Urlop);
                }
            }
        }

        public bool? ZwolnienieLekarskie
        {
            get
            {
                return Item.ZwolnienieLekarskie;
            }
            set
            {
                if (value != Item.ZwolnienieLekarskie)
                {
                    Item.ZwolnienieLekarskie = value;
                    base.OnPropertyChanged(() => ZwolnienieLekarskie);
                }
            }
        }

        public bool? NieobecnoscUsprawiedliwiona
        {
            get
            {
                return Item.NieobecnoscUsprawiedliwiona;
            }
            set
            {
                if (value != Item.NieobecnoscUsprawiedliwiona)
                {
                    Item.NieobecnoscUsprawiedliwiona = value;
                    base.OnPropertyChanged(() => NieobecnoscUsprawiedliwiona);
                }
            }
        }

        public bool? NieobecnoscNieusprawiedliwiona
        {
            get
            {
                return Item.NieobecnoscNieusprawiedliwiona;
            }
            set
            {
                if (value != Item.NieobecnoscNieusprawiedliwiona)
                {
                    Item.NieobecnoscNieusprawiedliwiona = value;
                    base.OnPropertyChanged(() => NieobecnoscNieusprawiedliwiona);
                }
            }
        }

        public bool? OdchylekNormy
        {
            get
            {
                return Item.OdchylekNormy;
            }
            set
            {
                if (value != Item.OdchylekNormy)
                {
                    Item.OdchylekNormy = value;
                    base.OnPropertyChanged(() => OdchylekNormy);
                }
            }
        }

        public bool? PomniejszenieZwolnienie
        {
            get
            {
                return Item.PomniejszenieZwolnienie;
            }
            set
            {
                if (value != Item.PomniejszenieZwolnienie)
                {
                    Item.PomniejszenieZwolnienie = value;
                    base.OnPropertyChanged(() => PomniejszenieZwolnienie);
                }
            }
        }

        public string PozycjaPIT
        {
            get
            {
                return Item.PozycjaPIT;
            }
            set
            {
                if (value != Item.PozycjaPIT)
                {
                    Item.PozycjaPIT = value;
                    base.OnPropertyChanged(() => PozycjaPIT);
                }
            }
        }

        public int? SposobNaliczania
        {
            get
            {
                return Item.SposobNaliczania;
            }
            set
            {
                if (value != Item.SposobNaliczania)
                {
                    Item.SposobNaliczania = value;
                    base.OnPropertyChanged(() => SposobNaliczania);
                }
            }
        }

        public bool? NaliczajUlge
        {
            get
            {
                return Item.NaliczajUlge;
            }
            set
            {
                if (value != Item.NaliczajUlge)
                {
                    Item.NaliczajUlge = value;
                    base.OnPropertyChanged(() => NaliczajUlge);
                }
            }
        }

        public string PozycjaZus
        {
            get
            {
                return Item.PozycjaZus;
            }
            set
            {
                if (value != Item.PozycjaZus)
                {
                    Item.PozycjaZus = value;
                    base.OnPropertyChanged(() => PozycjaZus);
                }
            }
        }

        public int? SposobNaliczaniaZus
        {
            get
            {
                return Item.SposobNaliczaniaZus;
            }
            set
            {
                if (value != Item.SposobNaliczaniaZus)
                {
                    Item.SposobNaliczaniaZus = value;
                    base.OnPropertyChanged(() => SposobNaliczaniaZus);
                }
            }
        }

        public int? SposobNaliczaniaUbezpieczenie
        {
            get
            {
                return Item.SposobNaliczaniaUbezpieczenie;
            }
            set
            {
                if (value != Item.SposobNaliczaniaUbezpieczenie)
                {
                    Item.SposobNaliczaniaUbezpieczenie = value;
                    base.OnPropertyChanged(() => SposobNaliczaniaUbezpieczenie);
                }
            }
        }

        public int? WliczacWynagrodzenieUrlop
        {
            get
            {
                return Item.WliczacWynagrodzenieUrlop;
            }
            set
            {
                if (value != Item.WliczacWynagrodzenieUrlop)
                {
                    Item.WliczacWynagrodzenieUrlop = value;
                    base.OnPropertyChanged(() => WliczacWynagrodzenieUrlop);
                }
            }
        }

        public string StalaOkresowa
        {
            get
            {
                return Item.StalaOkresowa;
            }
            set
            {
                if (value != Item.StalaOkresowa)
                {
                    Item.StalaOkresowa = value;
                    base.OnPropertyChanged(() => StalaOkresowa);
                }
            }
        }

        public int? IdOkresuWyplaty
        {
            get
            {
                return Item.IdOkresuWyplaty;
            }
            set
            {
                if (value != Item.IdOkresuWyplaty)
                {
                    Item.IdOkresuWyplaty = value;
                    base.OnPropertyChanged(() => IdOkresuWyplaty);
                }
            }
        }

        public bool DodatekOkresowy
        {
            get
            {
                return Item.DodatekOkresowy;
            }
            set
            {
                if (value != Item.DodatekOkresowy)
                {
                    Item.DodatekOkresowy = value;
                    base.OnPropertyChanged(() => DodatekOkresowy);
                }
            }
        }

        public int? WliczanieZasilkuChorobowego
        {
            get
            {
                return Item.WliczanieZasilkuChorobowego;
            }
            set
            {
                if (value != Item.WliczanieZasilkuChorobowego)
                {
                    Item.WliczanieZasilkuChorobowego = value;
                    base.OnPropertyChanged(() => WliczanieZasilkuChorobowego);
                }
            }
        }

        public int? WliczanieEkwiwalentuUrlopu
        {
            get
            {
                return Item.WliczanieEkwiwalentuUrlopu;
            }
            set
            {
                if (value != Item.WliczanieEkwiwalentuUrlopu)
                {
                    Item.WliczanieEkwiwalentuUrlopu = value;
                    base.OnPropertyChanged(() => WliczanieEkwiwalentuUrlopu);
                }
            }
        }

        public decimal? Zaokraglenie
        {
            get
            {
                return Item.Zaokraglenie;
            }
            set
            {
                if (value != Item.Zaokraglenie)
                {
                    Item.Zaokraglenie = value;
                    base.OnPropertyChanged(() => Zaokraglenie);
                }
            }
        }

        public string SposobZaokraglenia
        {
            get
            {
                return Item.SposobZaokraglenia;
            }
            set
            {
                if (value != Item.SposobZaokraglenia)
                {
                    Item.SposobZaokraglenia = value;
                    base.OnPropertyChanged(() => SposobZaokraglenia);
                }
            }
        }

        public bool? PrzyrownajNajnizsze
        {
            get
            {
                return Item.PrzyrownajNajnizsze;
            }
            set
            {
                if (value != Item.PrzyrownajNajnizsze)
                {
                    Item.PrzyrownajNajnizsze = value;
                    base.OnPropertyChanged(() => PrzyrownajNajnizsze);
                }
            }
        }

        public bool? UwzglednijDoplatyNadgodzin
        {
            get
            {
                return Item.UwzglednijDoplatyNadgodzin;
            }
            set
            {
                if (value != Item.UwzglednijDoplatyNadgodzin)
                {
                    Item.UwzglednijDoplatyNadgodzin = value;
                    base.OnPropertyChanged(() => UwzglednijDoplatyNadgodzin);
                }
            }
        }

        public bool? WplywaNaWyplate
        {
            get
            {
                return Item.WplywaNaWyplate;
            }
            set
            {
                if (value != Item.WplywaNaWyplate)
                {
                    Item.WplywaNaWyplate = value;
                    base.OnPropertyChanged(() => WplywaNaWyplate);
                }
            }
        }

        public bool? WplywaNaZaliczkePodatku
        {
            get
            {
                return Item.WplywaNaZaliczkePodatku;
            }
            set
            {
                if (value != Item.WplywaNaZaliczkePodatku)
                {
                    Item.WplywaNaZaliczkePodatku = value;
                    base.OnPropertyChanged(() => WplywaNaZaliczkePodatku);
                }
            }
        }

        public bool? WliczajWynagrodzeniePFRON
        {
            get
            {
                return Item.WliczajWynagrodzeniePFRON;
            }
            set
            {
                if (value != Item.WliczajWynagrodzeniePFRON)
                {
                    Item.WliczajWynagrodzeniePFRON = value;
                    base.OnPropertyChanged(() => WliczajWynagrodzeniePFRON);
                }
            }
        }

        public bool? StanowiKosztPracownika
        {
            get
            {
                return Item.StanowiKosztPracownika;
            }
            set
            {
                if (value != Item.StanowiKosztPracownika)
                {
                    Item.StanowiKosztPracownika = value;
                    base.OnPropertyChanged(() => StanowiKosztPracownika);
                }
            }
        }

        public bool? OpisAnalitycznyZgodny
        {
            get
            {
                return Item.OpisAnalitycznyZgodny;
            }
            set
            {
                if (value != Item.OpisAnalitycznyZgodny)
                {
                    Item.OpisAnalitycznyZgodny = value;
                    base.OnPropertyChanged(() => OpisAnalitycznyZgodny);
                }
            }
        }

        public bool? NieZapisujZerowychElementow
        {
            get
            {
                return Item.NieZapisujZerowychElementow;
            }
            set
            {
                if (value != Item.NieZapisujZerowychElementow)
                {
                    Item.NieZapisujZerowychElementow = value;
                    base.OnPropertyChanged(() => NieZapisujZerowychElementow);
                }
            }
        }

        public bool? DoliczanyPoOgraniczeniuPotracen
        {
            get
            {
                return Item.DoliczanyPoOgraniczeniuPotracen;
            }
            set
            {
                if (value != Item.DoliczanyPoOgraniczeniuPotracen)
                {
                    Item.DoliczanyPoOgraniczeniuPotracen = value;
                    base.OnPropertyChanged(() => DoliczanyPoOgraniczeniuPotracen);
                }
            }
        }

        public bool? WskazZUSJakoWyplacany
        {
            get
            {
                return Item.WskazZUSJakoWyplacany;
            }
            set
            {
                if (value != Item.WskazZUSJakoWyplacany)
                {
                    Item.WskazZUSJakoWyplacany = value;
                    base.OnPropertyChanged(() => WskazZUSJakoWyplacany);
                }
            }
        }

        public int? PiorytetNaliczania
        {
            get
            {
                return Item.PiorytetNaliczania;
            }
            set
            {
                if (value != Item.PiorytetNaliczania)
                {
                    Item.PiorytetNaliczania = value;
                    base.OnPropertyChanged(() => PiorytetNaliczania);
                }
            }
        }

        public int? WliczanyDoGus
        {
            get
            {
                return Item.WliczanyDoGus;
            }
            set
            {
                if (value != Item.WliczanyDoGus)
                {
                    Item.WliczanyDoGus = value;
                    base.OnPropertyChanged(() => WliczanyDoGus);
                }
            }
        }

        public string PKZP
        {
            get
            {
                return Item.PKZP;
            }
            set
            {
                if (value != Item.PKZP)
                {
                    Item.PKZP = value;
                    base.OnPropertyChanged(() => PKZP);
                }
            }
        }

        public string Parametr1
        {
            get
            {
                return Item.Parametr1;
            }
            set
            {
                if (value != Item.Parametr1)
                {
                    Item.Parametr1 = value;
                    base.OnPropertyChanged(() => Parametr1);
                }
            }
        }

        public string Parametr2
        {
            get
            {
                return Item.Parametr2;
            }
            set
            {
                if (value != Item.Parametr2)
                {
                    Item.Parametr2 = value;
                    base.OnPropertyChanged(() => Parametr2);
                }
            }
        }

        public string Wzor
        {
            get
            {
                return Item.Wzor;
            }
            set
            {
                if (value != Item.Wzor)
                {
                    Item.Wzor = value;
                    base.OnPropertyChanged(() => Wzor);
                }
            }
        }

        public bool? TypWyplatyWskaznikiem
        {
            get
            {
                return Item.TypWyplatyWskaznikiem;
            }
            set
            {
                if (value != Item.TypWyplatyWskaznikiem)
                {
                    Item.TypWyplatyWskaznikiem = value;
                    base.OnPropertyChanged(() => TypWyplatyWskaznikiem);
                }
            }
        }

        public string PozycjaERP7
        {
            get
            {
                return Item.PozycjaERP7;
            }
            set
            {
                if (value != Item.PozycjaERP7)
                {
                    Item.PozycjaERP7 = value;
                    base.OnPropertyChanged(() => PozycjaERP7);
                }
            }
        }

        public string NazwaDodajacego
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

        public DateTime? DataDodania
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

        public string NazwaModyfikujacego
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

        public DateTime? DataModyfikacji
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
            throw new NotImplementedException();
        }
        #endregion
    }
}
