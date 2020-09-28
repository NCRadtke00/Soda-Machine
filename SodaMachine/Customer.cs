using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;
       
        //public int id;
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
       

        }

        public void BuyASoda(Can can, double coins)
        {
            List<Coin> coin = new List<Coin>();

            bool wasEnoughMoneyPaid = true;
            while (wasEnoughMoneyPaid)
            {
                string input = UserInterface.PickCoins();
                switch (input)
                {
                    case "0":
                        for (int i = 0; i < wallet.coins[i]; i++)
                        {
                            if (wallet.coins[i].coinName == "penny")
                            {
                                Coin coin1 = wallet.coins[i];
                                wallet.coins.Remove(coin1);
                                coin.Add(coin1);
                                //DisplayDepositedCoin(Coin coin1);
                                break;
                            }
                        }
                    case "1":
                        for (int i = 0; i < wallet.coins[i]; i++)
                        {
                            if (wallet.coins[i].coinName == "nickle")
                            {
                                Coin coin1 = wallet.coins[i];
                                wallet.coins.Remove(coin1);
                                coin.Add(coin1);
                                //DisplayDepositedCoin(Coin coin1);
                                break;
                            }
                        }
                    case "2":
                        for (int i = 0; i < wallet.coins[i]; i++)
                        {
                            if (wallet.coins[i].coinName == "Dime")
                            {
                                Coin coin1 = wallet.coins[i];
                                wallet.coins.Remove(coin1);
                                coin.Add(coin1);
                                //DisplayDepositedCoin(Coin coin1);
                                break;
                            }
                        }
                    case "3":
                        for (int i = 0; i < wallet.coins[i]; i++)
                        {
                            if (wallet.coins[i].coinName == "Quarter")
                            {
                                Coin coin1 = wallet.coins[i];
                                wallet.coins.Remove(coin1);
                                coin.Add(coin1);
                                //DisplayDepositedCoin(Coin coin1);
                                break;
                            }
                        }
                    case "4":
                        {
                            wasEnoughMoneyPaid = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            //•	If not enough money is passed in, don’t complete transaction and give the money back.
            //•	If exact change is passed in, accept payment and dispense a soda instance that gets saved in my Backpack.
            //•	If too much money is passed in, accept the payment, return change as a list of coins from internal, limited register, and dispense a soda instance that gets saved to my Backpack.
            //•	If too much money is passed in but there isn’t sufficient change in the machine’s internal register, don’t complete transaction: give the money back.
            //•	If exact or too much money is passed in but there isn’t sufficient inventory for that soda, don’t complete the transaction: give the money back.

        }
    public void AddCansToBackpack(Can can)
    {
       backpack.Add(can);
    }
} 
}

