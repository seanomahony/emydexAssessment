namespace FarmSystem.Test1
{
    using System;

    public class Cow : IMilkableAnimal
    {
        public Cow()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }

        public string Id { get; private set; }

        public int NoOfLegs { get; private set; }

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}