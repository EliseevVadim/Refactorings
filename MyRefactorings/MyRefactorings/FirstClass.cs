using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class FirstClass
    {
        public FirstClass()
        {

        }
        public void RequiredMethod()
        {
            Console.WriteLine("Wanna to go to Second Class");
        }
        public void ExampleMethod()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
            RequiredMethod();
        }
    }
}
