using Firma.Models.Entities;
using Firma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class OkresBusiness : DatabaseClass
    {
        #region Kontruktor
        public OkresBusiness(KsiegarniaEntities ksiegarniaEntities) 
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public IQueryable<KeyAndValue> GetAktywneOkresy()
        {
            return
                (
                    from towar in Db.OkresWyplaty
                    where towar.CzyAktywny == true
                    select new KeyAndValue
                    {
                        Key = towar.IdOkresuWyplaty,
                        Value = towar.Nazwa
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}
