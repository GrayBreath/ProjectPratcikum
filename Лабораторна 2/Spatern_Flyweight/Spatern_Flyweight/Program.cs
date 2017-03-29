using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatern_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();
            list.Add(ShapeFactory.GetShape("Круг"));
            list.Add(ShapeFactory.GetShape("Прямокутник"));
            list.Add(ShapeFactory.GetShape("Круг"));
            list.Add(ShapeFactory.GetShape("Точка"));
            list.Add(ShapeFactory.GetShape("Круг"));
            Random r = new Random();
            foreach (var x in list)
            {
                
                x.Drow(r.Next(50),r.Next(80));
                Console.WriteLine();
            }
            Console.Read();

        }

        public static class ShapeFactory
        {

            static Dictionary<string, Shape> collection = new Dictionary<string, Shape>();

            public static Shape GetShape(string desc)
            {
                Shape shape=null;
                try { shape = collection[desc]; } catch { }

                if (shape == null)
                { 
                if (desc == "Круг") shape = new Circle(); 
                if (desc == "Прямокутник") shape = new Rect();
                if (desc == "Точка") shape = new Point();
                    collection.Add(desc, shape);
                }


                return shape;
            }

        }


        public abstract class Shape
        {
         public abstract void Drow(int x, int y);
        }

        public class Circle : Shape
        {
            int r=5;
            public override void Drow(int x, int y)
            {
                Console.Write("("+x.ToString()+")"+ "(" + y.ToString() + ")" +": Рисуємо круг з радіусом "+r.ToString());
            }
        }

        public class Rect : Shape
        {
            int a = 25;             
            public override void Drow(int x, int y)
            {
                Console.Write("(" + x.ToString() + ")" + "(" + y.ToString() + ")" + ": Рисуємо прямокутник з радіусом " + a.ToString()) ;
            }
        }

        public class Point : Shape
        {

            public override void Drow(int x, int y)
            {
                Console.Write("(" + x.ToString() + ")" + "(" + y.ToString() + ")" + ": Рисуємо точку.  ");
            }
        }



    }
}
