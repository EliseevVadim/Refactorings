using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class FirstClass
    {
        public FirstClass()
        {
            second = new SecondClass();
        }        
        public void ExampleMethod()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
            second.RequiredMethod();
        }
        private SecondClass second;
    }
}