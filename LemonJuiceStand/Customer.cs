using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonJuiceStand
{
    class Customer
    {
        List<string> names;
        public string name;
        public int flavorScore;

        Random getRandomInteger = new Random();

        public Customer(string name)
        {
            this.name = name;
            flavorScore = getRandomInteger.Next(0, 100); 
        }
    }
}
