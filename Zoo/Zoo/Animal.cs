using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract public class Animal
    {
        public abstract string BloodTemp { get; set; }
        public abstract string Sleep();
        public abstract void Reproduce();

    }
}
