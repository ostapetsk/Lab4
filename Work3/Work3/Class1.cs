using System;
using System.Collections.Generic;
using System.Text;

namespace Work3
{
    class Person
    {
        public static string name = "Vova";
        public static string surname = "Petrov";
        public static int age = 25;
        public static string email = "123abc@gmail.com";
        public static string country = "Ukraine";
        public static string telephone = "+380123456789";
        public Person()
        {
            Passport.ShowPassport();
            Telephone.ShowTelephone();
            Email.ShowEmail();
        }
    }
}
