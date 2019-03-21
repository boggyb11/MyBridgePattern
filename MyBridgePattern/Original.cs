using System;

namespace MyBridgePattern
{
    //concrete implementation class
    class Original : IFlavour
    {
        public void AddFlavour()
        {
            Console.Write("Original flavour\n");
        }
    }
}
