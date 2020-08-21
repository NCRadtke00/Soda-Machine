using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Dime : Coin
    {
        public Dime(string name)
        {
            coinValue = .10;
            coinName = "Dime";
        }
    }
}
