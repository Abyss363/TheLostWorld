using System.Drawing;
using System.Reflection;

namespace TheLostWorld;

public class ValidateInput
{
    public string? input;
    public int input2;
    //bool validEntry;
    public string ValidateName()
    {
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please enter a valid name.");
            }
        }
        while (true);
    }

    public string ValidateItemName()
    {
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input.ToLower();
            }
            else
            {
                Console.WriteLine("Please enter a valid name.");
            }
        }
        while (true);
    }

    public string ValidateRace()
    {
        //Races listed here
        do
        {

            List<string> races = new List<string> { "john" };//Races go here
            int raceCount = 0;
            foreach (var race in races)
            {
                Console.WriteLine($"Race: {race}");
            }
            input = Console.ReadLine()!.ToLower();
            foreach (var race in races)
            {
                if (input == race.ToLower())
                {
                    raceCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && raceCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Race");
            }
        }
        while (true);
    }

    public string ValidateClass()
    {
        //Classes listed here
        do
        {

            List<string> classes = new List<string> { "fighter", "mage", "marksman", "rogue", "tank", "invoker" };//Classes go here
            foreach (var playerClass in classes)
            {
                Console.WriteLine($"Class: {playerClass}");
            }
            input = Console.ReadLine()!.ToLower();
            int classCount = 0;
            foreach (var playerClass in classes)
            {
                if (input == playerClass.ToLower())
                {
                    classCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && classCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Class");
            }
        }
        while (true);
    }

    public string ValidateOrigin()
    {
        //Origins and Origin stories listed here
        Console.WriteLine("Origin Stories:");
        Console.WriteLine("||Fighter||");
        Console.WriteLine("");
        do
        {
            List<string> origins = new List<string> { "fighter", "mage", "marksman", "rogue", "tank", "invoker" };//Origins go here
            foreach (var origin in origins)
            {
                Console.WriteLine($"Origin: {origin}");
            }
            input = Console.ReadLine()!.ToLower();
            int originCount = 0;
            foreach (var origin in origins)
            {
                if (input == origin.ToLower())
                {
                    originCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && originCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Origin");
            }
        }
        while (true);
    }

    public string ValidateCombatOption()
    {
        do
        {
            List<string> options = new List<string> { "a", "d", "r", "i", "s", "m" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }

    public string ValidateTownOption()
    {
        do
        {
            List<string> options = new List<string> { "t", "c", "d", "l", "p" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }

    public string ValidatePlayerOption()
    {
        do
        {
            List<string> options = new List<string> { "i", "s", "l", "e", "u" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }

    public string ValidateLocationOption()
    {
        do
        {
            List<string> options = new List<string> { "a", "g", "b", "e" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }

    public string ValidateBuyOrSell()
    {
        do
        {
            List<string> options = new List<string> { "b", "s", "l" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }

    public string ValidateBuyOption()
    {
        do
        {
            List<string> options = new List<string> { "h", "m", "s" };

            input = Console.ReadLine()!.ToLower();

            int optionCount = 0;
            foreach (var option in options)
            {
                if (input == option.ToLower())
                {
                    optionCount++;
                }
            }

            if (!string.IsNullOrEmpty(input) && optionCount > 0)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        while (true);
    }
}
