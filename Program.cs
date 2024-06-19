using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main (string[] args)
        {
            Start(6);
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = SEGUNDOS");
            Console.WriteLine("M = MINUTOS");
            Console.WriteLine("0 = SAIR DO MENU");
            Console.WriteLine("QUANTO TEMPO DESEJA CONTAR?");
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while( currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("StopWatch finalizado!! retornando para o MENU");
            Thread.Sleep(1000);
        }
    }    
}