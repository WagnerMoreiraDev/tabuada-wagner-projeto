using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa Tabuada 2");
            for (int multiplicar = 1; multiplicar <= 10; multiplicar++)
            {
                for (int contar = 0; contar <= 10; contar++)
                {
                    Console.Write(multiplicar + "*" + contar + "=" + multiplicar * contar);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
