using System;
using System.Linq;

namespace Password_Generator
{
    class Program
    {
        private static readonly Random Random = new Random();
        
        private static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
            
            var length = Convert.ToInt32(args[0]);
            string options = args[1];
            
            string pattern = options.PadRight(length, 'l');
            
            var password = string.Empty;
            
            while (pattern.Length > 0)
            {

                int randomIndex = Random.Next(0, pattern.Length - 1);
                char category = pattern[randomIndex];

                pattern = pattern.Remove(randomIndex, 1);
                switch (category)
                {
                    case 'l':
                        password += GetRandomLowerCaseLetter();
                        break;
                    case 'L':
                        password += GetRandomUpperCaseLetter();
                        break;
                    case 'd':
                        password += GetRandomDigit();
                        break;
                    case 's':
                        password += GetRandomSpecial();
                        break;
                }
            }
            Console.WriteLine(password);
        }

        private static char GetRandomLowerCaseLetter()
        {
            const char min = 'a';
            const char max = 'z';
            return (char) Random.Next(min, max);
        }
        private static char GetRandomUpperCaseLetter()
        {
            const char min = 'A';
            const char max = 'Z';
            return (char) Random.Next(min, max);
        }
        private static char GetRandomDigit()
        {
            return Random.Next(0, 9).ToString()[0];
        }
        private static char GetRandomSpecial()
        {
            const string allSpecials = "!\"#¤%&/(){}[]";
            var index = Random.Next(0, allSpecials.Length - 1);
            return allSpecials[index];
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;

            var stringLength = args[0];
            var options = args[1];

            return !options.Any(character =>
                character != 'l'
                && character != 'L'
                && character != 'd'
                && character != 's') && IsValidLength(stringLength);
        }

        private static bool IsValidLength(string stringLength)
        {
            return stringLength.All(char.IsDigit);
        }

        private static void ShowHelpText()
        {            
            Console.WriteLine("PasswordGenerator");
            Console.WriteLine("Options:");
            Console.WriteLine("- l = lower case letter");
            Console.WriteLine("- L = upper case letter");
            Console.WriteLine("- d = digit");
            Console.WriteLine("- s = special character (!\"#¤%&/(){}[] \n");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}
