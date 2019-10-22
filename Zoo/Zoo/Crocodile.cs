using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Crocodile : Reptile, IGetFedMeat
    {
        public int NumberOfTeeth { get; set; }
        public string EatSteak()
        {
            return "I love filet mignon.";
        }
    }
}
