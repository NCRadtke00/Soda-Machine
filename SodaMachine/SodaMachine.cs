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

        }
        public void Inventory()
        {
            inventory = new List<Can>();
            this.inventory.Add("RootBeer"); //(25, "RootBeer", .60)
            this.inventory.Add("Cola"); //(30,"Cola", .35)
            this.inventory.Add("Orange"); //(45, "Orange", .06)
        }
        public void Register()
        {
            register = new List<Coin>();
            this.register.Add(20, "Quarters");
            this.register.Add(10, "Dimes");
            this.register.Add(20, "Nickle");
            this.register.Add(50, "Penny");
        }
    }
}
