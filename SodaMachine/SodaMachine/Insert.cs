using System;

namespace SodaMachine
{
    public class Insert
    {
        public static int InsertAmount { get; set; }
        public static void InsertMoney()
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