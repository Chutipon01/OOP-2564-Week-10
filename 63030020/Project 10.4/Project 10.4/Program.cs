﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10._4
{
    class Cat
    {
        private float age;
        private string color;
        public float Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            // Create Cat's instances named Garfield and Thomas
            Cat Garfield = new Cat();
            Cat Thomas = new Cat();

            // Set properties of Garfield 
            Garfield.Age = 3.2f;
            Garfield.Color = "Orange";
            Thomas.Age = 2.5f;
            Thomas.Color = "Grey";

            //Show Cats  prpoerties
            Console.WriteLine($"Garfield.Age = {Garfield.Age}");
            Console.WriteLine($"Garfield.Color = {Garfield.Color}");
            Console.WriteLine($"Thomas.Age = {Thomas.Age}");
            Console.WriteLine($"Thomas.Color = {Thomas.Color}");
        }
    }
}
