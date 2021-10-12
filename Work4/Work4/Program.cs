using System;

namespace Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ доступа: ");
            ApplicationLicense.Key = Console.ReadLine();
            ApplicationLicense example = new ApplicationLicense();
        }
    }
}
