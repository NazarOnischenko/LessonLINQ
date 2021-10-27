using System;
using System.Collections.Generic;
using System.Text;

namespace LessonLINQ
{
    public class Product
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"{Name} {Calories} ";
        }
    }
}
