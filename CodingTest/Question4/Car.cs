using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Car
    {
        protected int wheels = 4;
        protected int doors = 4;
        protected int seats = 5;
        protected int maxSpeed;
        public static int iLock = 1; //Flag variable to perform synchronization
        public virtual void run() //Virtual method
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(this.maxSpeed);
            }
        }
        public void info()
        {
            Console.WriteLine("Wheels: " + this.wheels + "../n");
            Console.WriteLine("Doors: " + this.doors + "../n");
            Console.WriteLine("Seats: " + this.seats + "../n");
            Console.WriteLine("MaxSpeed: " + this.maxSpeed);
        }
    }
}
