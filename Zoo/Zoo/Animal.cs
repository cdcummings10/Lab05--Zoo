using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        public abstract string BloodTemp { get; set; }
        public abstract void Sleep();
        public abstract void Reproduce();

    }
}
