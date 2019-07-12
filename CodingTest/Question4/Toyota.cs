using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Toyota : Car
    {
        private static Toyota toyota;
        private Toyota()
        {
            this.maxSpeed = 100;
        }
        public static Toyota createToyota()
        {
            if (toyota == null)
                toyota = new Toyota();
            return toyota;
        }
        public override void run() //Override the source code of the parent class
        {
            for (int i = 0; i < 10; i++)
            {
                while (Car.iLock != 1) ; //Loop to prevent thread from executing
                Console.WriteLine(this.maxSpeed);
                Car.iLock = 0;
            }
        }
    }
}
