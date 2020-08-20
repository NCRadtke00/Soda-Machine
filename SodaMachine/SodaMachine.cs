using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        public List<Can> cans;
        public List<Coin> register;
        public List<RootBeer> RootBeers;
        public List<Cola> Colas;
        public List<OrangeSoda> OrangeSodas;
        public SodaMachine()
        {
        }
        public void Inventory()
        {
            RootBeers = new List<RootBeer>();
            Colas = new List<Cola>();
            OrangeSodas = new List<OrangeSoda>();

            cans = new List<Can>();
            this.cans.Add("RootBeers");
            this.cans.Add("Colas");
            this.cans.Add("OrangeSodas");
        }
        public void Register()
        {
            register = new List<Coin>();
            this.register.Add("Quarters");
            this.register.Add("Dimes");
            this.register.Add("Nickle");
            this.register.Add("Penny");
        }
        public void AddCansToSodaMachine()
        { 
            for (int i = 0; i < 25; i++)
            {
                Cola cola = new Cola();
                Colas.Add(cola);
            }
            for (int i = 0; i < 25; i++)
            {
                RootBeer rootBeer = new RootBeer();
                RootBeers.Add(rootBeer);
            }
            for (int i = 0; i < 25; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                OrangeSodas.Add(orangeSoda);
            }
        }
        public void DispenseCans()
        {
            if (RootBeer)
            {
                RootBeers.RemoveAt(0);
            }
            else if(Cola)
            {
                Colas.RemoveAt(0);
            }
            else if ()


        }
        
        //public void ProcessPayment();

    }
}
