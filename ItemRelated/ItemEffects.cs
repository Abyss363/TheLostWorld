namespace TheLostWorld;

public class ItemEffects
{
    public void ApplyItemEffects(Item item)
    {
        switch (item.Name.ToLower())
        {
            case "health potion":
                Game.currentPlayer.health += 10; // Heal 10 HP
                if (Game.currentPlayer.health > Game.currentPlayer.maxHealth)
                {
                    Game.currentPlayer.health = Game.currentPlayer.maxHealth;
                }
                Console.WriteLine("You feel reinvigorated. +10 Health.");
                break;
            case "mana potion":
                Game.currentPlayer.mana += 10; // Restore 10 mana
                if (Game.currentPlayer.mana > Game.currentPlayer.maxMana)
                {
                    Game.currentPlayer.mana = Game.currentPlayer.maxMana;
                }
                Console.WriteLine("You feel your mana surge. +10 Mana.");
                break;
            
            // Add more item types and their effects here
        }
        
    }
}
