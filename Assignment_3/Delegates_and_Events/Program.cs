using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Even even = new Even();
            even.Programexecuted += even_Programexecuted;
            even.Findeven();
        }

        private static void even_Programexecuted()
        {
            Console.WriteLine("Printed the required Even numbers!");
        }
    }
}
