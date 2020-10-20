using System;
using System.Collections.Generic;
using System.Linq;

namespace ObligEn
{
    public class FamilyApp
    {
        //CommandPrompt "vis, hjelp, liste"
        public const string CommandPrompt = "What Would You Like To Do ";

        private List<Person> _people;

        //WelcomeMessage
        public const string WelcomeMessage = "Welcome!";

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        //HandleCommand
        public object HandleCommand(string command)
        {
            var com = command.ToLower();
            var vis = com.Substring(0, 3);
            var substringId = com.Substring(4,1);
            var id = 0;
            var str = string.Empty;
            
            switch (com)
            {
                case "hjelp":
                    return "vis <id> = Vise en bestemt person. \n" +
                           "hjelp = Viser alle kommandoene. \n" +
                           "liste = lister alle personer som finner i registeret.";
                case "liste":
                {
                    foreach (var peoples in _people) Console.WriteLine(peoples.GetDescription());
                    break;
                }
            }
            
                if (vis == "vis" && com.Length > 4)
                {
                    int searchId = int.Parse(substringId);
                    foreach (var peoples in _people.Where(peoples => peoples.Id == searchId))
                    {
                        str += peoples.GetDescription();
                        id = peoples.Id;
                    }    
                }
                str = ChildrenSearch(id, str);
                return str;
        }

        
        private string ChildrenSearch(int childId, string str)
        {
            if (childId == 0) return str;
            var count = 0;

            foreach (var peoples in _people)
            {
                if (peoples.Father != null && childId == peoples.Father.Id)
                {
                    if (count == 0)
                    {
                        str += "\n  Barn:";
                        count++;
                    }

                    str += $"\n    {peoples.FirstName} (Id={peoples.Id}) Født: {peoples.BirthYear}";
                }

                if (peoples.Mother != null && childId == peoples.Mother.Id)
                {
                    str +=$"\n    {peoples.FirstName} (Id={peoples.Id}) Født: {peoples.BirthYear}";
                }
            }

            if (count > 0) str += "\n";
            return str;
        }
    }
}