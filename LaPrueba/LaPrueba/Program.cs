using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("primer valor: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("segundo valor: ");
            b = Int32.Parse(Console.ReadLine());
            c = a + b;
            Console.Write("el resultado final de la suma es " + c);
            Console.ReadKey();
        }
    }
}
