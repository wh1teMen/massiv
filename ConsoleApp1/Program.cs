using System;

namespace ConsoleApp1
{    class Program


    {
        static void Main(string[] args)
        {
    
           Uchastniki[] uchastniki = new Uchastniki[3];
           for (int i = 0; i < uchastniki.Length; i++)
            {
                uchastniki[i] = new Uchastniki(i+1);
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
                    Array.Resize(ref uchastniki, uchastniki.Length + 1);
                    uchastniki[uchastniki.Length - 1] = new Uchastniki(uchastniki.Length); break;
                    default: break;
            }     

            

        }
    }
}

