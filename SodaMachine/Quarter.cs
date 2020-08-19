using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Quarter : Coin
    {
        public Quarter()
        {
            coinName = "Quarter";
            coinValue = .25;
        }
    }
}
