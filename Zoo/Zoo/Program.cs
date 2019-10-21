using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant();
            elephant.BloodTemp = "Warm blooded.";
            Console.WriteLine(elephant.TypeOfDiet);
        }
    }
}
