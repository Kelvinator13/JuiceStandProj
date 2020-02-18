using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonJuiceStand
{
    class Weather
    {
        public string condition;
        public int temperature;
        List<string> weatherConditions = new List<string>() { "Sunny", "Overcast", "Partly Cloudy", "Rainy" , "Snowy"};

        Random randomNumber = new Random();

        public Weather()
        {
            condition = "sunny";
            temperature = randomNumber.Next(60, 95); 
        }

        public void randomizedWeather()
        {
            int temporaryInteger = randomNumber.Next(0, 105);
            if (temporaryInteger > 75)
            {
                condition = weatherConditions[0];
                temperature = randomNumber.Next(76, 99);
            }
            else if (temporaryInteger < 75 && temporaryInteger > 55)
            {
                condition = weatherConditions[1];
                temperature = randomNumber.Next(55, 74);
            }
            else if (temporaryInteger < 55 && temporaryInteger > 35)
            {
                condition = weatherConditions[2];
                temperature = randomNumber.Next(36, 54);
            }
            else if (temporaryInteger  < 35 && temporaryInteger > 0)
            {
                condition = weatherConditions[4];
                temperature = randomNumber.Next(0, 34);
            }
        }
    }
}
