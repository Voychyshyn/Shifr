using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoUchoba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cezar c = new Cezar(1055);
            Console.WriteLine(c.Code(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}

