using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class RodzajDokumentuBusiness : DatabaseClass
    {
        #region Konstruktor
        public RodzajDokumentuBusiness(KsiegarniaEntities ksiegarniaEntities)
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public IQueryable<KeyAndValue> GetNazwyAkcji()
        {
            return
                (
                    from rodzaj in Db.RodzajDokumentu
                    where rodzaj.CzyAktywny == true
                    select new KeyAndValue
                    {
                        Key = rodzaj.IdRodzajuDokumentu,
                        Value = rodzaj.Nazwa
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
