using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    static public class Class
    {
        static public void SundP(int a, out int s, out int p)
        {
            s = a*a;
            p = a*4;
        }

        static public int SwitchNumber(int number)
        {
            //string s = Convert.ToString(number % 10) + Convert.ToString(number / 10);
            return int.Parse(Convert.ToString(number % 10) + Convert.ToString(number / 10));
        }
    }
}
