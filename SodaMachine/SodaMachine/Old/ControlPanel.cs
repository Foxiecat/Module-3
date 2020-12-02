using System;

namespace SodaMachine
{
    class ControlPanel
    {
        public bool MainPanel(string command)
        {
            var insert = new Insert();
            var sodaSelection = new SodaSelection();
            var returnMoney = new MoneyReturn();
            Console.WriteLine($"Inserted Amount: {insert.InsertAmount}");

            switch (command.ToUpper())
            {
                case "I":
                {
                    insert.InsertMoney(); //If invoked, will let you insert any amount of money to the soda machine
                    return true;
                }
                case "S":
                {
                    sodaSelection.Selection(); //If invoked, will let you select which soda that you want
                    return true;
                }
                case "R":
                {
                    returnMoney.ReturnMoney(); //If invoked, will return any money you inserted into the machine back to you
                    return true;
                }
                case "Q":
                    Console.WriteLine("Turning off Soda Machine...");
                    return false;
                
                default:
                    return true;
            }
        }
    }
}