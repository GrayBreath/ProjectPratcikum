using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_PP
{
    public static class Controller
    {
        static public Form1 view;

        static public void MultiPlyButton(string a, string b)
        {
            var a_int = int.Parse(a);
            var b_int = int.Parse(b);
            var ans = Model.Multiply(a_int,b_int);
            view.View_ShowResult(ans.ToString());

        }  
        static public void DivisionButton (string a, string b)
        {
            var a_int = int.Parse(a);
            var b_int = int.Parse(b);
            var ans = Model.Division(a_int, b_int);
            view.View_ShowResult(ans.ToString());

        }
        static public void AddingButton(string a, string b)
        {
            var a_int = int.Parse(a);
            var b_int = int.Parse(b);
            var ans = Model.Adding(a_int, b_int);
            view.View_ShowResult(ans.ToString());

        }
        static public void SubstractButton(string a, string b)
        {
            var a_int = int.Parse(a);
            var b_int = int.Parse(b);
            var ans = Model.Substract(a_int, b_int);
            view.View_ShowResult(ans.ToString());

        }

    }


}
