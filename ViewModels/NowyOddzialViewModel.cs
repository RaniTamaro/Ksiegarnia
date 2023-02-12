using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    internal class NowyOddzialViewModel : NowyElementViewModel<Oddzial>
    {
        #region Kontruktor
        public NowyOddzialViewModel()
            : base("Oddział")
        {
            Item = new Oddzial();
            SetAddedInformation();
        }
        #endregion

        #region Properties
        public string Rodzaj
        {
            get
            {
                return Item.Rodzaj;
            }
            set
            {
                if (value != Item.Rodzaj)
                {
                    Item.Rodzaj = value;
                    OnPropertyChanged(() => Rodzaj);
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
                    Item.Rodzaj = value;
                    OnPropertyChanged(() => Nazwa);
                }
            }
        }

        public int IdAdresu
        {
            get
            {
                return Item.IdAdresu;
            }
            set
            {
                if (value != Item.IdAdresu)
                {
                    Item.IdAdresu = value;
                    OnPropertyChanged(() => IdAdresu);
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
            Db.Oddzial.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
