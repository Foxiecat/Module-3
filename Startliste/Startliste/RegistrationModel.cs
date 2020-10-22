using System.Collections.Generic;
using System.Linq;

namespace Startliste
{
    class RegistrationModel
    {
        public List<Registration> Registrations { get; private set; }
        public List<Club> Clubs { get; private set; }

        public RegistrationModel()
        {
            Registrations = new List<Registration>();
            Clubs = new List<Club>();
        }

        public void HandleLine(string csvLine)
        {
            var registration = new Registration(csvLine);
            Registrations.Add(registration);

            Club club = Clubs.FirstOrDefault(c => c.Name == registration.Club);
            if (club == null)
            {
                club = new Club(registration.Club);
                Clubs.Add(club);
            }

            club.Add(registration);

        }
    }
}