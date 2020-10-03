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
            Console.Clear();
            List<Outing> listOfOutings = _outingsRepository.GetOutingList();

            foreach (Outing outing in listOfOutings)
            {
                Console.WriteLine($"Name: {outing.OutingName}\n" +
                    $"Number of people attending: {outing.OutingPeopleAttending}\n" +
                    $"Date of outing: {outing.OutingDateOfEvent}\n" +
                    $"Cost per person: {outing.OutingCostPerPerson}\n" +
                    $"Total cost of outing: {outing.OutingTotalCost}\n" +
                    $"Outing type: {outing.TypeOfOuting}\n");
            }
        }
        //Add Outings
        private void AddOutingToList()
        {
            Console.Clear();
            Console.WriteLine("Please select the type of outing you wish to add to: \n" +
                            "1. Golf\n" +
                            "2. Bowling\n" +
                            "3. Amusement Park\n" +
                            "4. Concert");
            string outingInput = Console.ReadLine();
            if (outingInput == "1" || outingInput == "2" || outingInput == "3" || outingInput == "4" )
            {
                Console.WriteLine("Please enter the name of this outing.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the total people attending this outing.");
                int peopleAttending = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the date of this outing. Use formatting as such: (YYYY, MM, DD)");
                DateTime dateOnly = DateTime.Parse(Console.ReadLine());
                DateTime dateEntry = dateOnly.Date;
                Console.WriteLine("Please enter the cost per person for this outing.");
                decimal costPerPerson = decimal.Parse(Console.ReadLine());
                int outingParse = int.Parse(outingInput);
                Outing.OutingType outingType = (Outing.OutingType)Enum.ToObject(typeof(Outing.OutingType), outingParse);

                Outing newOuting = new Outing(name, peopleAttending, dateEntry, costPerPerson, outingType);
                if (_outingsRepository.AddOuting(newOuting) == true)
                {
                    Console.WriteLine("The outing '" + (name) + "' has been added.");
                }
            }
            else
            {
                Console.WriteLine("Please choose a correct outing type.");
            }
        }
        //Display Total Cost
        private void DisplayOutingTotalCost()
        {
            Console.Clear();
            Console.WriteLine("The total cost of all outings is listed below.");
            Console.WriteLine(_outingsRepository.GetTotalOutingCost());
        }
        //Display Cost by Type
        private void DisplayOutingCostByType()
        {
            Console.Clear();
            Console.WriteLine("Please enter the type of outing you would like to see the total cost for: \n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");
            int outingType = int.Parse(Console.ReadLine());

            if (outingType == 1)
            {
                Console.WriteLine("All golf outings for the year were: ");

                Console.WriteLine(_outingsRepository.GetTypeTotalCost(outingType));
            }
            else if (outingType == 2)
            {
                Console.WriteLine("All bowling outings for the year were: ");
                Console.WriteLine(_outingsRepository.GetTypeTotalCost(outingType));
            }
            else if (outingType == 3)
            {
                Console.WriteLine("All amusement park outings for the year were: ");
                Console.WriteLine(_outingsRepository.GetTypeTotalCost(outingType)); 
            }
            else if (outingType == 4)
            {
                Console.WriteLine("All concert outings for the year were: ");
                Console.WriteLine(_outingsRepository.GetTypeTotalCost(outingType)); 
            }
            else
            {
                Console.WriteLine("Please choose a correct outing type.");
            }

        }
        private void Seed()
        {
            _outingsRepository.AddOuting(new Outing("MS Golf", 8, new DateTime(2020, 7, 21), 120.00m, (Outing.OutingType)Enum.ToObject(typeof(Outing.OutingType), 1)));
            _outingsRepository.AddOuting(new Outing("Cosmic Bowling", 12, new DateTime(2020, 10, 2), 15.00m, (Outing.OutingType)Enum.ToObject(typeof(Outing.OutingType), 2)));
            _outingsRepository.AddOuting(new Outing("King's Island", 20, new DateTime(2020, 8, 28), 60.00m, (Outing.OutingType)Enum.ToObject(typeof(Outing.OutingType), 3)));
            _outingsRepository.AddOuting(new Outing("NSYNC", 35, new DateTime(2020, 6, 14), 200.00m, (Outing.OutingType)Enum.ToObject(typeof(Outing.OutingType), 4)));
            _outingsRepository.AddOuting(new Outing("GA Golfing", 10, new DateTime(2020, 5, 17), 80.00m, Outing.OutingType.Golf));
            _outingsRepository.AddOuting(new Outing("FL Golfing", 9, new DateTime(2020, 8, 26), 90.00m, Outing.OutingType.Golf));
            _outingsRepository.AddOuting(new Outing("Madonna", 22, new DateTime(2020, 6, 18), 250.00m, Outing.OutingType.Concert));
            _outingsRepository.AddOuting(new Outing("Cedar Point", 18, new DateTime(2020, 6, 5), 80.00m, Outing.OutingType.Park));
            _outingsRepository.AddOuting(new Outing("50's Bowling", 10, new DateTime(2020, 3, 20), 20.00m, Outing.OutingType.Bowling));
        }
    }
}
