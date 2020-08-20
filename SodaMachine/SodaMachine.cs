using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        public List<Can> can;
        public List<Coin> register;
        public SodaMachine()
        {
            double colaPrice = .35;
            double rootBeerPrice = .60;
            double orangeSodaPrice = .06;

        }
        public void Inventory()
        {
            can= new List<Can>();
            this.can.Add("RootBeer");
            this.can.Add("Cola");
            this.can.Add("Orange");
        }
        public void Register()
        {
            register = new List<Coin>();
            this.register.Add(20, "Quarters");
            this.register.Add(10, "Dimes");
            this.register.Add(20, "Nickle");
            this.register.Add(50, "Penny");
        }
        public void DispenseCan();
        public void ProcessPayment();

    }
}
