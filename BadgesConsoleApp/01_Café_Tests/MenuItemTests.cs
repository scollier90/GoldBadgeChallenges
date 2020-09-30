using System;
using _01_Café;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Café_Tests
{
    [TestClass]
    public class MenuItemTests
    {
        MenuRepository _menuRepository = new MenuRepository();
        private void Seed()
        {
            _menuRepository.AddItemToMenu("1", "Chicken Sandwich", "Delicious chicken sandwich made with home breed chickens.", new List<string>() { "Chicken", "Tomato", "Lettuce", "Pickle", "Mayo" }, 9.50m);
            _menuRepository.AddItemToMenu("2", "Bacon Cheeseburger", "A burger to drool over. Crispy bacon atop our certified beef patty with all the dressings.", new List<string>() { "Beef", "American cheese", "Tomato", "Lettuce", "Pickle", "Mayo", "Mustard" }, 11.00m);
            _menuRepository.AddItemToMenu("3", "Chocolate Milkshake", "A creamy milkshake using genuine chocolate - no sauce here, folks!", new List<string>() { "Chocolate ice cream", "Chocolate bars(melted)", "2% milk" }, 5.50m);
        }

        [TestMethod]
        public void AddItemToMenuTest()
        {
            Seed();
            MenuItem item = new MenuItem();
            bool result = false;

            Assert.IsTrue(_menuRepository.AddItemToMenu(result));
        }
        [TestMethod]
        public void GetMenuListTest()
        {

        }
        [TestMethod]
        public void DeleteItemFromMenuTest()
        {

        }
        [TestMethod]
        public void PrintTest()
        {

        }
    }
}
