using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPatern_Chain_Of_Responses
{
    class Program
    {
        static void Main(string[] args)
        {
            Banana_Havatel havatel1 = new Banana_Havatel();
            Orange_Havatel havatel2 = new Orange_Havatel();
            Coockie_Havatel havatel3 = new Coockie_Havatel();
            havatel1.next_havatel = havatel2;
            havatel2.next_havatel = havatel3;

            havatel1.toEat("Шини від машини");


            havatel1.toEat("Печенька");
            Console.Read();

        }
    }



    
   abstract public class Havatel
    {
   
       public string havka;
       public Havatel next_havatel;
       public abstract void toEat(string the_havka);

    }
    public class Banana_Havatel : Havatel
    {

      
        public override void toEat(string the_havka)
        {
            havka = the_havka;
            if (havka == "Банан") { Console.WriteLine("Хаватель Бананів: Хаваю "+havka+"... "); }
            else
            {
                if (next_havatel != null)
                {
                    Console.WriteLine("Хаватель Бананів: Я "+havka+" не хаваю, так шо даю следующему. ");
                    next_havatel.toEat(havka);
                } else { Console.WriteLine("Хаватель Бананів: Хавателів більше нема, так шо ніхто більше не буде хавати. "); }
            }
        }
    }

    public class Orange_Havatel : Havatel
    {


        public override void toEat(string the_havka)
        {
            havka = the_havka;
            if (havka == "Апельсин") { Console.WriteLine("Хаватель Апельсинів: Хаваю " + havka + "... "); }
            else
            {
                if (next_havatel != null)
                {
                    Console.WriteLine("Хаватель Апельсинів: Я " + havka + " не хаваю, так шо даю следующему. ");
                    next_havatel.toEat(havka);
                }
                else { Console.WriteLine("Хаватель Апельсинів: Хавателів більше нема, так шо ніхто більше не буде хавати. "); }
            }
        }
    }


    public class Coockie_Havatel : Havatel
    {


        public override void toEat(string the_havka)
        {
            havka = the_havka;
            if (havka == "Печенька") { Console.WriteLine("Хаватель Печеньок: Хаваю " + havka + "... "); }
            else
            {
                if (next_havatel != null)
                {
                    Console.WriteLine("Хаватель Печеньок: Я " + havka + " не хаваю, так шо даю следующему. ");
                    next_havatel.toEat(havka);
                }
                else { Console.WriteLine("Хаватель Печеньок: Хавателів більше нема, так шо ніхто більше не буде хавати. "); }
            }
        }
    }

    


}
