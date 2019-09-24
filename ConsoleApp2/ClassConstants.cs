using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ClassConstants
    {
        private const double pi = 3.14159265359;
        private const double gravitationalValue = 9.8;
        public void Show()
        {
            Console.WriteLine($"Число Пи: {pi}\nСвободное падение: {gravitationalValue}");
        }
    }
}
