using System;

namespace MyRefactorings
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintTimeNow();
            SecondClass secondClass = new SecondClass();
            secondClass.Demo1();
            secondClass.Demo2();
            FirstClass first = new FirstClass();
            first.ExampleMethod();
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