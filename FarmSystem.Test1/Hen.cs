namespace FarmSystem.Test1
{
    using System;

    public class Hen : IAnimal
    {
        public Hen()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }

        public string Id { get; private set; }

        public int NoOfLegs { get; private set; } 

        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}