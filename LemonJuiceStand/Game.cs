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
        Day day = new Day();
        private List<Day> days;
        int currentDay;
        int amountOfDays;
        int displayPrice, totalPurchases;
        string myStore;
        double totalProfit, cupPriceChoice;


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
                int input = Convert.ToInt32(Console.ReadLine());
                double priceAllTogether = input * store.pricePerLemon;
                player.wallet.Money -= priceAllTogether; 
                Console.WriteLine("You spent ${0}", priceAllTogether);
                Console.Write("Would you like to exit? (Yes or No): ");
                string stringInput = Console.ReadLine().ToLower();
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
                player.wallet.Money -= priceAllTogether;
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
                player.wallet.Money -= priceAllTogether;
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
                player.wallet.Money -= priceAllTogether;
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

        public static void createLemonade()
        {
            //NEED TO KNOW: HOW MANY LEMONS WILL BE IN PITCHER OF LEMONADE?
            Console.WriteLine("**********************************");
            Console.WriteLine("*  DESIGN YOUR LEMONADE BELOW!   *");
            Console.WriteLine("**********************************");
            Console.Write("How many lemons will be in the pitcher of lemonade: ");
            string lemonChoice = Console.ReadLine();
            //NEED TO KNOW: HOW MANY SUGAR CUBES WILL BE IN PITCHER OF LEMONADE?
            Console.Write("How many sugar cubes will be in the pitcher of lemonade: ");
            string sugarChoice = Console.ReadLine();
            //NEED TO KNOW: HOW MANY ICE CUBES WILL BE IN PITCHER OF LEMONADE?
            Console.Write("How many ice cubes will be in the pitcher of lemonade: ");
            string iceChoice = Console.ReadLine();
            Console.Write("How many ice cubes will be in the pitcher of lemonade: ");
            cupPriceChoice = Console.ReadLine();
        }

        public void sellLemonade()
        {
            //CREATE OUR CUSTOMERS 
            if (day.weather.condition == "Sunny")
            {
                for (int i = 0; i < 80; i++)
                {
                    day.customers.Add(new Customer("Customer" + i));
                }
            }
            else if (day.weather.condition == "Overcast")
            {
                for (int i = 0; i < 65; i++)
                {
                    day.customers.Add(new Customer("Customer" + i));
                }
            }
            else if (day.weather.condition == "Windy")
            {
                for (int i = 0; i < 35; i++)
                {
                    day.customers.Add(new Customer("Customer" + i));
                }
            }
            else if (day.weather.condition == "Rainy")
            {
                for (int i = 0; i < 25; i++)
                {
                    day.customers.Add(new Customer("Customer" + i));
                }
            }
            else if (day.weather.condition == "Snowy")
            {
                for (int i = 0; i < 15; i++)
                {
                    day.customers.Add(new Customer("Customer" + i));
                }
            }
            for (int i = 0; i < day.customers.Count; i++)
            {
                if (player.inventory.cups.Count > 0 && day.customers[i].flavorScore > 0)
                {
                    totalPurchases++;
                    player.wallet.Money += cupPriceChoice;
                    player.inventory.cups.RemoveAt(0);
                }
            }
        }
        

        public void resultsOfTheDay()
        {
            //TELL USER THE SCORE 
            Console.WriteLine("Your total profit for the Day is {0}", totalProfit);
            Console.WriteLine("Your total purchases: {0}", totalPurchases);
            Console.WriteLine("The Weather today is: {0}", day.weather.condition);
            Console.ReadLine();
        }
      




}
