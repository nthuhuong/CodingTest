using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota t = Toyota.createToyota();
            BMW b = BMW.createBMW();
            Console.WriteLine("Call the run() of the Toyota:");
            t.run();
            Console.WriteLine("Call the run() of the BMW:");
            b.run();
        }
    }
}
