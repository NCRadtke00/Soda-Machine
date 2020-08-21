using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        public List<Can> inventory;
        public List<Coin> register;
        public SodaMachine()
        { 
            inventory = new List<Can>();
            AddCansToSodaMachine();
           register = new List<Coin>();
            StockCoinsInSodaMachine();
            
        }
        public void StockCoinsInSodaMachine()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter("quarter"));
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime("dime"));
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Nickle("nickle"));
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny("penny"));
            }  
        }
        public void AddCansToSodaMachine()
        {
            for (int i = 0; i < 25; i++)
            {
                inventory.Add(new Cola("cola"));
            }
            for (int i = 0; i < 25; i++)
            {
                inventory.Add(new RootBeer("rootBeer"));
            }
            for (int i = 0; i < 25; i++)
            {
                inventory.Add(new OrangeSoda("orangeSoda"));
            }
        }
        public void DispenseCans(Can can)
        {
            inventory.Remove(can);
        }
        public void ReturnChange(Coin coin)
        {
            register.Remove(coin);
        }
        public double RegisterTotal(List<Coin> coins)
        {
            double registerTotal = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                registerTotal += coins[i].CoinValue;
            }
            return registerTotal;
        }
    }
}
