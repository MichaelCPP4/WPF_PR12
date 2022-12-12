using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    static public class Class
    {
        /// <summary>
        /// Метод для вычисления площади и периметра квадрата
        /// </summary>
        /// <param name="a">Сторона квадрата</param>
        /// <param name="s">Возвращаемое значение: площадь</param>
        /// <param name="p">Возвращаемое значение: периметр</param>
        static public void SundP(int a, out int s, out int p)
        {
            s = a*a;
            p = a*4;
        }
        /// <summary>
        /// Метод меняет местами единицы и десятки, откидывая сотни
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public string SwitchNumber(int number)
        {
            string s = String.Empty;

            s += number % 10;
            number /= 10;
            s += number % 10;
           /* for (int i = 0; i < 3; i++)
            {
                s += (number % 10).ToString();
                number/= 10;
            }*/
            return s;
        }
    }
}
