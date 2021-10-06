using System;

namespace FarmSystem.Test1
{
    public class Horse : IAnimal
    {
        public Horse()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }

        public string Id { get; private set; }

        public int NoOfLegs { get; private set; }

        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}