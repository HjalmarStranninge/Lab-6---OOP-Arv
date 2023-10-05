using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
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
