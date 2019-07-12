using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota t = Toyota.createToyota();
            BMW b = BMW.createBMW();
            Thread thread1 = new Thread(t.run); //Put the Toyota in thread and start run
            Thread thread2 = new Thread(b.run); //Put the BMW in thread and start run
            thread1.Start(); //Start thread1
            thread2.Start(); //Start thread2
        }
    }
}
