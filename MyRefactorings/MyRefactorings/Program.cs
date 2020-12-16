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
            //int x = int.Parse(Console.ReadLine());
            //if (x > 9 || x < -9) 
            //{
            //    Console.WriteLine("Число двузначное");                
            //}
            //else
            //{
            //    Console.WriteLine("Число однозначное");
            //}
            //Console.WriteLine("Сравнено!");
            //Child1 ch1 = new Child1();
            //ch1.PrintInfo();
            //Child2 ch2 = new Child2();
            //ch2.PrintInfo();
            Child3 ch3 = new Child3();
            ch3.ShowMessage();
        }
        static bool IsGoodOne(Student student)
        {
            if (student.GetMark() >= 90 || student.GetAllTestsCount() == student.GetPassedTests())
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