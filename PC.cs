﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZSHARPICONSOLEAPP3
{
    public class PC
    {
        private string model;
        private double cpu_ClockSpeed;
        private int ram;
        private int hdd;

        public PC(string model, double cpu_ClockSpeed, int ram, int hdd)
        {
            this.model = model;
            this.cpu_ClockSpeed = cpu_ClockSpeed;
            this.ram = ram;
            this.hdd = hdd;
        }


        public void Info()
        {
            Console.WriteLine($"Model: {model}, CPU clock speed: {cpu_ClockSpeed}, RAM: {ram}, HDD: {hdd}\n");
        }
    }
}