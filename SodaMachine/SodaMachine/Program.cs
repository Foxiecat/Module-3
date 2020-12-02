using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Net.Http;

namespace SodaMachine
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sodaMachine = new SodaMachine();

            SodaCtor cola;
            SodaCtor pepsi;
            SodaCtor fanta;
            var soda = new []
            {
                cola = sodaMachine.AddSoda("cola", 20),
                pepsi = sodaMachine.AddSoda("pepsi", 15),
                fanta = sodaMachine.AddSoda("fanta", 10),
            };

            while (true)
            {
                Console.WriteLine("Please insert an amount of money:");
                Console.WriteLine($"You have {sodaMachine.InsertAmount}.");                
                var command = Console.ReadLine();
                var money = int.Parse(command);
                sodaMachine.InsertMoney(money);

                Console.WriteLine("Please choose what to buy; Cola = 20 nok, Pepsi = 15 nok, Fanta = 10 nok");
                Console.WriteLine($"You have {sodaMachine.InsertAmount}.");  
                var sodaCommand = Console.ReadLine();
                var select = sodaMachine.Selection(sodaCommand, soda);
                var buying = sodaMachine.Buy(select);
                Console.WriteLine(buying);

                var userAmount = sodaMachine.InsertAmount;
                var returnMoney = sodaMachine.ReturnMoney(userAmount);
                Console.WriteLine(returnMoney);
            }
        }
    }
}