﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19._10.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Orange: bitter");
        }
    }
}
