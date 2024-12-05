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
            return (farenheit - 32) * 5 / 9;
        } 

        public static decimal ConvertCtoF(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }


    }
}
