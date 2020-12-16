using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class SecondClass
    {
        public SecondClass()
        {

        }
        public void Demo1()
        {
            RequiredMethod();
            Console.WriteLine("It's a demo");
        }
        public void Demo2()
        {
            RequiredMethod();
            Console.WriteLine("It's a demo too");
        }
        public void RequiredMethod()
        {
            Console.WriteLine("Wanna to go to Second Class");
        }
    }
}