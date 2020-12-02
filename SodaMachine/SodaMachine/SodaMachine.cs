using System;

namespace SodaMachine
{
    public class SodaMachine //Make SodaMachine 
    {
        public int InsertAmount { get; set; }

        public SodaCtor AddSoda(string name, int price)
        {
            var soda = new SodaCtor(name, price);
            return soda;
        }

        public string ReturnMoney(int amount)
        {
            InsertAmount -= amount;
            return $"You returned {amount}";
        }

        public string Buy(SodaCtor soda)
        {
            Console.WriteLine($"You're trying to buy {soda.Name}");
            if (InsertAmount < soda.Price) return "Please insert enough money";
            InsertAmount -= soda.Price;
            return $"You bought a {soda.Name}";
        }

        public int InsertMoney(int amount)
        {
            InsertAmount += amount;
            return amount;
        }
    }
}