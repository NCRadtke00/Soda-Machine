using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public abstract class Can
    {
        protected double canCost;
        public string canName;
        public double CanCost
        {
            get
            {
                return CanCost;
            }
        }
        public Can()
        {
        }
    }
}
