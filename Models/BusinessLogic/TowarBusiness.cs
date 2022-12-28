using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class TowarBusiness : DatabaseClass
    {
        #region Konstruktor
        public TowarBusiness(KsiegarniaEntities ksiegarniaEntities) 
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public IQueryable<KeyAndValue> GetAktywneTowary()
        {
            return
                (
                    from towar in Db.Towar
                    where towar.CzyAktywny == true
                    select new KeyAndValue
                    {
                        Key = towar.IdTowaru,
                        Value = towar.NazwaTowaru
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
