using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            Arithematic a = new Arithematic();
            Console.WriteLine(a.sum(x,y));
            Console.WriteLine(a.sub(x, y));

        }
    }
}
