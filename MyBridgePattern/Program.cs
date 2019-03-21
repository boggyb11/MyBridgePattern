using System;

namespace MyBridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlavour cherry = new Cherry();
            IFlavour original = new Original();

            SoftDrink coke = new Coke(original);
            coke.Display();

            SoftDrink pepsi = new Pepsi(cherry);
            pepsi.Display();

            Console.ReadKey();
        }
    }
}
