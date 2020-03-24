using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Cup : Item
    {
        // member variables (HAS A)
        private double pricePerCup;
        // constructor (SPAWNER)
        public Cup()
        {
            name = "cup";
            pricePerCup = 0.05;
        }

        // member methods (CAN DO)
        
    }   
}
