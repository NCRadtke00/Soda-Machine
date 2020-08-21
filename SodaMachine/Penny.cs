using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Penny : Coin
    {
        public Penny(string name)
        {
            coinName = "Penny";
            coinValue = .01;
        }
    }
}
