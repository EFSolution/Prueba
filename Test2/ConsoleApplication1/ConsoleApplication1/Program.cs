using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = prueba();
            Console.WriteLine(h);
            Console.ReadKey();
        }

        public static int prueba()
        {
            var a = "";
            var i = 2;
            var l = 4;
            var r = i + l;
            return r;

        }

    }
}
