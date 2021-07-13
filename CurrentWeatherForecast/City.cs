using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CurrentWeatherForecast
{
    public class City
    {
        public City()
        {

        }

        public double Temp { get; set; }
        public string Name { get; set; }

        public double TempInF(double tempInK)
        {
            var tempInF = ((9 / 5)*(tempInK - 273)) + 32;
            return tempInF;
        }
    }
}
