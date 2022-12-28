using Firma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.BusinessLogic
{
    public class DatabaseClass
    {
        #region Entities
        public KsiegarniaEntities Db { get; set; }
        #endregion

        #region Konstruktor
        public DatabaseClass(KsiegarniaEntities ksiegarniaEntities)
        {
            Db = ksiegarniaEntities;
        }
        #endregion
    }
}
