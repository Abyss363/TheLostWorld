namespace TheLostWorld;

public class Drops
{
    private Random random = new Random();

//Example Drops:
    // Simulate item drop
    // public void DropItems(EveryItem inventory)
    // {
    //     // Define a simple loot table
    //     List<Item> possibleDrops = new List<Item>
    //     {
    //         new Item("Health Potion", 1),
    //         new Item("Mana Potion", 1),
    //         new Item("Iron Sword", 1)
    //     };

    //     // Simulate a random drop
    //     int dropIndex = random.Next(possibleDrops.Count);
    //     var droppedItem = possibleDrops[dropIndex];

    //     // Add the dropped item to the player's inventory
    //     inventory.AddItem(droppedItem.Name, droppedItem.Count);
    //     Console.WriteLine($"You received {droppedItem.Name} (x{droppedItem.Count})!");
    // }

    public void SlimeDrops(EveryItem inventory)
    {
        inventory.AddItem("Slime Ball", 5);
        inventory.AddItem("Health Potion", 5);
        Console.WriteLine("You received Slime Balls (x5)!");
    }
}

