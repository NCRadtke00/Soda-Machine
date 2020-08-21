using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        SodaMachine soadMachine;
        Customer customer;
        public Simulation()
        {
            soadMachine = new SodaMachine();
            customer = new Customer();
        }
        public void RunMachine()
        {
            UserInterface.WelcomeScreen();
            //UserInterface.CheckWallet();
            UserInterface.PickASoda();
           BuyASoda(UserInterface.PickCoins());
        }
 
    }
}
