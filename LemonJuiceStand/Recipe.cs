using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonJuiceStand
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double priceOfCup;

        public Recipe()
        {
            amountOfSugarCubes = 10; 
            amountOfLemons = 2; 
            amountOfIceCubes = 6; 
            priceOfCup = .30; 
        }
    }
}
