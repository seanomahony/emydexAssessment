namespace FarmSystem.Test1
{
    public interface IAnimal
    {
        string Id { get; }
        int NoOfLegs { get; }

        void Talk();
    }
}