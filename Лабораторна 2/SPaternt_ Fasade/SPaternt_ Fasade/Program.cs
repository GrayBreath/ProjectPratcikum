using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPaternt__Fasade
{
    class Program
    { 
        static void Main(string[] args)
        {
            Fasade_GameClient.UseSkill(2);
            Fasade_GameClient.UseSkill(0);
            Fasade_GameClient.UseSkill(1);

            Console.Read();
        }
    }


    public class Skill
    {
        public int id;
        public float range, damage;
        public string animation;
        public Skill()
        {
            id = 0;
            range = 0;
            damage = 0;
            animation = "Standart Animation";
        }
        public void Render()
        {
            Console.WriteLine("Rendering animation of skill...");
        }
    }

    public class Player
    {
        public int hp, mp;
        public string Position;
        public void UseSkill()
        {
            var someskill = new Skill();
            someskill.Render();
        }
    }

    public class CharManager
    {
        public Player setofplaers;
         public CharManager()
        {
            setofplaers = new Player();

        }
        public void AllSetPosition()
        {
            setofplaers.Position = "Start Posiotion"; 
        }
    }

    static class Fasade_GameClient // Цей класс і є фасадом.
    {
        public static CharManager charManager = new CharManager();
        public static void UseSkill(int id)
            {
            Console.WriteLine("Charapter "+id.ToString()+ " now cast a spell.");
            charManager.setofplaers.UseSkill();
            }

    }



}
