using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades_02_parte_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro número.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número.");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c) ;
            {
                Console.WriteLine(" o maior número é " + a);
                if (b > a && b > c) ;

                Console.WriteLine(" o maior número é " + b);
                if (c > a && c > b) ;

                Console.WriteLine(" o maior número é " + c);
                

            }
        }
    }
}
