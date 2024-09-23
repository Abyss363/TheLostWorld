namespace TheLostWorld;

public class Dungeons
{
    EnemySpawn enemySpawn = new EnemySpawn();
    Random rand = new Random();


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
        }
        while (spawnCount < spawnNumber && Game.currentPlayer.health > 0);
        spawnCount = 0;
    }
}
