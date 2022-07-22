using System;
using System.Collections.Generic;

namespace ConsoleApp1
{    class Program


    {
        static void Main(string[] args)
        {
           int count = Uchastniki.vod_age("Введите кол-во участников");
           List <Uchastniki> uchastniki = new List <Uchastniki>();
           for (int i = 0; i <count ; i++)
            {
                uchastniki.Add(new Uchastniki(i+1));
            }

           void vyvod()
            {
                Console.WriteLine("Все участники: ");
                foreach(var item in uchastniki)
                {
                    Console.WriteLine(item.ToString());
                }
            }

          
            Console.WriteLine("\nВсе участники: ");
            foreach (var item in uchastniki)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("[1] Добавить участника ");
            switch (Console.ReadLine())
            {
                    case "1":
                    uchastniki.Add(new Uchastniki(uchastniki.Count)); vyvod(); break;
                    default: break;
            }     
        }
    }
}

