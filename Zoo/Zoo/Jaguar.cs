using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Jaguar : Mammal
    {
        private bool _hasFur = true;
        public override bool HasFur { get { return _hasFur; } set { _hasFur = value; } }
        public override string TypeOfDiet
        {
            get => base.TypeOfDiet = "I am an carnivore!";
            set => base.TypeOfDiet = value;
        }
    }
}
