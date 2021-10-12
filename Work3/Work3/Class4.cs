using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work3
{
    class Email : Person
    {
        public static void ShowEmail()
        {
            Trace.WriteLine("========== Информация про почту ==========");
            Trace.WriteLine("Почта: " + email + " Тип: " + email.GetTypeCode());
        }
    }
}
