using _04_Company_Outings_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Console
{
    class ProgramUI
    {
        OutingsRepository _outingsRepository = new OutingsRepository();

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
                //Start display
                Console.WriteLine("Select a menu option: \n" +
                    "1. Display All Outings\n" +
                    "2. Add Outing To List\n" +
                    "3. Display Total Cost Of Outings\n" +
                    "4. Display Outing Cost By Type\n" +
                    "5. Exit Application\n");

                //User input
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //Display List
                        DisplayAllOutings();
                        break;
                    case "2":
                        //View Outings
                        AddOutingToList();
                        break;
                    case "3":
                        //Display Total Cost
                        DisplayOutingTotalCost();
                        break;
                    case "4":
                        //Display Cost by Type
                        DisplayOutingCostByType();
                        break;
                    case "5":
                        //Exit
                        Console.WriteLine("You are now exiting the application.");
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Display List
        private void DisplayAllOutings()
        {
            Console.WriteLine("A list of all outings is displayed below.");
        }
        //View Outings
        private void AddOuting()
        {

            Console.WriteLine("Please select the type of outing you wish to add to: \n" +
                            "1. Golf\n" +
                            "2. Bowling\n" +
                            "3. Amusement Park\n" +
                            "4. Concert");
            string outingType = Console.ReadLine();

            Console.WriteLine("Please enter the name of this outing.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the total people attending this outing.");
            int peopleAttending = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date of this outing. Use formatting as such: (YYYY, MM, DD)");
            DateTime dateOnly = DateTime.Parse(Console.ReadLine());
            DateTime dateEntry = dateOnly.Date;
            Console.WriteLine("Please enter the cost per person for this outing.");
            decimal costPerPerson = decimal.Parse(Console.ReadLine());

            if (outingType == "1")
            {
                _outingsRepository.AddGolfOuting(newOuting);
            }
            else if (outingType == "2")
            {

            }
            else if (outingType == "3")
            {

            }
            else if (outingType == "4")
            {

            }
            else
            {
                Console.WriteLine("Please choose a correct outing type.");
            }
        }
        //Display Total Cost
        private void DisplayOutingTotalCost()
        {
            Console.WriteLine("The total cost of all outings is listed below.");
        }
        //Display Cost by Type
        private void DisplayOutingCostByType()
        {
            Console.WriteLine("Please enter the type of outing you would like to see the total cost for: \n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            string outingType = Console.ReadLine();
            if (outingType == "1")
            {
                Console.WriteLine("All golf outings for the year were: ");
            }
            else if (outingType == "2")
            {
                Console.WriteLine("All bowling outings for the year were: ");
            }
            else if (outingType == "3")
            {
                Console.WriteLine("All amusement park outings for the year were: ");
            }
            else if (outingType == "4")
            {
                Console.WriteLine("All concert outings for the year were: ");
            }
            else
            {
                Console.WriteLine("Please choose a correct outing type.");
            }

        }
        private void Seed()
        {

        }
    }
}
