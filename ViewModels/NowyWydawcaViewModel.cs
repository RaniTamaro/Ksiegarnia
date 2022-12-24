using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowyWydawcaViewModel : NowyElementViewModel<Wydawca>
    {
        #region Konstruktor
        public NowyWydawcaViewModel()
            :base("Wydawca")
        {
            Item = new Wydawca();
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

        //public bool CzyAktywny
        //{
        //    get
        //    {
        //        return Item.CzyAktywny;
        //    }
        //    set
        //    {
        //        if (value != Item.CzyAktywny)
        //        {
        //            //Item.CzyAktywny = value;
        //            if (value)
        //            {
        //                Item.CzyAktywny = false;
        //            }
        //            else
        //            {
        //                Item.CzyAktywny = true;
        //            }

        //            base.OnPropertyChanged(() => CzyAktywny);
        //        }
        //    }
        //}
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Item.NazwaDodajacego = Environment.UserName;
            Db.Wydawca.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
