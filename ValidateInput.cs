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

    public string ValidateRace()
    {
        //Races listed here
        do
        {
            
            List<string> races = new List<string> {"john"};//Races go here
            int raceCount = 0;
            foreach (var race in races)
            {
                Console.WriteLine($"Race: {race}");
            }
            input = Console.ReadLine()!.ToLower();
            foreach (var race in races)
            {
                if (input!.Contains(race.ToLower()))
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
            
            List<string> classes = new List<string> {"fighter", "mage", "marksman", "rogue", "tank", "invoker"};//Classes go here
            foreach (var _class in classes)
            {
                Console.WriteLine($"Class: {_class}");
            }
            input = Console.ReadLine()!.ToLower();
            int classCount = 0;
            foreach (var _class in classes)
            {
                if (input!.Contains(_class.ToLower()))
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
        do
        {
            List<string> origins = new List<string> {"samurai"};//Origins go here
            foreach (var origin in origins)
            {
                Console.WriteLine($"Origin: {origin}");
            }
            input = Console.ReadLine()!.ToLower();
            int originCount = 0;
            foreach (var origin in origins)
            {
                if (input!.Contains(origin.ToLower()))
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
}
