using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
        // member variables - weather condition 
        public int CurrentTemp()
        {
            int temperature;
            temperature = new Random().Next(55, 95);
            return temperature;
        }
        
        public void WeatherForecast()
        {
            Console.WriteLine("WeatherForecast for the Day");
            {
                var random = new Random();
                {
                    var list = new List<string> { "Rainy, Sunny, Cloudy" };
                    int index = random.Next(list.Count);
                    Console.WriteLine("Weather: " + list[index]);
                    Console.WriteLine("Display Results");
                    Console.ReadLine();
                    
                }
             
            }
    
        }
     
     }
 }          
              