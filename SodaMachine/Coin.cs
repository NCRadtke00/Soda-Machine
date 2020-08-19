using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public abstract class Coin
    {
        protected double coinValue;
        public string coinName;

        public double CoinValue
        {
            get
            {
                return coinValue;
            }
        }
        public Coin()
        {            
        }
    }
}
