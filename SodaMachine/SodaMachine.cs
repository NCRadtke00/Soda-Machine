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
        public string customerChoice;
        public SodaMachine()
        { 
            inventory = new List<Can>();
            AddCansToSodaMachineInventory();
           register = new List<Coin>();
            StockCoinsInSodaMachineRegister();
            
        }
        public void StockCoinsInSodaMachineRegister()
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
        public void AddCansToSodaMachineInventory()
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
        public Can PickASoda()
        {
            customerChoice = UserInterface.PickASoda();
            Can can;
            switch (customerChoice)
            {
                case "1":
                    can = inventory.Find(x => x.canName == "RootBeer");
                    return can;
                case "2":
                    can = inventory.Find(x => x.canName == "Cola");
                    return can;
                case "3":
                    can = inventory.Find(x => x.canName == "OrangeSoda");
                    return can;
                default;
                    Console.WriteLine("Please pick again.");
                    return PickASoda();
            }
        }
    }
}
