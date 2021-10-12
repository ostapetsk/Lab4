using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work3
{
    class Passport : Person
    {
        public static void ShowPassport()
        {
            Trace.WriteLine("========== Информация про Паспорт ==========");
            Trace.WriteLine("Имя: " + name + " Тип: " + name.GetTypeCode());
            Trace.WriteLine("Фамилия: " + surname + " Тип: " + surname.GetTypeCode());
            Trace.WriteLine("Возраст: " + age + " Тип: " + age.GetTypeCode());
            Trace.WriteLine("Страна: " + country + " Тип: " + country.GetTypeCode());
        }
    }
}
