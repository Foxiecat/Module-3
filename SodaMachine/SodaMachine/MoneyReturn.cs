using System;

namespace SodaMachine
{
    public class MoneyReturn
    {
        public static void ReturnMoney()
        {
            Console.WriteLine($"Returning {Insert.InsertAmount}...");

            Insert.InsertAmount = 0;
        }
    }
}