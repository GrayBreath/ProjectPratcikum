using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatern_Bridge
{
    abstract class _Application
    {
        protected Developer developer;

       public _Application(Developer dev) { developer = dev;  }

        public abstract void developProgram();

    }

    class DBsystem : _Application
    {
    public DBsystem(Developer dev):base(dev)
        {
            
        }
       public override void developProgram()
        {
            Console.WriteLine("DBsystem in progress...");
            developer.writeCode();
        }
    }
    class AISsystem: _Application
    {
       public AISsystem(Developer dev) : base(dev)
        {

        }
        public override void developProgram()
        {
            Console.WriteLine("DBsystem in progress...");
            developer.writeCode();
        }
    }

}
