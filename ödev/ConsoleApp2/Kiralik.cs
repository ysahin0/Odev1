using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kiralik:IKonut
    {
        public string adresBilgisi()
        {
            return "izmir ";
        }
        public double fiyatBilgisi()
        {
            return 500; 
        }

        public string evOzellik()
        {
            return "site ici";
        }


    }
}
