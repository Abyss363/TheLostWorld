using System.Runtime.CompilerServices;

namespace TheLostWorld;

public class FirstTown
{
    Dungeons dungeons = new Dungeons();
    public FirstTown()
    {
        string input;
        ValidateInput validInput = new ValidateInput();




        while (true)
        {
            Console.WriteLine("You are at FirstTown");
            Console.WriteLine("This is the place your adventure begins");

            Console.WriteLine("You can do the following here:");
            Console.WriteLine("(T)alk to the Local Residents");
            Console.WriteLine("(C)heck Locations");
            Console.WriteLine("(D)ungeon Clearing");
            Console.WriteLine("(L)eave");

            input = validInput.ValidateTownOption();

            switch (input)
            {
                case "t":
                    People();
                    break;

                case "c":
                    Locations();
                    break;

                case "d":
                    Dungeons();
                    break;

                case "l":
                    return;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }

    public void People()
    {

    }

    public void Locations()
    {

    }

    public void Dungeons()
    {
        dungeons.SlimeDungeon(2);
        if (Game.isDead)
        {
            Console.WriteLine("Some villagers managed to bring back your body");
            Game.isDead = false;
        }
        if (Game.currentPlayer.ranAway)
        {
            Console.WriteLine("You succeed in running away");
        }
        Game.currentPlayer.ranAway = false;
    }
}
