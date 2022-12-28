using Firma.Extensions;
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
            return (
                    from pozycja in Db.PozycjaFaktury
                    where pozycja.IdTowaru == idTowaru &&
                    pozycja.Faktura.DataWystawienia >= dataOd &&
                    pozycja.Faktura.DataWystawienia <= dataDo &&
                    pozycja.CzyAktywna == true
                    select pozycja.Cena * pozycja.Ilosc
                ).SumOrDefault();
        }
        #endregion
    }
}
