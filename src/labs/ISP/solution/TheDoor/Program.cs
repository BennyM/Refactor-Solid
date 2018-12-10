using System;

namespace TheDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerService service = new TimerService();
            var frontDoor = new TimedDoor(service);
            frontDoor.Unlock();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
