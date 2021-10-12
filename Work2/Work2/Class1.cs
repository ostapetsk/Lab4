using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work2
{
    class Б
    {
        public static string input;
        public Б()
        {
            InputInformation();
        }
        public static void InputInformation()
        {
            B1.firstinput = "";
            B2.secondinput = "";
            B3.thirdinput = "";
            Console.WriteLine("Введите перове значение: ");
            input = (Console.ReadLine());
            B1.firstinput = Convert.ToString(input);
            Show();
            Console.WriteLine("Введите второе значение: ");
            input = Console.ReadLine();
            B2.secondinput = Convert.ToString(input);
            Show();
            Console.WriteLine("Введите третье значение: ");
            input = Console.ReadLine();
            B3.thirdinput = Convert.ToString(input);
            Show();
        }
        public static void Show()
        {
            if (B1.firstinput == input)
            {
                Trace.WriteLine("Название переменной: firstinput");
            }
            if (B2.secondinput == input)
            {
                Trace.WriteLine("Название переменной: secondinput");
            }
            if (B3.thirdinput == input)
            {
                Trace.WriteLine("Название переменной: thirdinput");
            }
            Trace.WriteLine("Значение: " + input);
        }
    }
}
