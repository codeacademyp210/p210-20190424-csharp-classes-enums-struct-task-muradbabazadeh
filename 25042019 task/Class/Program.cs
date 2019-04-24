using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin:");
            Student std1 = new Student();
            std1.Name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            std1.Surname = Console.ReadLine();
            Console.WriteLine("Qrupunuzu daxil edin:");
            Group.name = Console.ReadLine();
            Console.WriteLine("Salam" + " "+std1.Name + " " + std1.Surname + ".Sizin qrupunuz:" + Group.name);
            Console.ReadLine();
        }
    }
    class Group
    {
      public static string name;

    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
