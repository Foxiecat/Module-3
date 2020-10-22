using System;
using System.Collections.Generic;
using System.IO;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new RegistrationModel();

            using var file = new StreamReader("startlist.csv");
            {
                var line = file.ReadLine();

                while ((line = file.ReadLine()) != null)
                {
                    model.HandleLine(line);
                }
            }

            Console.WriteLine("Alle klubbene: ");
            for (var index = 0; index < model.Clubs.Count; index++)
            {
                var no = index + 1;
                var club = model.Clubs[index];
                Console.WriteLine(no + ": " + club.Name);
            }

            Console.Write("Skriv inn klubb nummer: ");
            var clubNoStr = Console.ReadLine();
            var clubNo = Convert.ToInt32(clubNoStr);
            var clubIndex = clubNo - 1;
            var selectedClub = model.Clubs[clubIndex];

            Console.WriteLine("Viser alle påmeldinger i denne klubben:");
            foreach (var registrations in selectedClub.Registrations)
            {
                Console.WriteLine(registrations.ToNiceString());
            }
        }
    }
}