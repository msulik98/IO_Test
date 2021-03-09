using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {
        public static int  Calculate(string s)
        {
            if (s == null) return 0;
            else if (s.Length == 0) return 0;

            string[] liczby = s.Split(',', '\n');
            if (liczby.Length == 1) return int.Parse(liczby[0]);

            int suma = 0;
            foreach (var item in liczby)
            {
                suma += int.Parse(item);
            }
            return suma;
        }
    }
}
