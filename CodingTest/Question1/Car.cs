using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    //Create Car class
    class Car 
    {
        //Characteristics of Car class
        protected int wheels = 4;
        protected int doors = 4;
        protected int seats = 5;
        protected int maxSpeed;

        //Method run print out the max speed of the car in a loop of 10 times
        public void run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(this.maxSpeed);
            }
        }

        //Method info list out all the characteristics of the car, for example
        public void info()
        {
            Console.WriteLine("Wheels: " + this.wheels + "../n");
            Console.WriteLine("Doors: " + this.doors + "../n");
            Console.WriteLine("Seats: " + this.seats + "../n");
            Console.WriteLine("MaxSpeed: " + this.maxSpeed);
        }
    }
}
