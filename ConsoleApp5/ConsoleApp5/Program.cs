using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human[] humans = new Human[]
            {
            new Human(10,"Abbas","Aliyev"),
            new Human(20,"Rafet","Mammadov"),
            new Human(30,"Rasim","Kazimov"),
            new Human(40,"Elekber","Veliyev"),

            };
            Console.WriteLine("Axtaris deyerini daxil edin");
            string search = Console.ReadLine();
            
            foreach (var item in humans) 
            {
                Console.WriteLine($"{item.Name} {item.Surname}  {item.Age}");
            }

        }
    }
}
