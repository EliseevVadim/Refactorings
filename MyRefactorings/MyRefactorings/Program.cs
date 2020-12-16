using System;

namespace MyRefactorings
{

    class Program
    {
       // private const int adults_age = 18;
        static void Main(string[] args)
        {
            //PrintTimeNow();
            //SecondClass secondClass = new SecondClass();
            //secondClass.Demo1();
            //secondClass.Demo2();
            //FirstClass first = new FirstClass();
            //first.ExampleMethod();            
            //Human human = new Human(25, false);
            //if (human.GetAge() > adults_age && !human.IsFlatOwner())
            //{
            //    human.GiveOwnFlat();
            //}
            //DateTime dateTime = DateTime.Now;
            //int month = dateTime.Month;
            //if (IsWinter(month))
            //{
            //    Console.WriteLine("It's winter!");
            //}
            //else
            //{
            //    Console.WriteLine("It's not winter");
            //}
            
        }
        static bool IsGoodOne(Student student)
        {
            if (student.GetMark() >= 90)
                return true;
            if (student.GetAllTestsCount() == student.GetPassedTests())
                return true;
            return false;
        }
        static bool IsWinter(int month)
        {
            return month == 12 || month == 1 || month == 2;
        }
        static void PrintTimeNow()
        {
            DateTime dt = DateTime.Now;
            int hours = dt.Hour;
            int mins = dt.Minute;
            int secs = dt.Second;
            Console.WriteLine($"Сейчас:\n{hours} часов\n{mins} минут\n{secs} секунд");
        }
    }
}