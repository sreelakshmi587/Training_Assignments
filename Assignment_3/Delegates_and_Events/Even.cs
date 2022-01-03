using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void Mydel();
    class Even
    {
        public event Mydel Programexecuted;
        public void Findeven()
        {
            Console.WriteLine( "Printing even numbers");
            for(int num = 1; num <= 100; num++)
            {
               
                if (num%2==0)
                    Console.WriteLine(num); 
            }
            OnProgramexecuted();
        }

        protected virtual void OnProgramexecuted()
        {
            Programexecuted?.Invoke();
        }
    }
}
