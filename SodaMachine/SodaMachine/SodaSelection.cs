using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SodaMachine
{
    public class SodaSelection
    {
        private static int SelectSoda { get; set; }
        public static void Selection()
        {

            Console.WriteLine("1 = Cola, 2 = Pepsi, 3 = Fanta");
            
            string insertString = Console.ReadLine();

            try
            {
                SelectSoda += int.Parse(insertString!);
            }
            catch (FormatException e)
            {
                throw new InsertException(e);
            }

            switch (SelectSoda)
            {
                case 1 when Insert.InsertAmount >= 20:
                    Insert.InsertAmount -= 20;
                    Console.WriteLine($"Dispensing Cola...");
                    MoneyReturn.ReturnMoney();
                    break;
                
                case 2 when Insert.InsertAmount >= 15:
                    Insert.InsertAmount -= 15;
                    Console.WriteLine($"Dispensing Pepsi...");
                    MoneyReturn.ReturnMoney();
                    break;
                
                case 3 when Insert.InsertAmount >= 25:
                    Insert.InsertAmount -= 25;
                    Console.WriteLine($"Dispensing Fanta...");
                    MoneyReturn.ReturnMoney();
                    break;
            }
        }
    }
}

//If the sodas are objects:
// Soda cola = new Soda("Cola", 20, 1);
// Soda pepsi = new Soda("Pepsi", 15, 2);
// Soda fanta = new Soda("Fanta", 25, 3);