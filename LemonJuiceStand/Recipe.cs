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

        public int numOfRecipeCups;
        public int removeNumOfrecipeCups;
        public int removeNumOfCups;
        public int removeSugarCubes;
        public int removeIceCubes;


        public Recipe()
        {
            amountOfSugarCubes = 10; 
            amountOfLemons = 2; 
            amountOfIceCubes = 6; 
            priceOfCup = .30; 
        }

        //How much would you like to charge by cup
        //set up the price per cup
        public void Chooserecipe()
        {
            Console.WriteLine(" Standard ingredient include, 2 lemons, 10 sugar cubes, 6 ice cubes in 1 cup of delicious lemonade");
            Console.Write("How much would like to charge per cup? Enter a  number: ");
            double amountOfSugarcubes;
            double priceOfCup
            string input = Console.ReadLine().ToUpper();
            int priceForRecipe = int.Parse(Console.ReadLine());
        }

        
        

    }
}
