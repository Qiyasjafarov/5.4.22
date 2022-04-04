using System;
using System.Collections.Generic;
using System.Text;

namespace Down_Casting__Operators.Models
{
    public class AZN
    {

        public double Amount { get; set; }
            public AZN(double Amount)
            {
                this.Amount = Amount;
            }

            public static bool operator >(AZN a, USD u)
            {
                return a.Amount > (u.Amount * 1.7);
            }
            public static bool operator <(AZN a, USD u)
            {
                return a.Amount < (u.Amount * 1.7);
            }

        }
    }

