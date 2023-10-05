using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
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
}
