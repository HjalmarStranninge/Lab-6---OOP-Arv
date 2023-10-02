using System.Security.Cryptography.X509Certificates;

namespace Lab_6____OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }


        //Declaring the class Animal with 5 properties
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


        //Declaring the 'Dog' subclass of Animal
        class Dog : Animal
        {
        //Declaring property 'Breed', which is unique to the Dog class
        public string Breed { get; set; }
            public Dog(double weight, int age, string breed)
                    :base("Dog", "Woof", "Dog food", weight, age)
            {              
                Breed = breed;
            }

            //Unique method of the Dog class
            public void wagTail()
            {
                Console.WriteLine($"The {Breed} is wagging its tail! It must be happy to see you!");
            }
        }


        //Declaring the 'Cat' subclass 
        class Cat : Animal
        {
            //Uníque property which describes the cats color
            public string FurColor { get; set; }
            public Cat(double weight, int age, string furColor)
                    : base("Cat", "Meow", "Cat food", weight, age)
            {
                FurColor = furColor;
            }

            //The Cat class also has an unique method
            public void isPurring()
            {
                Console.WriteLine($"The {FurColor} cat is purring contently. It is enjoying your company!");
            }
        }


        //Declaring the 'Bird' subclass 
        class Bird : Animal
        {
            //Birds have the unique property Wingspan
            public double WingSpanCm { get; set; }
            public Bird(double weight, int age, double wingSpan)
                    : base("Bird", "Chirp", "Seeds", weight, age)
            {
                WingSpanCm = wingSpan;
            }

            //The unique subclass for the Bird class
            public void isFlying()
            {
                Console.WriteLine($"The {Species} flaps its wings and flies away!");
            }
        }


        //A subclass of the Bird class
        class Owl : Bird
        {
            public Owl(double  weight, int age, double wingSpan)
                :base(weight, age, wingSpan)                   
            {
                //Changes the species and diet to something more fitting of an owl
                Species = "Owl";
                Diet = "Rodents";
            }
        }


        //Another subclass of Bird
        class Chicken : Bird
        {
            public Chicken(double weight, int age, double wingSpan)
                : base(weight, age, wingSpan)
            {
                //Changes the species and diet to something more fitting of a chicken
                Species = "Chicken";
                Sound = "Cluck";
            }
            //The Chicken class also has an unique method
            public void layEgg()
            {
                Console.WriteLine($"Plopp! The {Species} laid an egg!");
            }
        }
    }
}