using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.Validators
{
    public class StringValidator : Validator
    {
        public static string SprawdzCzyZaczynaSieOdDuzej(string wartosc)
        {
            try
            {
                if (!char.IsUpper(wartosc, 0))
                {
                    return "Rozpocznij dużą literą";
                }

                return null;
            }
            catch { }

            return null;
        }

        public static string SprawdzEmail(string wartosc)
        {
            try
            {
                if (wartosc != null)
                {
                    var email = new MailAddress(wartosc);
                }
            }
            catch 
            {
                return "Podano niepoprawny adres email";
            }

            return null;
        }

        public static string SprawdzAdresWWW(string wartosc)
        {
            try
            {
                if (wartosc != null && !(wartosc.StartsWith("http") || wartosc.StartsWith("www")))
                {
                    return "Adres www musi zaczynać się od \"htpp\" lub od \"www\"";
                }
            }
            catch { }

            return null;
        }
    }
}
