using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    interface Developer
    {
        void WritesCode();
    }


    interface DeveloperFactroy
    {
        Developer createDeveloper();
    }

    class CppDeveloperFactory : DeveloperFactroy
    {
        public Developer createDeveloper()
        {
            return new CppDeveloper();
        }
    }

    class JavaDeveloperFactory : DeveloperFactroy
    {
        public Developer createDeveloper()
        {
            return new JavaDeveloper();
        }
    }




    class CppDeveloper : Developer
    {
        public void WritesCode()
        {
            Console.WriteLine("C++ developer writes c++ code...");
        }
    }
    class JavaDeveloper : Developer
    {
        public void WritesCode()
        {
            Console.WriteLine("Java developer writes Java code...");
        }
    }



    class Program
    {
        static bool EquelsIgnoreCase(String a,String b)
        {
            return String.Equals(a, b, StringComparison.OrdinalIgnoreCase);
          
        }

        static DeveloperFactroy createDeveloperBylang(String lang)
        {
            if (EquelsIgnoreCase(lang, "java")) { return new JavaDeveloperFactory();  }

            else if (EquelsIgnoreCase(lang, "c++")) { return new CppDeveloperFactory(); }

           else { throw new Exception(lang+" is unknown lang"); }

        }


        static void Main(string[] args)
        {
            DeveloperFactroy df = createDeveloperBylang("c++");
            Developer dev = df.createDeveloper();
            dev.WritesCode();


            df = createDeveloperBylang("java");
            dev = df.createDeveloper();
            dev.WritesCode();




            Console.Read();
        }
    }
}
