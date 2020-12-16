using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class SecondClass
    {
        public SecondClass()
        {
            first = new FirstClass();
        }
        public void Demo1()
        {
            first.RequiredMethod();
            Console.WriteLine("It's a demo");
        }
        public void Demo2()
        {
            first.RequiredMethod();
            Console.WriteLine("It's a demo too");
        }
        private FirstClass first;
    }
}