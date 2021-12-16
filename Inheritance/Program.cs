using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - Done!
            // give this class 4 members that all Animals have in common - Done!


            // Create a class Bird - Done
            // give this class 4 members that are specific to Bird - Done
            // Set this class to inherit from your Animal Class - Done

            // Create a class Reptile - Done
            // give this class 4 members that are specific to Reptile - Done
            // Set this class to inherit from your Animal Class - Done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird();
            bird1.HasWings = true;
            bird1.Color = "red";
            bird1.WingSpan = 4;
            bird1.LaysEggs = true;

            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile()
            {
                Eyes = 2,
                HasScales = true,
                IsColdBlooded = true,
                Length = 5
            };

            var myAnimals = new Animal[] { bird1, snake };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}");
                Console.WriteLine($"Alive: {animal.IsLiving}");
                Console.WriteLine($"Can Reproduce: {animal.CanReproduce}");
                Console.WriteLine($"Age: {animal.Age}");
            }
        }
    }
}
