using System;
using System.Collections.Generic;
using System.Text;

namespace Work4
{
    class ApplicationLicense
    {
        public static string Key, passwordTrial = "", passwordPro = "";
        public ApplicationLicense()
        {
            int[] massive = new int[5];
            int[] massive1 = new int[10];
            Random n = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = n.Next(0, 9);
                passwordTrial += Convert.ToString(massive[i]);
            }
            for (int i = 0; i < massive1.Length; i++)
            {
                massive1[i] = n.Next(0, 9);
                passwordPro += Convert.ToString(massive1[i]);
            }
            Console.WriteLine("Сгенерированный ключ пробной версии: " + passwordTrial);
            Console.WriteLine("Сгенерированный ключ полной версии: " + passwordPro);
            if (Key == passwordTrial)
            {
                AllowTrial();
            }
            if (Key == passwordPro)
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }
        }
        private static void AllowTrial()
        {
            Console.WriteLine("Триальный режим");
        }
        private static void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия");
        }
        private static void AllowPro()
        {
            Console.WriteLine("Платная версия");
        }
    }
}
