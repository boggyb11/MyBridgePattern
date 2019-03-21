using System;

namespace MyBridgePattern
{
    //redefined abstraction class
    class Coke : SoftDrink
    {
        public Coke(IFlavour flavour) : base(flavour)
        {

        }
        public override void Display()
        {
            Console.Write("Coke ");
            Flavour.AddFlavour();
        }
    }
}
