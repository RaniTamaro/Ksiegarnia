using Firma.Models.Entities;
using Firma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModels
{
    public class NowaKategoriaPracyViewModel : NowyElementViewModel<KategoriaPracy>
    {
        #region Kontruktor
        public NowaKategoriaPracyViewModel()
            : base("Kategoria pracy")
        {
            Item = new KategoriaPracy();
        }
        #endregion

        #region Properties
        public string NazwaDzialu
        {
            get
            {
                return Item.NazwaDzialu;
            }
            set
            {
                if (value != Item.NazwaDzialu)
                {
                    Item.NazwaDzialu = value;
                    OnPropertyChanged(() => NazwaDzialu);
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
                    OnPropertyChanged(() => Opis);
                }
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            Item.CzyAktywny = true;
            Item.NazwaDodajacego = Environment.UserName;
            Db.KategoriaPracy.AddObject(Item);
            Db.SaveChanges();
        }
        #endregion
    }
}
