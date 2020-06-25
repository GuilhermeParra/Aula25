using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci rec = new Fibonacci();
            rec.GerarSequenciaFibonacci(0,1,1,15);
            Console.WriteLine(rec.GerarFatorial(5));
        }
    }
}
