using System.Security.Cryptography.X509Certificates;

namespace Lab_6____OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 4 new objects of different classes

            Dog myDog = new Dog(30, 6, "Labrador");
            Cat myCat = new Cat(5, 15, "Chestnut Brown");
            Chicken myChicken = new Chicken(3, 2, 40);
            Eagle myEagle = new Eagle(7, 5, 230);
            
            //Using some of the shared and unique methods of each class

            myDog.wagTail();
            myDog.makeSound();

            myCat.isPurring();
            myCat.makeSound();

            myChicken.layEgg();
            myChicken.makeSound();

            myEagle.isFlying();
            myEagle.makeSound();
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
        //Declaring the property 'Breed', which is unique to the Dog class
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

            //The unique method for the Bird class
            public virtual void isFlying()
            {
                Console.WriteLine($"The {Species} flaps its wings and flies away!");
            }
        }


        //A subclass of the Bird class
        class Eagle : Bird
        {
            public Eagle(double  weight, int age, double wingSpan)
                :base(weight, age, wingSpan)                   
            {
                //Changes the species, diet and sound to something more fitting of an eagle
                Species = "Eagle";
                Diet = "Meat";
                Sound = "Keee-eee-eeeh";
            }

            //Overrides the original isFlying method
            public override void isFlying()
            {
                Console.WriteLine($"The majestic {Species} is soaring gracefully above you!");
            }
        }


        //Another subclass of Bird
        class Chicken : Bird
        {
            public Chicken(double weight, int age, double wingSpan)
                : base(weight, age, wingSpan)
            {
                //Changes the species and sound to something more fitting of a chicken
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