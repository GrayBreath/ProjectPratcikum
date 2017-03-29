using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatern_Bridge
{
    class Program
    {
    

        static void Main(string[] args)
        {
            _Application[] programs = 
            {
                new DBsystem(new CSharpDev()),
                new AISsystem(new JavaDev())
            };

            foreach (var p in programs)
            {
                p.developProgram();
            }
          
            // Змінюємо реалізацію розробників.
            programs[0] = new DBsystem(new JavaDev());
            programs[1] = new AISsystem(new CSharpDev());
            foreach (var p in programs)
            {
                p.developProgram();
            }
            Console.Read();


        }
    }
}
