using System;

namespace FarmSystem.Test1
{
    public class Sheep : IAnimal
    {
        public Sheep()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }

        public string Id { get; private set; }

        public int NoOfLegs { get; private set; }

        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}