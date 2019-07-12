using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class BMW : Car
    {
        private static BMW bmw;
        private BMW()
        {
            this.maxSpeed = 200;
        }
        public static BMW createBMW()
        {
            if (bmw == null)
                bmw = new BMW();
            return bmw;
        }
        public override void run() //Override the source code of the parent class
        {
            for (int i = 0; i < 10; i++)
            {
                while (Car.iLock != 0); //Loop to prevent thread from executing
                Console.WriteLine(this.maxSpeed);
                Car.iLock = 1;
            }
        }

    }
}
