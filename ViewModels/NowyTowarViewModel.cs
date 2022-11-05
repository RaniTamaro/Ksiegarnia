using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using Firma.ViewResources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class NowyTowarViewModel : NowyElementViewModel<Towar>
    {
        #region Konstruktor
        public NowyTowarViewModel()
            :base("Towar")
        {
            Item = new Towar();
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

        public int IdGrupy
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

        public int IdTypu
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

        public int IdVat
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

        public int? IdJednostki
        {
            get
            {
                return Item.IdJednostki;
            }
            set
            {
                if (value != Item.IdJednostki)
                {
                    Item.IdJednostki = value;
                    base.OnPropertyChanged(() => IdJednostki);
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

        public bool? TypKosztu
        {
            get
            {
                return Item.TypKosztu;
            }
            set
            {
                if (value != Item.TypKosztu)
                {
                    Item.TypKosztu = value;
                    base.OnPropertyChanged(() => TypKosztu);
                }
            }
        }

        public decimal? KosztUslugi
        {
            get
            {
                return Item.KosztUslugi;
            }
            set
            {
                if (value != Item.KosztUslugi)
                {
                    Item.KosztUslugi = value;
                    base.OnPropertyChanged(() => KosztUslugi);
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
        #endregion

        #region Helpers
        public override void Save()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
