using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6____OOP_Arv
{
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
}
