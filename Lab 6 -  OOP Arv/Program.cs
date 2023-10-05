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
    }
}