using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {

        //public static void CheckWallet()
        //{
        //    Wallet WalletTotal;
          
        //    Console.WriteLine($" You have } left in your wallet.");
        //}
        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Quick Can vending machines!");
            Console.WriteLine("All products are cold, refreshing and garented fresh!");
            Console.WriteLine("We stock the finest products in the west!\n" + "Cola, for $0.35 a can. \n" + "RootBeer, for $0.60 a can. \n" + "OrangeSoda, for $0.06 a can. \n");
        
        }
        public static string PickASoda()
        {
            Console.WriteLine("Select a can of soda you would like to buy by entering the number assosiated with it: \n" + "--- ( 1 ) = Cola --- \n" + "--- ( 2 ) = OrangeSoda --- \n" + "--- ( 3 ) = RootBeer --- \n");
            ConsoleKeyInfo thing = Console.ReadKey();
            Can can;
            if (thing.Key == ConsoleKey.D1)
            {
                can = new Cola("Cola");
                Console.WriteLine(" You picked a nice refreshing Cola!");
                return "Cola";
            }
            else if (thing.Key == ConsoleKey.D2)
            {
                can = new OrangeSoda("OrangeSoda");
                Console.WriteLine(" You picked cool can of OrangeSoda!");
                return "OrangeSoda";
            }
            else if (thing.Key == ConsoleKey.D3)
            {
                can = new RootBeer("RootBeer");
                Console.WriteLine(" You picked a nice cold RootBeer!");
                return "RootBeer";
            }
            else
            {
                Console.WriteLine("Please select again..");
                return "nothing";
            }
        }
        public static string PickCoins()
        {
            Console.WriteLine("Select which coins you would like to use to pay: \n" + "--- ( 1 ) = Penny --- \n" + "--- ( 2 ) = Nickle --- \n"
                + "--- ( 3 ) = Dime --- \n" + "--- ( 4 ) = Quarter --- \n");
            ConsoleKeyInfo thing = Console.ReadKey();
            Coin coin;
            if (thing.Key == ConsoleKey.D1)
            {
                coin = new Penny("Penny");
                Console.WriteLine(" You have deposited .01 cents!");
                return "Penny";
            }
            else if (thing.Key == ConsoleKey.D2)
            {
                coin = new Nickle("Nickle");
                Console.WriteLine(" You have deposited .05 cents!");
                return "Nickle";
            }
            else if (thing.Key == ConsoleKey.D3)
            {
                coin = new Dime("Dime");
                Console.WriteLine(" You have deposited .10 cents!");
                return "Dime";
            }
            else if (thing.Key == ConsoleKey.D4)
            {
                coin = new Quarter("Quarter");
                Console.WriteLine(" You have deposited .25 cents!");
                return "Quarter";
            }
            else
            {
                Console.Clear();
                return "nothing";
            }
        }
        public static void DisplayDepositedCoin(Coin coin)
        {
            Console.WriteLine($" {coin} was deposited in the machine");
        }
    }
}
