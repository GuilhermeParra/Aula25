using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci rec = new Fibonacci();
            Console.ForegroundColor = ConsoleColor.Blue;
            rec.GerarSequenciaFibonacci(0,1,15);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(rec.GerarFatorial(5));

            Tribonacci soma = new Tribonacci();
            Console.ForegroundColor = ConsoleColor.Yellow;
            soma.GerarSequenciaTribonacci(0,1,1,15);
        }
    }
}
