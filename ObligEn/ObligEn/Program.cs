using System;

namespace ObligEn
{
    class Program
    {
        static void Main(string[] args)
        {
            var sverreMagnus = new Person {Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005};
            var ingridAlexandra = new Person {Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004};
            var haakon = new Person {Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973};
            var metteMarit = new Person {Id = 4, FirstName = "Mette-Marit", BirthYear = 1973};
            var marius = new Person {Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997};
            var harald = new Person {Id = 6, FirstName = "Harald", BirthYear = 1937};
            var sonja = new Person {Id = 7, FirstName = "Sonja", BirthYear = 1937};
            var olav = new Person {Id = 8, FirstName = "Olav", BirthYear = 1903};

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var app = new FamilyApp(sverreMagnus, ingridAlexandra, haakon,
                metteMarit, marius, harald, sonja, olav);
            Console.WriteLine(FamilyApp.WelcomeMessage);
            while (true)
            {
                Console.Write(FamilyApp.CommandPrompt);
                var command = Console.ReadLine();
                var response = app.HandleCommand(command);
                Console.WriteLine(response);
            }
        }
    }
}