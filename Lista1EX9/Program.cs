using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um Número: ");
            a = int.Parse(Console.ReadLine());
            int rest = a % 2;
            if (rest == 0) { Console.WriteLine("O Numero é Par"); }
            else { Console.WriteLine("O Número é Impar"); }

            Console.ReadKey();
        }
    }
}
