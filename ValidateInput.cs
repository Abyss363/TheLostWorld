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
            input = Console.ReadLine()!.ToLower();
            List<string> races = new List<string> { };//Races go here
            int raceCount = 0;
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
            input = Console.ReadLine()!.ToLower();
            List<string> classes = new List<string> { };//Classes go here
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
                Console.WriteLine("Invalid Race");
            }
        }
        while (true);
    }

    public string ValidateOrigin()
    {
        //Origins and Origin stories listed here
        do
        {
            input = Console.ReadLine()!.ToLower();
            List<string> origins = new List<string> { };//Origins go here
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
                Console.WriteLine("Invalid Race");
            }
        }
        while (true);
    }
}
