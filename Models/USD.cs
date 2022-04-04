using System;
using System.Collections.Generic;
using System.Text;

namespace Down_Casting__Operators.Models
{
    public class USD
    {
        
        
            public double Amount { get; set; }
            public USD(double Amount)
            {
                this.Amount = Amount;
            }

            public static implicit operator AZN(USD usd)
            {
                return new AZN(usd.Amount * 1.7);
            }
        
        public static implicit operator USD(AZN azn)
            {
                return new USD(azn.Amount / 1.7);
            }

            public static bool operator >(USD u, AZN a)
            {
                return u.Amount > a.Amount;
            }
            public static bool operator <(USD u, AZN a)
            {
                return u.Amount < a.Amount;
            }

        }
    }

