using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Café
{
    public class MenuRepository
    {
        public List<MenuItem> _listOfMenuItems = new List<MenuItem>();

        //Create
        public void AddItemToMenu(MenuItem item)
        {
            _listOfMenuItems.Add(item);
        }

        //Read
        public List<MenuItem> GetMenuList()
        {
            return _listOfMenuItems;
        }

        //Delete
        public bool DeleteItemFromMenu(string number)
        {
            MenuItem item = GetMenuItemByNumber(number);

            if(item == null)
            {
                return false;
            }

            int initialCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(item);

            if(initialCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper
        private MenuItem GetMenuItemByNumber(string number)
        {
            foreach(MenuItem item in _listOfMenuItems)
            {
                if(item.Number == number)
                {
                    return item;
                }
            }
            return null;
        }

        //Repository
        //public List<string> CreateIngredientList(string ingredient, string menuNumber)
        //{
        //    MenuItem addIngredient = GetMenuItemByNumber(menuNumber);

        //    if (GetMenuItemByNumber(menuNumber) == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        addIngredient.Ingredients.Add(ingredient);
        //    }
        //}


        public void Print(string ingredients)
        {
            Console.WriteLine(ingredients);
        }
    }
}
