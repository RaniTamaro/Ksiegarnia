using Firma.Extensions;
using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class KosztyPracowniczeBusiness : DatabaseClass
    {
        #region Konstruktor
        public KosztyPracowniczeBusiness(KsiegarniaEntities ksiegarniaEntities) 
            : base(ksiegarniaEntities)
        {
        }
        #endregion

        #region FunkcjeBiznesowe
        public decimal? KosztyPracownicyOkres(int idOkresu)
        {
            return Db.Wyplata.Where(x => x.IdOkresuWyplaty == idOkresu && x.CzyAktywny == true).Select(x => x.Kwota).SumOrDefault();
        }
        #endregion
    }
}
