using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonJuiceStand
{
    class Game
    {
        Player player = new Player("LemonMan");
        Store store = new Store(); 
        private List<Day> days;
        int currentDay;
        int amountOfDays;

        public void startGame()
        {
            createWorld();
            while (currentDay < amountOfDays)
            {
                visitStore();
                createLemonade();
                sellLemonade();
                resultsOfTheDay();
            }

        }

        public void createWorld()
        {
            Console.WriteLine("How many days would you like to play? 1) 7\n2) 14\n3)21");
            string userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "7")
            {
                currentDay = 1;
                amountOfDays = 7;

            }
            else if (userInput == "2" || userInput == "14")
            {
                currentDay = 1;
                amountOfDays = 14; 
            }
            else if (userInput == "3" || userInput == "21")
            {
                currentDay = 1;
                amountOfDays = 21; 
            }
            else
            {
                Console.WriteLine("That input is invalid!");
                Console.ReadLine();
                createWorld();
            }
            Console.WriteLine("You world has successfuly been generated!");
            Console.ReadLine();
            Console.Clear();
        }

        public void visitStore()
        {
            Console.WriteLine("                      JUICE IT UP {0}", player.name);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-*********************************************************-");
            Console.WriteLine("-                 Your Lemons Left: {0}", player.inventory.lemons);
            Console.WriteLine("-                     Your Sugar Cubes Left: {0}", player.inventory.sugarCubes);
            Console.WriteLine("-                         Your Ice Cubes Left: {0}", player.inventory.iceCubes);
            Console.WriteLine("-                                Your Cups Left: {0}", player.inventory.cups);
            Console.WriteLine("-                                                         ");
            Console.WriteLine("-1) Lemons @ .50");
            Console.WriteLine("-2) Sugar Cubes @ .50");
            Console.WriteLine("-3) Ice Cubes @ .50");
            Console.WriteLine("-4) Cups @ .50");
            Console.WriteLine("-5) EXIT");
            Console.WriteLine("-*********************************************************-");
            Console.WriteLine("----------------------------------Y  O  U  R WALLET: ${0}", player.wallet.Money);
            Console.Write("Your Choice: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Write("How many Lemons: ");
                double input = Convert.ToInt32(Console.ReadLine());
                double priceAllTogether = input * store.pricePerLemon;
                Console.WriteLine("You spent ${0}", priceAllTogether);
                Console.Write("Would you like to exit? (Yes or No): ");
                string stringInput = Console.ReadLine();
                if (stringInput == "Yes" || stringInput == "yes" || stringInput == "Y" || stringInput == "y")
                {
                    Console.Clear();
                    visitStore();
                }
                else if (stringInput == "No" || stringInput == "no" || stringInput == "n")
                {
                    Console.WriteLine("Bye for now!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "2")
            {
                Console.Write("How many Sugar Cubes: ");
                double input = Convert.ToInt32(Console.ReadLine());
                double priceAllTogether = input * store.pricePerSugarCube;
                Console.WriteLine("You spent ${0}", priceAllTogether);
                Console.Write("Would you like to exit? (Yes or No): ");
                string stringInput = Console.ReadLine();
                if (stringInput == "Yes" || stringInput == "yes" || stringInput == "Y" || stringInput == "y")
                {
                    Console.Clear();
                    visitStore();
                }
                else if (stringInput == "No" || stringInput == "no" || stringInput == "n")
                {
                    Console.WriteLine("Bye for now!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "3")
            {
                Console.Write("How many Ice Cubes: ");
                double input = Convert.ToInt32(Console.ReadLine());
                double priceAllTogether = input * store.pricePerIceCube;
                Console.WriteLine("You spent ${0}", priceAllTogether);
                Console.Write("Would you like to exit? (Yes or No): ");
                string stringInput = Console.ReadLine();
                if (stringInput == "Yes" || stringInput == "yes" || stringInput == "Y" || stringInput == "y")
                {
                    Console.Clear();
                    visitStore();
                }
                else if (stringInput == "No" || stringInput == "no" || stringInput == "n")
                {
                    Console.WriteLine("Goodbye for now!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "4")
            {
                Console.Write("How many Cups: ");
                double input = Convert.ToInt32(Console.ReadLine());
                double priceAllTogether = input * store.pricePerCup;
                Console.WriteLine("You spent ${0}", priceAllTogether);
                Console.Write("Would you like to exit? (Yes or No): ");
                string stringInput = Console.ReadLine();
                if (stringInput == "Yes" || stringInput == "yes" || stringInput == "Y" || stringInput == "y")
                {
                    Console.Clear();
                    visitStore();
                }
                else if (stringInput == "No" || stringInput == "no" || stringInput == "n")
                {
                    Console.WriteLine("Bye for now!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Bye for now.");
            }
        }

        public void createLemonade()
        {

        }

        public void sellLemonade()
        {

        }

        public void resultsOfTheDay()
        {

        }
    }
}
