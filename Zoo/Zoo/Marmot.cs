using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Marmot : Mammal
    {
        public bool IsFriendly { get; private set; } = true;
        private bool _hasFur = true;
        public override bool HasFur { get { return _hasFur; } set { _hasFur = value; } }
        public override string TypeOfDiet
        {
            get => base.TypeOfDiet = "I am an herbavore!";
            set => base.TypeOfDiet = value;
        }
    }
}
