using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Mammal
    {
        public override bool HasFur { get => false; set => HasFur = value; }
        public override string TypeOfDiet { get => base.TypeOfDiet = "I am an herbavore!"; 
            set => base.TypeOfDiet = value; }
        public override void Eat()
        {
            Console.WriteLine("I feed myself with my trunk! Yum!");
        }
    }
}
