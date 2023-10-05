using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
    //Declaring the parent class 'Animal' with 5 properties
    class Animal
    {
        public string Species { get; set; }
        public double WeightKg { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }
        public string Diet { get; set; }

        //Constructor
        public Animal(string species, string sound, string diet, double weight, int age)
        {
            Species = species;
            WeightKg = weight;
            Age = age;
            Sound = sound;
            Diet = diet;
        }

        //3 methods shared by all animals
        public void isEating()
        {
            Console.WriteLine($"The {Species} is eating {Diet}!");
        }

        public void isSleeping()
        {
            Console.WriteLine($"The {Species} is sleeping..");
        }

        public void makeSound()
        {
            Console.WriteLine($"*{Sound}! ");
        }
    }
}
