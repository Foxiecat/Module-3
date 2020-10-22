using System;
using System.Text.RegularExpressions;

namespace Startliste
{
    public class Registration
    {
        public int StartNumber { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string AGroup { get; private set; }
        public string AClass { get; private set; }

        public Registration(string csvLine)
        {
            string[] lineParts = csvLine.Split(",");
            
            StartNumber = Convert.ToInt32("0" + lineParts[0].Trim('"'));
            Name = lineParts[1].Trim('"');
            Club = lineParts[2].Trim('"');
            Nationality = lineParts[3].Trim('"');
            AGroup = lineParts[4].Trim('"');
            AClass = lineParts[5].Trim('"');
        }

        public string ToNiceString()
        {
            return StartNumber + " " + Name + " " + Club + " " + Nationality + " " + AGroup + " " + AClass;
        }
    }
}