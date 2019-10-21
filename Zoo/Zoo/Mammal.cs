using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Mammal : Animal
    {
        private string _typeOfDiet = "I am an omnivore.";
        public virtual string TypeOfDiet
        {
            get
            {
                return _typeOfDiet;
            }
            set
            {
                _typeOfDiet = value;
            }
        }
        private string _bloodTemp = "Warm Blooded";
        public override string BloodTemp
        {
            get
            {
                return _bloodTemp;
            }
            set
            {
                _bloodTemp = value;
            }
        }
        abstract public bool HasFur { get; set; }
        public override void Sleep()
        {
            Console.WriteLine("I sleep with my eyes closed.");
        }
        public override void Reproduce()
        {
            Console.WriteLine("I get pregnant to have a baby!");
        }
        public virtual void Eat()
        {
            Console.WriteLine("I eat with my mouth! Yum!");
        }
    }
}
