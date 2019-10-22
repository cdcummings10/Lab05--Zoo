using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Iguana : Reptile, ILick
    {
        public decimal TongueLength { get; set; }
        public string Lick()
        {
            return "Iguanas have weird tongues.";
        }
    }
}
