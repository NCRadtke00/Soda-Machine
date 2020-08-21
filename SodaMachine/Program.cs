using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.RunMachine();
        }
    }
}
