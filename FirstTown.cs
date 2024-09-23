using System.Runtime.CompilerServices;

namespace TheLostWorld;

public class FirstTown
{

    public string input;
    public int intInput;
    ValidateInput validInput = new ValidateInput();
    //public List<Item> traderInventory { get; set; } = new List<Item>();
    public FirstTown()
    {
        while (true)
        {
            Console.WriteLine("You are at FirstTown");
            Console.WriteLine("This is the place your adventure begins");

            Console.WriteLine("You can do the following here:");
            Console.WriteLine("(P)layer Menu");
            Console.WriteLine("(T)alk to the Local Residents");
            Console.WriteLine("(C)heck Locations");
            Console.WriteLine("(D)ungeon Clearing");
            Console.WriteLine("(L)eave");

            input = validInput.ValidateTownOption();

            switch (input)
            {
                case "p":
                    Game.currentPlayer.PlayerMenu();
                    break;
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
        while (true)
        {
            Console.WriteLine("Please select a location to enter");
            Console.WriteLine("(A)lchemist Workshop");
            Console.WriteLine("(G)eneral Trader");
            Console.WriteLine("(B)lacksmith's Workshop");

            input = validInput.ValidateLocationOption();

            switch (input)
            {
                case "a":
                    AlchemyWorkshop();
                    break;
                case "g":
                    Shop();
                    break;
                case "b":
                    BlacksmithWorkshop();
                    break;
                case "e":
                    return;
            }
        }

    }

    public void Dungeons()
    {
        Dungeons dungeons = new Dungeons();
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
        Game.Save();
    }

    public void Shop()
    {
        while (true)
        {
            Console.WriteLine("Are you (b)uying or (s)elling, or do you just want to (l)eave");
            input = validInput.ValidateBuyOrSell();

            switch (input)
            {
                case "b":
                    Buy();
                    break;
                case "s":
                    Sell();
                    break;

            }
        }

    }

    public void AlchemyWorkshop()
    {

    }

    public void BlacksmithWorkshop()
    {

    }

    public void Buy()
    {
        //List<string> traderInventory = new List<string>();
        Console.WriteLine($"Your Gold: {Game.currentPlayer.gold}");
        Console.WriteLine("You can buy the following items: ");
        Console.WriteLine("(H)ealth Potion. Price: 5gc");
        Console.WriteLine("(M)ana Potion. Price: 5gc");
        Console.WriteLine("(S)lime Balls. Price: 2gc");

        input = validInput.ValidateBuyOption();
        switch (input)
        {
            case "h":
            Console.Write("Enter amount");
            intInput = Convert.ToInt32(Console.ReadLine());
            if(Game.currentPlayer.gold >= 5 * intInput)
            {
                Game.currentPlayer.inventory.BuyItem("Health Potion", intInput, 5);
                Console.WriteLine($"You have bought {intInput} Health Potions");
            }
            else
            {
                Console.WriteLine("You do not have enough gold");
            }
            
            break;
        }
    }
    public void Sell()
    {
        
    }
}
