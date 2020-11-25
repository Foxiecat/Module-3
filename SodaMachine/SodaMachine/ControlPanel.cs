using System;

namespace SodaMachine
{
    class ControlPanel
    {
        public static bool MainPanel()
        {
            Console.WriteLine("\nI = Insert, S = Select, R = Return, Q = Quit");
            Console.WriteLine($"Inserted Amount: {Insert.InsertAmount}");

            switch (Console.ReadLine().ToUpper())
            {
                case "I":
                {
                    Insert.InsertMoney(); //If invoked, will let you insert any amount of money to the soda machine
                    return true;
                }
                case "S":
                {
                    SodaSelection.Selection(); //If invoked, will let you select which soda that you want
                    return true;
                }
                case "R":
                {
                    MoneyReturn.ReturnMoney(); //If invoked, will return any money you inserted into the machine back to you
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