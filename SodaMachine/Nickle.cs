using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Nickle : Coin
    {
        public Nickle(string name)
        {
            coinName = "Nickle";
            coinValue = .05;
        }
    }
}
