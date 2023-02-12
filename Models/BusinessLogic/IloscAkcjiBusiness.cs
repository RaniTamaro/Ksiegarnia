using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class IloscAkcjiBusiness : DatabaseClass
    {
        #region Kontruktor
        public IloscAkcjiBusiness(KsiegarniaEntities ksiegarniaEntities)
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public decimal? IloscAkcjiOkres(int idRodzajuDokumentu, DateTime dataOd, DateTime dataDo)
        {
            return (
                    from magazyn in Db.Magazyn
                    where magazyn.IdRodzajuDokumentu == idRodzajuDokumentu &&
                    magazyn.DataWystawienia >= dataOd &&
                    magazyn.DataWystawienia <= dataDo &&
                    magazyn.CzyAktywny == true
                    select magazyn
                ).Count();
        }
        #endregion
    }
}
