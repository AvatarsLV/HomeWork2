using System;

namespace ConsoleHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā Tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Sveiks, {userName}");
            Console.WriteLine("=============================================================");

            Console.WriteLine("Kāds ir Tavs vecums?");
            string userAge = Console.ReadLine();

            int age = int.Parse(userAge);
            int ageNextYear = age + 1;
            bool Is18 = age >= 18;


            Console.WriteLine($"Nākamgad Tev paliks {ageNextYear}, Tu esi pilngadīgs:  {Is18}");


        }
    }
}
