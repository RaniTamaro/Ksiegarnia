using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.Validators
{
    public class BussinessValidator : Validator
    {
        public static string SprawdzNieujemnosc(decimal? wartosc)
        {
            if(wartosc < 0)
            {
                return "Wartość nie może być mniejsza niż zero";
            }

            return null;
        }

        public static string SprawdzUzupelnienie(object wartosc)
        {
            if (wartosc == null)
            {
                return "Pole musi być uzupełnione";
            }

            return null;
        }

        public static string PeselValidator(string pesel)
        {
            if (pesel != null)
            {
                var multiplication = new List<int> { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                var sum = 0;

                if (pesel.Length != 11)
                {
                    return "Pesel ma niepoprawną długość";
                }

                for (int i = 0; i < pesel.Length - 1; i++)
                {
                    sum += int.Parse(pesel[i].ToString()) * multiplication.ElementAt(i);
                }

                var controlNumber = (10 - (sum % 10)) % 10;
                if (controlNumber != int.Parse(pesel[10].ToString()))
                {
                    return "Pesel niepoprawny - błędna cyfra kontrolna";
                }
            }

            return null;
        }
    }
}
