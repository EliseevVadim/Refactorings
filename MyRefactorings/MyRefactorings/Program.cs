using System;

namespace MyRefactorings
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            int hours = dt.Hour;
            int mins = dt.Minute;
            int secs = dt.Second;
            Console.WriteLine($"Сейчас:\n{hours} часов\n{mins} минут\n{secs} секунд");
        }
    }
}
