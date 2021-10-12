using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Work3
{
    class Telephone : Person
    {
        public static void ShowTelephone()
        {
            Trace.WriteLine("========== Информация про телефон ==========");
            Trace.WriteLine("Номер телефона: " + telephone + " Тип: " + telephone.GetTypeCode());
        }
    }
}
