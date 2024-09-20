
using System.Runtime.Serialization.Formatters.Binary;

namespace TheLostWorld;

public class Game
{
    public static Player currentPlayer = new Player();
    MainMenu mainMenu = new MainMenu();

    public Game()
    {
        if (Directory.Exists("Saves"))
        {
            Directory.CreateDirectory("Saves");
        }
    }

    static void Start()
    {

    }

    public static void Save()
    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
        BinaryFormatter binForm = new BinaryFormatter();
        string path = "Saves/" + currentPlayer.id.ToString();
        FileStream file = File.Open(path, FileMode.OpenOrCreate);
        binForm.Serialize(file, currentPlayer);
        file.Close();
    }

    public static Player Load()
    {
        Console.Clear();
        string[] paths = Directory.GetFiles("Saves");
        List<Player> players = new List<Player>();

        BinaryFormatter binForm = new BinaryFormatter();
        foreach (string p in paths)
        {
            FileStream file = File.Open(p, FileMode.Open);
            Player player = (Player)binForm.Deserialize(file);
            file.Close();
            players.Add(player);
        }

        while (true)
        {
            Console.Clear();
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
                else if(data[0] == "create")
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
}
