using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13DemoB
{
    public static class Tools
    {
        public static decimal ConvertFtoC(decimal farenheit)
        {
            return Math.Round((farenheit - 32) * 5 / 9,2);
        } 

        public static decimal ConvertCtoF(decimal celsius)
        {
            return Math.Round(celsius * 9 / 5 + 32,2);
        }


    }
}
