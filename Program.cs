namespace TheLostWorld;

class Program
{
    static void Main(string[] args)
    {
        if (Directory.Exists("Saves"))
        {
            Directory.CreateDirectory("Saves");
        }
        Game game= new Game();
    }
}
