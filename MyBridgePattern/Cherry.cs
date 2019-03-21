using System;

namespace MyBridgePattern
{
    //concrete implementation class
    class Cherry : IFlavour
    {
        public void AddFlavour()
        {
            Console.Write("Cherry flavour\n");
        }
    }
}
