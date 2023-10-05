using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
    //A subclass of the Bird class
    class Eagle : Bird
    {
        public Eagle(double weight, int age, double wingSpan)
            : base(weight, age, wingSpan)
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
}
