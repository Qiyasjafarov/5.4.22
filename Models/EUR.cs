using System;
using System.Collections.Generic;
using System.Text;

namespace Down_Casting__Operators.Models
{
    public class EUR
    {
        public double Amount { get; set; }
        public EUR(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(EUR eur)
        {
            return new AZN(eur.Amount * 1.86);
        }
        public static implicit operator EUR(AZN azn)
        {
            return new EUR(azn.Amount / 1.86);
        }
        public static implicit operator USD(EUR eur)
        {
            return new USD(eur.Amount * 1.1);
        }
        public static implicit operator EUR(USD eur)
        {
            return new EUR(eur.Amount / 1.1);
        }

        public static bool operator >(EUR e, AZN a)
        {
            return e.Amount > a.Amount;
        }
        public static bool operator <(EUR e, AZN a)
        {
            return e.Amount < a.Amount;
        }
        public static bool operator >(EUR e, USD u)
        {
            return e.Amount > u.Amount;
        }
        public static bool operator <(EUR e, USD u)
        {
            return e.Amount < u.Amount;
        }

    }
}
