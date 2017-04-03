using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PP
{
  static  class Model
    {
        public static float Multiply(int a, int b)
        {
            float ans= a*b;
            return ans;
        }
        public static float Division(int a, int b)
        {
            float ans = a / b;
            return ans;
        }
        public static float Substract(int a, int b)
        {
            float ans = a - b;
            return ans;
        }
        public static float Adding(int a, int b)
        {
            float ans = a + b;
            return ans;
        }
    }
}
