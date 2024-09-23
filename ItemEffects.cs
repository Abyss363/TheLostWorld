namespace TheLostWorld;

public class ItemEffects
{
    public void ApplyItemEffects(Item item)
    {
        if (item.Name == "Health Potion")
        {
            Game.currentPlayer.health += 10; // Heal 10 HP
            Console.WriteLine("You feel reinvigorated. +10 Health.");
        }
        else if (item.Name == "Mana Potion")
        {
            Game.currentPlayer.mana += 10; // Restore 10 mana
            Console.WriteLine("You feel your mana surge. +10 Mana.");
        }
        // Add more item types and their effects here
    }
}
