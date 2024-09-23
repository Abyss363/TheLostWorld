namespace TheLostWorld;

public class Item
{
    public string Name { get; set; }
    public int Count { get; set; }

    public Item(string name, int count)
    {
        Name = name;
        Count = count;
    }

    // For displaying the item
    public override string ToString()
    {
        return $"{Name} (x{Count})";
    }
}

