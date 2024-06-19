using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = SEGUNDOS => 10s = 10 segundos");
            Console.WriteLine("M = MINUTOS => 1m = 1 minuto");
            Console.WriteLine("0 = SAIR DO MENU");
            Console.WriteLine("QUANTO TEMPO DESEJA CONTAR?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length-1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);



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
            Menu();
        }
    }    
}