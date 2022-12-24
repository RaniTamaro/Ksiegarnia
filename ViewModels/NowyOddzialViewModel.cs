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
        }
        #endregion

        //TO DO - dodać IdAdresu!
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
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Item.NazwaDodajacego = Environment.UserName;
            Db.Oddzial.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
