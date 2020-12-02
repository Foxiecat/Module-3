namespace SodaMachine
{
    public class SodaCtor
    {
        public string Name { get; private set; }
        public int Price { get; }

        public SodaCtor(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}