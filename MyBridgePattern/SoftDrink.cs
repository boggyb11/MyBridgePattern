
namespace MyBridgePattern
{
    //abstraction class
    abstract class SoftDrink
    {
        public IFlavour Flavour { get; set; }
        public string Name { get; set; }
        public abstract void Display();

        public SoftDrink(IFlavour flavour)
        {
            Flavour = flavour;
        }
    }
}
