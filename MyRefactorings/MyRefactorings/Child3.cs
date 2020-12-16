using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class Child3
    {

        public Child3()
        {
            delegated_parent = new Parent();
        }
        public void PrintInfo()
        {
            Console.WriteLine("I'm only for child 3!!!!!");
        }
        public void ShowMessage()
        {
            delegated_parent.ShowMessage();
        }
        private Parent delegated_parent;
    }
}
