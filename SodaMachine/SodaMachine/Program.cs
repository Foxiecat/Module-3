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

            var cola = sodaMachine.AddSoda("Cola", 20);
            var pepsi = sodaMachine.AddSoda("Pepsi", 15);
            var fanta = sodaMachine.AddSoda("Fanta", 10);

            var insertedAmount = sodaMachine.InsertMoney(25);
            Console.WriteLine($"You inserted {insertedAmount}.");
            
            var buying = sodaMachine.Buy(fanta);
            Console.WriteLine(buying);

            var userAmount = sodaMachine.InsertAmount;
            var returnMoney = sodaMachine.ReturnMoney(userAmount);
            Console.WriteLine(returnMoney);
        }
    }
}