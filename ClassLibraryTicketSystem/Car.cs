﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    class Car : Vehicle
    {

        public Car()
        {
            
        }

        public double Price()
        {
            return 240;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
