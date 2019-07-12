using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota t = Toyota.createToyota();
            BMW b = BMW.createBMW();
            Thread thread1 = new Thread(t.run); //Put the Toyota in thread and start run
            Thread thread2 = new Thread(b.run); //Put the BMW in thread and start run
            Console.WriteLine("Call the run() of the Toyota:");
            thread1.Start(); //Start thread1
            thread1.Join(); //Wait until the thread1 ends
            Console.WriteLine("Call the run() of the BMW:");
            thread2.Start(); //Start thread2
        } //The obtained result same from question 1
    }
}
