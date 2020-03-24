using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        // member variables 
        // weather and list of customers correlates with daily activities
        public Random random;
        public Weather weather;
        public int numberOfCustomersPerDay;
        public List<Customer> customer;
        public Day()
        {
            random = new Random();
            customer = new List<Customer>();
            weather = new Weather();
                                                      
        }


        // member constructors 

        

        
        // methods 
    }

}