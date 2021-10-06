namespace FarmSystem.Test1
{
    using System;
    using System.Collections.Generic;

    public class EmydexFarmSystem
    {
        public event EventHandler AllAnimalsReleased;
        private List<IAnimal> listofAnimals = new List<IAnimal>();

        //TEST 1
        public void Enter(object animal)
        {
            listofAnimals.Add(animal as IAnimal);
            Console.WriteLine($"{animal.GetType().Name} has entered the farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (IAnimal animal in listofAnimals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (IAnimal animal in listofAnimals)
            {
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach(IAnimal animal in listofAnimals)
            {
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }

            listofAnimals.Clear();
            AllAnimalsReleased.Invoke(this, null);
        }
    }
}