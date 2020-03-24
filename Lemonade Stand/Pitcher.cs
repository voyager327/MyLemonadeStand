﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Pitcher 
    {
        // member variables - contains recipe in the pitcher per sale
        public int lemonsPerPitcher;
        public int amountOfSugarCupsPerPitcher;
        public int amountOfIceCubesPerCup;
        public int amountOfCupsOfLemonadePerPitcher;
        public double priceOfLemonadePerCup;
        public int numberOfLemonadeCupPersale; 
        public Pitcher() 
        {
            // member constructors - list of recipes with estimated amount on each items. 
            lemonsPerPitcher = 5;
            amountOfSugarCupsPerPitcher = 5;
            amountOfIceCubesPerCup = 5;
            amountOfCupsOfLemonadePerPitcher = 8;
            priceOfLemonadePerCup = 0.25;
            numberOfLemonadeCupPersale = 1;

        }
          
           // methods 
        
    }
}
