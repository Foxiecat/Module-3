using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SodaMachine
{
    public class SodaSelection
    {
        private int SelectSoda { get; set; }
        public void Selection()
        {
            var insert = new Insert();
            var returnMoney = new MoneyReturn();

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
                case 1 when insert.InsertAmount >= 20:
                    insert.InsertAmount -= 20;
                    Console.WriteLine($"Dispensing Cola...");
                    returnMoney.ReturnMoney();
                    break;
                
                case 2 when insert.InsertAmount >= 15:
                    insert.InsertAmount -= 15;
                    Console.WriteLine($"Dispensing Pepsi...");
                    returnMoney.ReturnMoney();
                    break;
                
                case 3 when insert.InsertAmount >= 25:
                    insert.InsertAmount -= 25;
                    Console.WriteLine($"Dispensing Fanta...");
                    returnMoney.ReturnMoney();
                    break;
            }
        }
    }
}
