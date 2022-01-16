using System;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите цифру:");
            int select = Convert.ToInt32(Console.ReadLine());
            if(select <= 50)
            {
                Console.WriteLine("Вариант меньше 50");
            }
            else
            {
                Console.WriteLine("Вариант больше 50");
            }
        }
    }
}
