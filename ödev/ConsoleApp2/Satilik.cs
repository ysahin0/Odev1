using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Satilik:IKonut
    {

        public string adresBilgisi()
        {
            return "istanbul";
        }
        public double fiyatBilgisi() 
        {
            return 50000; 
        }

        public string evOzellik()
        {
            return "deniz kenarı";
        }
    }
}
