using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
    //Declaring the 'Dog' subclass of Animal
    class Dog : Animal
    {
        //Declaring the property 'Breed', which is unique to the Dog class
        public string Breed { get; set; }
        public Dog(double weight, int age, string breed)
                : base("Dog", "Woof", "Dog food", weight, age)
        {
            Breed = breed;
        }

        //Unique method of the Dog class
        public void wagTail()
        {
            Console.WriteLine($"The {Breed} is wagging its tail! It must be happy to see you!");
        }
    }
}
