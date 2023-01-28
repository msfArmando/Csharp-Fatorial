using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FATORIAL");
            Console.WriteLine("--------");

            Console.WriteLine("De qual número você quer saber o fatorial? ");
            int fatorial = int.Parse(Console.ReadLine());

            int num = 1;
            int res = 0;
            for(int n = 1; n <= fatorial; n++)
            {
                res = num * n;
                num = res;
            }
            Console.WriteLine("O fatorial de " + fatorial + " é igual a: " + res);
            Console.ReadLine();
        }
    }
}
