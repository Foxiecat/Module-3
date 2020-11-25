namespace SodaMachine
{
    public class Soda
    {
        private int _id;
        private string _name;
        private int _price;

        public Soda(string name, int price, int id)
        {
            _name = name;
            _price = price;
            _id = id;
        }
    }
}