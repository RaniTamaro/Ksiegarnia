using Firma.Tools.Extensions;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class UtargBusiness : DatabaseClass
    {
        #region Kontruktor
        public UtargBusiness(KsiegarniaEntities ksiegarniaEntities) 
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public decimal? UtargOkresTowar(int idTowaru, DateTime dataOd, DateTime dataDo)
        {
            return Db.PozycjaFaktury
                .Where(x => x.IdTowaru == idTowaru && x.Faktura.DataDodania >= dataOd && x.Faktura.DataDodania <= dataDo && x.CzyAktywna == true)
                .Select(x => x.Cena * x.Ilosc).SumOrDefault();
        }
        #endregion
    }
}
