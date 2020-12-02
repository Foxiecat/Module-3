using System;
using System.Collections.Generic;
using System.Linq;

namespace SodaMachine
{
    public class SodaMachine
    {
        public int InsertAmount { get; private set; }

        public SodaCtor AddSoda(string name, int price)
        {
            var soda = new SodaCtor(name, price);
            return soda;
        }

        public string ReturnMoney(int amount)
        {
            InsertAmount -= amount;
            return $"Returned {amount}";
        }

        public string Buy(SodaCtor soda)
        {
            if (InsertAmount < soda.Price) return "Please insert enough money";
            InsertAmount -= soda.Price;
            return $"You bought a {soda.Name}";
        }

        public void InsertMoney(int amount)
        {
            InsertAmount += amount;
        }

        public SodaCtor Selection(string command, IEnumerable<SodaCtor> soda)
        {
            return soda.FirstOrDefault(s => s != null && s.Name == command.ToLower());
        }
    }
}