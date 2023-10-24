public class Game
{
    public string name;
    public bool live = true;

    Game(string name_player)
    {
        name = name_player;
    }

    void start()
    {
        Console.WriteLine("Start game");
    }
}

Game game;
