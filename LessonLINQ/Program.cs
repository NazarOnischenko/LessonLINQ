using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonLINQ
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            var products = new List<Product>();
            
            for(int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Product" + i,
                    Calories = rnd.Next(30, 32)
                };
                products.Add(product);
            }

            var result = from item in products
                         where item.Calories < 200
                         select item;
            var result2 = products.Where(item => item.Calories < 200 || item.Calories > 400);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            var selectCollection = products.Select(products => products.Calories);
            Console.WriteLine();
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item+" ");
            }
            var orderbyCollection = products.OrderBy(product => product.Calories).ThenBy(product => product.Name);
            Console.WriteLine();
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item + " ");
            }
            var groupbyCollection = products.GroupBy(product => product.Calories);
            Console.WriteLine();
            foreach (var group in groupbyCollection)
            {

                Console.WriteLine($"Key:{group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item + " ");
                }
            }
            products.Reverse();
            Console.WriteLine(); 
            foreach (var item in products)
            {
                Console.WriteLine(item + " ");
            }
            var prod = new Product();
            Console.WriteLine(products.All(product => product.Calories == 30));
            Console.WriteLine(products.Any(product => product.Calories == 30));
            Console.WriteLine(products.Contains(prod));
            Console.WriteLine();

            var array = new int[] { 1, 2, 3,3,4,2, 4 };
            var array2 = new int[] {  3, 4, 5 ,6};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            var union = array.Union(array2);
            Console.WriteLine();
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            var intersec = array.Intersect(array2);
            Console.WriteLine();
            foreach (var item in intersec)
            {
                Console.WriteLine(item);
            }
            var except = array.Except(array2);
            Console.WriteLine();
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
            var distinct = array.Distinct();
            Console.WriteLine();
            foreach(var item in distinct)
            {
                Console.WriteLine(item);
            }
            var sum = array.Sum();
            var min = products.Min(prod => prod.Calories);
            var max = products.Max(prod => prod.Calories);
            var aggregate = array.Aggregate((x, y) => x * y);
            var sum2 = array.Skip(1).Take(2).Sum();
            var first = array.FirstOrDefault();
            var last = array.Last();
            //var single = products.Single(product => product.Calories == 30);
            var elementAt = products.ElementAt(4);
        }
    }
}
