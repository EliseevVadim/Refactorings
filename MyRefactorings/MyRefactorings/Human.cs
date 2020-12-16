using System;
using System.Collections.Generic;
using System.Text;

namespace MyRefactorings
{
    class Human
    {
        public Human(int age, bool withOWnFlat)
        {
            age_ = age;
            withOWnFlat_ = withOWnFlat;
        }
        public void GiveOwnFlat()
        {
            withOWnFlat_ = true;
            Console.WriteLine("Now this person has his own flat");
        }
        public int GetAge()
        {
            return age_;
        }
        public bool IsFlatOwner()
        {
            return withOWnFlat_;
        }
        private int age_;
        private bool withOWnFlat_;
    }
}
