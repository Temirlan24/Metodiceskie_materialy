using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class PersonClass
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public void Show()
        {
            Console.WriteLine($"ФИО: {FullName}\nВозраст: {Age}\nНомер телефона: {PhoneNumber}");
        }
    }
}