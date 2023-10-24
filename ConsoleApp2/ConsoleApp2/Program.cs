using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public class Game
        {
            public string[] rooms = new string[] { "start(1, 2)", "second(0, 4)"};
            public int index_room_now = 0;

            public string Get_room()
            {
                string room = rooms[index_room_now]; 
                return room;
            }
            public string change_room()
            {
                string room = rooms[index_room_now];
                return room;
            }

        }

        public class Player
        {
            public string name;
            public bool live = true;

            public Player(string name_player)
            {
                name = name_player;
            }

            public void start()
            {
                Console.WriteLine("Start game");
            }
        }
        static void Main(string[] args)
        {
            //Game game = new Game("Borikmm");
            //game.start();
  
        }
    }
}
