namespace TheLostWorld;

public class World
{
    public World()
    {
        EnemySpawn spawnEnemy = new EnemySpawn();
        Story story = new Story();
        

        Console.WriteLine($"You are {Game.currentPlayer.name}");
        story.OpeningScene();
        FirstTown firstTown= new FirstTown();
        
        
    }
    
}
