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
        public Card card;
        public Wallet()
        { 
            coins = new List<Coin>();
            card = new Card();
            StockCoinsInWallet();
            WalletTotal();

        }
        public void StockCoinsInWallet()
        {
            for (int i = 0; i < 10; i++)
            {
                coins.Add(new Quarter("quarter"));
            }
            for (int i = 0; i < 10; i++)
            {
                coins.Add(new Dime("dime"));
            }
            for (int i = 0; i < 20; i++)
            {
                coins.Add(new Nickle("nickle"));
            }
            for (int i = 0; i < 50; i++)
            {
                coins.Add(new Penny("penny"));
            }
        }
        public double WalletTotal()
        {
            double walletTotal = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                walletTotal += coins[i].CoinValue;
            }
            return walletTotal;
        }
    }
}
