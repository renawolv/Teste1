using System;
using System.Linq;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInicial = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arrFinal = new int[10];

            for (int i = 1; i <= arrInicial.Length; i++)
            {
                arrFinal[i-1] = arrInicial[arrInicial.Length - i];
            }

            Console.WriteLine("arrInicial [{0}]", string.Join(", ", arrInicial));
            Console.WriteLine("arrFinal [{0}]", string.Join(", ", arrFinal));
        }
    }
}
