﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;

        private double cubicCapacity;

        public Engine(int horsepower, double cubicCapacity)
        {
            HorsePower = horsepower;

            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }

    }
}
