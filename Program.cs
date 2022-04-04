using Down_Casting__Operators.Models;
using System;

namespace Down_Casting__Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usdV = new USD(300);

            AZN aznV = new AZN(500);
            EUR eurV = new EUR(200);

             

            Console.WriteLine(aznV > eurV);

        }
    }


   

   


}
    