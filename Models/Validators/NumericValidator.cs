using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.Validators
{
    public class NumericValidator
    {
        public static string SprawdzDecimal(string wartość)
        {
            decimal liczba;
            try
            {
                liczba = Convert.ToDecimal(wartość);
            }
            catch
            {
                return "Wprowadzona wartość musi być liczbą";
            }

            return null;
        }


    }
}
