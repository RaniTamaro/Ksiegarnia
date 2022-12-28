using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Extensions
{
    public static class LinqExtension
    {
        public static decimal? SumOrDefault(this IQueryable<decimal> decimals)
        {
            try
            {
                return decimals.Sum();
            }
            catch
            {
                return null;
            }
        }
    }
}
