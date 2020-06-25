using System;

namespace Aula25
{
    public class Tribonacci
    {
        public void GerarSequenciaTribonacci(int num1, int num2, int num3, int parada){
            //condição crucial de parada da recursividade
            if(parada>=0){
                
                Console.WriteLine(num1);
                
                GerarSequenciaTribonacci(num2, num3, num1 + num3 + num2, parada - 1 );
            }
            
            }
    }
}