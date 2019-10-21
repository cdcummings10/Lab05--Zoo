using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract public class Reptile : Animal
    {
        private string _bloodTemp;
        public override string BloodTemp { get => _bloodTemp = "Cold Blooded"; 
            set => _bloodTemp = value; }
        private bool _hasScales = true;
        public virtual bool HasScales
        {
            get { return _hasScales; }
            set { _hasScales = value; }
        }
        public override string Sleep()
        {
            return "I sleep with my eyes open cuz I don't have eyelids.";
        }
        public override void Reproduce()
        {
            Console.WriteLine("I lay eggs to give birth.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("I eat with my mouth! Yum!");
        }
        
    }
}
