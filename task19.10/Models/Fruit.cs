using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19._10.Models
{
    abstract class Fruit
    {
        public double Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();
    }
}
