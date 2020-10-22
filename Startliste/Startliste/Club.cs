using System.Collections.Generic;

namespace Startliste
{
    public class Club
    {
        public string Name { get; private set; }
        public List<Registration> Registrations { get; private set; }

        public Club(string name)
        {
            Name = name;
            Registrations = new List<Registration>();
        }

        public void Add(Registration registration)
        {
            Registrations.Add(registration);
        }
    }
}