namespace TheLostWorld;

public class Combat
{
    public Combat(string name, int eHealth, int escapeChance, int stamina, int attackPower, int armor)
    {
        Random rand = new Random();
        string input;
        ValidateInput validInput = new ValidateInput();


        Console.WriteLine($"A {name} appears before you");
        do
        {
            Game.currentPlayer.finalDefence = Game.currentPlayer.defence;
            Console.WriteLine($"Enemy Health: {eHealth}");
            Console.WriteLine($"Your health: {Game.currentPlayer.health}");

            Console.WriteLine("(A)ttack  (D)efend");
            Console.WriteLine("(R)un     (I)tems");
            Console.WriteLine("(S)kills   (M)ove");


            input = validInput.ValidateCombatOption();

            switch (input)
            {
                case "a":
                    Console.WriteLine($"You attack dealing {Game.currentPlayer.finalDamage}");
                    eHealth -= Game.currentPlayer.finalDamage;
                    break;
                case "d":
                    Console.WriteLine($"You enter a defensive stance, doubling your defence");
                    Game.currentPlayer.finalDefence = 2 * Game.currentPlayer.defence;
                    break;
                case "r":
                    Console.WriteLine("You try to run away");
                    int escape = rand.Next(0, 100);
                    if (escape <= escapeChance)
                    {
                        Console.WriteLine("You have successfully escaped");
                        Game.currentPlayer.ranAway = true;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You could not escape successfully");
                        Console.WriteLine($"The ... does an attack of opportunity");
                        Game.currentPlayer.health -= attackPower * 0.5;
                    }
                    break;

                case "i":
                    UseItem();

                    break;

                case "s":

                    break;

                case "m":

                    break;
            }

            if (eHealth > 0)
            {
                Console.WriteLine($"The ... attacks you for {attackPower} damage");
                Game.currentPlayer.health -= attackPower;
            }
            else
            {
                Console.WriteLine("You have emerged victorious");
            }
        }
        while (eHealth > 0 && Game.currentPlayer.health > 0);
        if(Game.currentPlayer.health < 0)
        {
            Console.WriteLine("You died.");
            Game.isDead = true;
        }
    }

    public void UseItem()
    {
        ValidateInput validInput = new ValidateInput();

        // Display the player's inventory
        Game.currentPlayer.ShowInventory();

        Console.WriteLine("Enter the name of the item you want to use:");
        string itemName = validInput.ValidateName(); // Validate input

        // Try to use the item
        bool success = Game.currentPlayer.inventory.CombatUseItem(itemName);

        if (success)
        {
            Console.WriteLine($"You used {itemName}.");
        }
        else
        {
            Console.WriteLine($"You don't have {itemName} or cannot use it.");
        }
    }
}

