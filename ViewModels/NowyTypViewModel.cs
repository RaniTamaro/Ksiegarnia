using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowyTypViewModel : NowyElementViewModel<Typ>
    {
        #region Kontruktor
        public NowyTypViewModel()
            : base("Typ")
        {
            Item = new Typ();
        }
        #endregion

        #region Properties
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
                    OnPropertyChanged(() => Nazwa);
                }
            }
        }

        public string Zlozonosc
        {
            get
            {
                return Item.Zlozonosc;
            }
            set
            {
                if (value != Item.Zlozonosc)
                {
                    Item.Zlozonosc = value;
                    OnPropertyChanged(() => Zlozonosc);
                }
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Item.NazwaDodajacego = Environment.UserName;
            Db.Typ.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
