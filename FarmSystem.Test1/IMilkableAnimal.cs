namespace FarmSystem.Test1
{
    /// <summary>
    /// Interface which exposes method to milk animals
    /// </summary>
    public interface IMilkableAnimal : IAnimal
    {
        #region  Public Methods

        void ProduceMilk();

        #endregion
    }
}