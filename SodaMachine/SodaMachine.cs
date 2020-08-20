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
            AddCansToSodaMachine();
            inventory = new List<Can>();
            StockCoinsInSodaMachine();
            register = new List<Coin>();
        }
        public void StockCoinsInSodaMachine()
        {
            for (int i = 0; i < 25; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }
            for (int i = 0; i < 25; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
            for (int i = 0; i < 25; i++)
            {
                Nickle nickle = new Nickle();
                register.Add(nickle);
            }
            for (int i = 0; i < 25; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }
        }
    }
}
