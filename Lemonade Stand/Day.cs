﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        // member variables 
        public Day[] days;
        // constructors 

        public Day()
        {
            days = new Day[6];

            Day days1 = new Day("Sunday");
            Day days2 = new Day("Monday");
            Day days3 = new Day("Tuesday");
            Day days4 = new Day("Wednesday");
            Day days5 = new Day("Thursday");
            Day days6 = new Day("Friday");
            Day days7 = new Day("Saturday");

            days[0] = days1;
            days[1] = days2;
            days[2] = days3;
            days[3] = days4;
            days[4] = days5;
            days[5] = days6;

        }
        // methods 
    }

}