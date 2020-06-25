using System;

namespace Aula25
{
    public class Fibonacci
    {
        public void GerarSequenciaFibonacci(int num1, int num2, int parada){
            //condição crucial de parada da recursividade
            if(parada>=0){
                
                Console.WriteLine(num1);
                
                GerarSequenciaFibonacci(num2, num1 + num2, parada - 1 );
            }
            
            }
            public int GerarFatorial(int numero){
                if(numero == 1){
                    return 1;
                }else{
                    return numero * GerarFatorial(numero-1);
                }



        }
    }
}