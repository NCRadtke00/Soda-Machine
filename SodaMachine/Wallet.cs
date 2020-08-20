using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        public List<Coin> coins;
        Card card;
        public Wallet()
        {
            StockCoinsInWallet();
            coins = new List<Coin>();
        }
        public void StockCoinsInWallet()
        {
            for (int i = 0; i < 10; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                coins.Add(nickle);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }
        }
    }
}
