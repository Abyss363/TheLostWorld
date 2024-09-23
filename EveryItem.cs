namespace TheLostWorld;

public class EveryItem
{
    public List<Item> Items { get; set; } = new List<Item>();

    // Add item or update count
    public void AddItem(string itemName, int count)
    {
        var item = Items.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            item.Count += count; // Update count if item exists
        }
        else
        {
            Items.Add(new Item(itemName, count)); // Add new item if it doesn't exist
        }
    }

    // Use an item
    public bool UseItem(string itemName, int count = 1)
    {
        var item = Items.FirstOrDefault(i => i.Name == itemName);
        if (item != null && item.Count >= count)
        {
            item.Count -= count; // Reduce the count
            if (item.Count == 0)
                Items.Remove(item); // Remove item if count reaches 0
            return true;
        }
        return false; // Not enough items or item doesn't exist
    }

    // Display inventory
    public void DisplayInventory()
    {
        if (Items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
        }
        else
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public bool CombatUseItem(string itemName, int count = 1)
    {
        ItemEffects applyEffects = new ItemEffects();
        // Check if the item exists in the player's inventory
        var item = Game.currentPlayer.inventory.Items.FirstOrDefault(i => i.Name == itemName);

        if (item != null && item.Count > 0)
        {
            item.Count--; // Decrease the item count
            applyEffects.ApplyItemEffects(item); // Apply the item's effect, e.g., healing, mana, etc.
            return true; // Indicate the item was used successfully
        }

        return false; // Item not found or no more left to use
    }
}
