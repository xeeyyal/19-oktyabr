﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19._10.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Apple taste: sour");
        }
    }
}
