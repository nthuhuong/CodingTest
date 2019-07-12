using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
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
    }
}
