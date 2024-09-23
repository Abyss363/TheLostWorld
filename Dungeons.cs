namespace TheLostWorld;

public class Dungeons
{
    EnemySpawn enemySpawn = new EnemySpawn();
    Random rand = new Random();
    public bool hasLeft = false;


    public void LeaveDungeon()
    {
        Console.WriteLine("Leave Dungeon Y/N");
        string? input = Console.ReadLine()!.ToLower();
        switch(input)
        {
            case "y":
                hasLeft = true;
                Console.WriteLine("Leaving Dungeon...");
                break;
            case "n":
                hasLeft = false;
                return;
            default:
                Console.WriteLine("Continuing Dungeon Raid");
                return;
        }
    }

    public void SlimeDungeon(int level)
    {
        int spawnNumber = rand.Next(10, 20);
        int spawnCount = 0;

        do
        {
            enemySpawn.Slime(level);
            spawnCount++;
            if(Game.isDead == true)
            {
                return;
            }
            if(Game.currentPlayer.ranAway)
            {
                Console.WriteLine("You continue to run away cowardly from the dungeon");
                return;
            }
            Game.currentPlayer.PlayerMenu();
            LeaveDungeon();
            if(hasLeft)
            {
                hasLeft = false;
                return;
            }
        }
        while (spawnCount < spawnNumber && Game.currentPlayer.health > 0);
        spawnCount = 0;
    }
}
