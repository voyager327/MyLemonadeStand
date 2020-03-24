using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        // member variables - weather condition 
        public int WeatherCondition()
        { 
            // member constructor- setting weather condition and temperature 
            int weatherCondition = new Random().Next(0, 4);
            return weatherCondition;
        }
        public string ConvertWeatherCondition(int weatherTemp)
        {
            string weatherCondition = "";
            switch (weatherTemp)
            {

            }
        }
   
    }

}
