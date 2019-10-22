using System;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant();
            Crocodile crocodile = new Crocodile();
            Iguana iguana = new Iguana();
            Marmot marmot = new Marmot();
            Jaguar jaguar = new Jaguar();

            Console.WriteLine("These are my concrete animals and some actions they've inherited: ");
            Console.WriteLine("Elephant: " + elephant.Reproduce());
            Console.WriteLine("Crocodile: " + crocodile.Reproduce());
            Console.WriteLine($"Iguana: Is {iguana.BloodTemp}.");
            Console.WriteLine($"Marmot: Is {marmot.BloodTemp}.");
            Console.WriteLine($"Jaguar: {jaguar.Sleep()}");
        }
    }
}
