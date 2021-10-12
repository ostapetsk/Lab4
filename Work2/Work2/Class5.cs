using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work2
{
    class A
    {
        private static int integer;
        private static double doubl;
        private static char ch;
        private static bool IsTrue, boo;
        private static string Information, output = "";
        public static string information
        {
            get
            {
                return Information;
            }
            set
            {
                Information = value;
            }
        }
        public A()
        {
           
        }
        public static void Operation()
        {
            IsTrue = int.TryParse(Information, out integer);
            if (IsTrue == true)
            {
                output += "Тип: int";
            }
            IsTrue = double.TryParse(Information, out doubl);
            if (IsTrue == true)
            {
                output += " Тип: double ";
            }
            IsTrue = char.TryParse(Information, out ch);
            if (IsTrue == true)
            {
                output += " Тип: char ";
            }
            IsTrue = bool.TryParse(Information, out boo);
            if (IsTrue == true)
            {
                output += " Тип: bool ";
            }
            output += " Тип: string  ";
            Trace.WriteLine(output);
            output = "";
        }
    }
}
