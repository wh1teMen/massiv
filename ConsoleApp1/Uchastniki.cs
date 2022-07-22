using System;
using System.Collections.Generic; //колекции
using System.Linq; // сортировка и работа с массивом
using System.Text; //для работы с string
using System.Threading.Tasks;//многопоточность
namespace ConsoleApp1
{//участники соревнований по спортивному ориентрованию

    class Uchastniki  
    {
        public Uchastniki(int id, string name,  int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Uchastniki(int id)
        {
            Id = id;
            Name =vod("Введите ФИО участника:  ");

            Age =vod_age("Введите фозраст участника:  ");
        }
        
        string vod(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
      public  static int vod_age(string text)
        {
            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("что то пошло не так");
               return  vod_age(text);
                
            }
        }



        //свойства
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID Участника: { Id } \nИмя: { Name }\nВозраст: {Age}\n" ;
        }



    }
}
