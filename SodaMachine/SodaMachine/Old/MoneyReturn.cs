using System;

namespace SodaMachine
{
    public class MoneyReturn
    {
        public void ReturnMoney()
        {
            var insert = new Insert();
            Console.WriteLine($"Returning {insert.InsertAmount}...");

            insert.InsertAmount = 0;
        }
    }
}