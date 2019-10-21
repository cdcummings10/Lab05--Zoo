using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Mammal
    {
        private bool _hasFur = false;
        public override bool HasFur { get { return _hasFur; } set { _hasFur = value; } }
        public override string TypeOfDiet { get => base.TypeOfDiet = "I am an herbavore!"; 
            set => base.TypeOfDiet = value; }
        public override void Eat()
        {
            Console.WriteLine("I feed myself with my trunk! Yum!");
        }
    }
}
