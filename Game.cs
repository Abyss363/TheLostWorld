
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


namespace TheLostWorld;

public class Game
{
    public static Player currentPlayer = new Player();
    public static bool isDead = false;
    MainMenu mainMenu = new MainMenu();


    public Game()
    {
        if (!Directory.Exists("Saves"))
        {
            Directory.CreateDirectory("Saves");
        }
    }

    static void Start()
    {

    }

    public static void Save()
    {
            string path = "Saves/" + currentPlayer.id.ToString() + ".json";
            string jsonData = JsonSerializer.Serialize(currentPlayer);

            // Log what is being serialized
            Console.WriteLine("Saving Player Data: " + jsonData);

            File.WriteAllText(path, jsonData);
            Console.WriteLine($"Player data saved to: {path}");
    }


    public static Player Load()
    {
        try
        {
            string[] paths = Directory.GetFiles("Saves", "*.json");
            List<Player> players = new List<Player>();

            foreach (string p in paths)
            {
                string jsonData = File.ReadAllText(p);
                Player player = JsonSerializer.Deserialize<Player>(jsonData)!;
                players.Add(player);

                // Log the deserialized player
                Console.WriteLine($"Loaded player: {player.name}, {player.race}, {player.playerClass}");
            }

            while (true)
            {
                Console.WriteLine("Choose your save.");

                foreach (Player p in players)
                {
                    Console.WriteLine(p.id + ": " + p.name);
                }

                Console.WriteLine("Please enter player name or id (id:# or playername), 'create' will start a new save");
                string[] data = Console.ReadLine()!.Split(':');

                try
                {
                    if (data[0] == "id")
                    {
                        if (int.TryParse(data[1], out int id))
                        {
                            foreach (Player player in players)
                            {
                                if (player.id == id)
                                {
                                    return player;
                                }
                            }
                            Console.WriteLine("No player with that id!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your id needs to be a number! Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    else if (data[0] == "create")
                    {

                    }
                    else
                    {
                        foreach (Player player in players)
                        {
                            if (player.name == data[0])
                            {
                                return player;
                            }
                        }
                        Console.WriteLine("No player with that name!");
                        Console.ReadKey();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your id needs to be a number! Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading player data: " + ex.Message);
            return null!;
        }

    }
}
