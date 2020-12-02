using System;

namespace SodaMachine
{
    public class Insert
    {
        public int InsertAmount { get; set; }
        public void InsertMoney()
        {
            Console.WriteLine("Please insert an amount of money:");

            string insertString = Console.ReadLine();

            try
            {
                InsertAmount += int.Parse(insertString!);
            }
            catch (FormatException e)
            {
                throw new InsertException(e);
            }

            Console.WriteLine($"You inserted {InsertAmount}.");
        }
    }
}