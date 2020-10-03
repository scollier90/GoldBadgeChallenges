using _01_Café;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Café_Console
{
    class ProgramUI
    {
        private MenuRepository _menuRepository = new MenuRepository();

        public void Run()
        {
            Seed();
            Menu();
        }
        private void Menu()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                Console.WriteLine("Select a menu option: \n" +
                    "1. Create new menu item\n" +
                    "2. Delete menu item\n" +
                    "3. View all menu items\n" +
                    "4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewItem();
                        break;
                    case "2":
                        DeleteItem();
                        break;
                    case "3":
                        ViewAllItems();
                        break;
                    case "4":
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewItem()
        {
            Console.Clear();
            MenuItem newItem = new MenuItem();

            Console.WriteLine("Please enter the menu number you wish this item to have.");
            newItem.Number = Console.ReadLine();

            Console.WriteLine("Please enter the menu name you wish this item to have.");
            newItem.Name = Console.ReadLine();

            Console.WriteLine("Please enter the menu description you wish this item to have.");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("Please enter the ingredients you wish this item to have. Please enter an ingredient (up to 7 available) and press Enter.");

            //List<string> listOfIngredients = new List<string>();
            //string ingredientInput = Console.ReadLine();

            //newItem.Ingredients = _menuRepository.CreateIngredientList(ingredientInput, newItem.Number);

            string ingredientOne = Console.ReadLine();
            string ingredientTwo = Console.ReadLine();
            string ingredientThree = Console.ReadLine();
            string ingredientFour = Console.ReadLine();
            string ingredientFive = Console.ReadLine();
            string ingredientSix = Console.ReadLine();
            string ingredientSeven = Console.ReadLine();

            newItem.Ingredients = new List<string>() { ingredientOne, ingredientTwo, ingredientThree, ingredientFour, ingredientFive, ingredientSix, ingredientSeven };

            Console.WriteLine("Please enter the price you wish this item to have (do not enter the $ sign).");
            newItem.Price = decimal.Parse(Console.ReadLine());

            _menuRepository.AddItemToMenu(newItem);
        }

        private void DeleteItem()
        {
            ViewAllItems();
            Console.WriteLine("Please enter the menu item number you'd like to remove.");
            string number = Console.ReadLine();

            bool wasDeleted = _menuRepository.DeleteItemFromMenu(number);

            if (wasDeleted)
            {
                Console.WriteLine("The menu item was removed.");
            }
            else
            {
                Console.WriteLine("The menu item could not be removed.");
            }
        }

        private void ViewAllItems()
        {
            Console.Clear();
            List<MenuItem> listOfItems = _menuRepository.GetMenuList();

            foreach (MenuItem item in listOfItems)
            {
                Console.WriteLine($"Number: {item.Number}\n" +
                    $"Name: {item.Name}\n" +
                    $"Description: {item.Description}\n" +
                    $"Ingredients:");
                    item.Ingredients.ForEach(_menuRepository.Print);
                    Console.WriteLine($"Price: {item.Price}\n");
            }
        }

        private void Seed()
        {
            MenuItem chickenSandwich = new MenuItem("1", "Chicken Sandwich", "Delicious chicken sandwich made with home breed chickens.", new List<string>() { "Chicken", "Tomato", "Lettuce", "Pickle", "Mayo"}, 9.50m);
            MenuItem baconCheeseburger = new MenuItem("2", "Bacon Cheeseburger", "A burger to drool over. Crispy bacon atop our certified beef patty with all the dressings.", new List<string>() { "Beef", "American cheese", "Tomato", "Lettuce", "Pickle", "Mayo", "Mustard" }, 11.00m);
            MenuItem chocolateMilkshake = new MenuItem("3", "Chocolate Milkshake", "A creamy milkshake using genuine chocolate - no sauce here, folks!", new List<string>() { "Chocolate ice cream", "Chocolate bars(melted)", "2% milk"}, 5.50m);

            _menuRepository.AddItemToMenu(chickenSandwich);
            _menuRepository.AddItemToMenu(baconCheeseburger);
            _menuRepository.AddItemToMenu(chocolateMilkshake);
        }
    }
}
