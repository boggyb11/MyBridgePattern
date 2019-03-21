using System;

namespace MyBridgePattern
{
    //redefined abstraction class
    class Pepsi : SoftDrink
    {
        public Pepsi(IFlavour flavour) : base(flavour)
        {

        }
        public override void Display()
        {
            Console.Write("Pepsi ");
            Flavour.AddFlavour();
        }
    }
}
