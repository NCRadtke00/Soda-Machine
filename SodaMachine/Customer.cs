using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        Wallet wallet;
        Backpack backpack;
        public Customer()
        {

        }
        public void BuyASoda()
        {
            Console.WriteLine("Select a can of soda by entering the number assosiated with it: \n" + "--- ( 1 ) = Cola --- \n" + "--- ( 2 ) = OrangeSoda --- \n" + "--- ( 3 ) = RootBeer --- \n");
            ConsoleKeyInfo thing = Console.ReadKey();
            if (thing.Key == ConsoleKey.D1)
            {
                gesture = "Cola";
                Console.WriteLine(" You picked a nice refreshing Cola");
                return "Cola";
            }
            else if (thing.Key == ConsoleKey.D2)
            {
                gesture = "OrangeSoda";
                Console.WriteLine(" You picked cool can of OrangeSoda POP!!");
                return "OrangeSoda";
            }
            else if (thing.Key == ConsoleKey.D3)
            {
                gesture = "RootBeer";
                Console.WriteLine(" You picked a nice cold RootBeer!");
                return "RootBeer";
            }
        }
    }
}
