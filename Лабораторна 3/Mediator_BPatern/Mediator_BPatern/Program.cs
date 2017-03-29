using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_BPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager MainGameManager = new GameManager();
            Player Vasya = new Player("Vasya", MainGameManager);
            Player Lykan = new Player("Lykan", MainGameManager);
            Player Gorch = new Player("Gorch", MainGameManager);
            MainGameManager.players.Add(Vasya);
            MainGameManager.players.Add(Lykan);
            MainGameManager.players.Add(Gorch);
            MainGameManager.CheckMiniMap();

            Vasya.Move();

            MainGameManager.CheckMiniMap();
            Console.ReadKey();

        }

        public class GameManager
        {
            public List<Player> players = new List<Player>();
            public void CheckMiniMap()
            {
                foreach (var pl in players) { pl.CheckMiniMap(); }
            }
            
        }

        public class Player
        {
            GameManager gm;
            int x, y, z;
            string name;
          public  Player(string Name, GameManager GM) { name = Name; gm = GM; }
            public void Move()
            {
                x++;y++;z++;
            }

            public void CheckMiniMap()
            {
                foreach (var pl in gm.players)
                {
                    Console.WriteLine("Гравець "+name+" побачив що у гравця "+pl.name+ " такі координати.");
                    Console.WriteLine("X: " +pl.x);
                    Console.WriteLine("X: " + pl.y);
                    Console.WriteLine("X: " + pl.z);
                }

            }

        }


    }
}
