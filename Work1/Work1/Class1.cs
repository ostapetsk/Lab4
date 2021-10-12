using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work1
{
    class Main
    {
        public static string input, output = "";
        public static int integer;
        public static double doubl;
        public static char ch;
        public static bool boo, IsTrue;
        public static void Input()
        {
            Console.WriteLine("Введите любое значение: ");
            input = Console.ReadLine();
            IsTrue = int.TryParse(input, out integer);
            if (IsTrue == true)
            {
                output += "Тип: int ";
            }
            IsTrue = double.TryParse(input, out doubl);
            if (IsTrue == true)
            {
                output += " Тип: double ";
            }
            IsTrue = char.TryParse(input, out ch);
            if (IsTrue == true)
            {
                output += " Тип: char ";
            }
            IsTrue = bool.TryParse(input, out boo);
            if (IsTrue == true)
            {
                output += " Тип: bool ";
            }
            input = ("http://Значение" + input + "");
            Trace.WriteLine(input);
            Trace.Write(output + " Тип: string  ");
        }
    }
}
