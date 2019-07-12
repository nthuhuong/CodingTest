﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    //Create Toyota class inherit Car class
    //Use Singleton Pattern
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
    }
}
