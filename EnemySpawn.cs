namespace TheLostWorld;

public class EnemySpawn
{
    string? name;
    static double eHealth;
    int escapeChance;
    int stamina;
    int attackPower;
    int armor;

    Drops drop = new Drops();

    public void Slime(int level)
    {
        eHealth = 5 * level;
        stamina = 5 * level;
        escapeChance = 80;
        attackPower = 3 * level;
        armor = 5;
        name = "Slime";


        Combat combat = new Combat(name, eHealth, escapeChance, stamina, attackPower, armor);
        Console.Clear();
        if (!Game.currentPlayer.ranAway)
        {
            drop.SlimeDrops(Game.currentPlayer.inventory);
        }
    }
}
