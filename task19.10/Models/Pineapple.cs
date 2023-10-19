using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19._10.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Pineapple taste: sweet");
        }
    }
}
