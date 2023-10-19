using System.Reflection;
using task19._10.Models;

namespace task19._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[]
            {
            new Apple { Price = 1.99, Sort = "Red", VitaminA = 10, VitaminB = 5 },
            new Pineapple { Price = 2.99, Sort = "Golden", VitaminE = 8, VitaminD = 3 },
            new Orange { Price = 0.99, Sort = "Orange", VitaminC = 4 }
            };

            foreach (var fruit in Basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine("Fruit Type: " + fruitType.Name);
                Console.WriteLine("Sort: " + fruit.Sort);
                Console.WriteLine("Price: " + fruit.Price);

                if (fruitType == typeof(Apple))
                {
                    Apple apple = (Apple)fruit;
                    Console.WriteLine("VitaminA: " + apple.VitaminA);
                    Console.WriteLine("VitaminB: " + apple.VitaminB);
                }
                else if (fruitType == typeof(Pineapple))
                {
                    Pineapple pineapple = (Pineapple)fruit;
                    Console.WriteLine("VitaminE: " + pineapple.VitaminE);
                    Console.WriteLine("VitaminD: " + pineapple.VitaminD);
                }
                else if (fruitType == typeof(Orange))
                {
                    Orange orange = (Orange)fruit;
                    Console.WriteLine("VitaminC: " + orange.VitaminC);
                }

                fruit.Taste();

                Console.WriteLine();
            }
        }
    }
}