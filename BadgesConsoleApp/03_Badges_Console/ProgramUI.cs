using BadgesConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges_Console
{
    class ProgramUI
    {
        BadgesRepository _badgesRepository = new BadgesRepository();

        public void Run()
        {
            Seed();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool continueRunning = true;
            while (continueRunning)
            {
                //Start display
                Console.WriteLine("Select a menu option: \n" +
                    "1. Create New Badge\n" +
                    "2. View Badges and Accesses\n" +
                    "3. Update Door On Badge\n" +
                    "4. Delete All Doors From Badge\n" +
                    "5. Delete Badge\n" +
                    "6. Exit Application\n");

                //User input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //Add Badge
                        CreateNewBadge();
                        break;
                    case "2":
                        //View
                        ViewAllBadges();
                        break;
                    case "3":
                        //Update Doors
                        UpdateDoorsOnBadge();
                        break;
                    case "4":
                        //Delete All Rooms
                        DeleteDoorsFromBadge();
                        break;
                    case "5":
                        //Delete Badge
                        DeleteBadge();
                        break;                     
                    case "6":
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

        //Create new Badge
        private void CreateNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the employee's last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's badge ID.");
            int badgeID = int.Parse(Console.ReadLine());

            Badge newBadge = new Badge(badgeID, lastName);

            _badgesRepository.AddBadgeDictionaryEntry(badgeID, newBadge);

            Console.WriteLine("The badge has been created."); 
        }

        //View Badges
        private void ViewAllBadges()
        {
            Console.Clear();
            Console.WriteLine("All badge data is listed below: ");

            foreach (Badge badge in _badgesRepository.ViewAllBadgeData())
            {
                Console.Write(badge.BadgeID + "\t\t" + badge.BadgeName + "\t\t" );
                foreach(string door in badge.DoorList)
                {
                    Console.Write(door + '\t');
                }
                Console.WriteLine();
            }
        }

        //Update Badge
        private void UpdateDoorsOnBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the employee's badge ID you wish to update.");
            int badgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an option.\n" +
                               "1. Add a door.\n" +
                               "2. Remove a door.");
            string doorInput = Console.ReadLine();

            if (doorInput == "1")
            {
                Console.WriteLine("Please enter the door you would like to add to this badge.");
                string addDoorName = Console.ReadLine();

                _badgesRepository.AddDoorOnBadgeList(addDoorName, badgeID);
                Console.WriteLine("The room has been added to the badge.");
            }
            else if (doorInput == "2")
            {
                Console.WriteLine("Please enter the door you would like to remove on this badge.");
                string removeDoorName = Console.ReadLine();

                _badgesRepository.RemoveDoorOnBadge(removeDoorName, badgeID);
                Console.WriteLine("The door has been removed from the badge.");
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }

            _badgesRepository.GetDoorList(badgeID);
        }


        //Delete Badge
        private void DeleteBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the employee's badge ID you wish to remove.");
            int badgeID = int.Parse(Console.ReadLine());

            _badgesRepository.DeleteBadgeDictionaryEntry(badgeID);

            if (_badgesRepository.DeleteBadgeDictionaryEntry(badgeID))
            {
                Console.WriteLine("The badge has been deleted.");
            }
            else
            {
                Console.WriteLine("The badge could not be found.");
            }

        }

        //Delete Door
        private void DeleteDoorsFromBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the employee's badge ID you wish to remove all doors from.");
            int badgeID = int.Parse(Console.ReadLine());

            _badgesRepository.DeleteAllDoorsOnBadge(badgeID);

            Console.WriteLine("All doors on the badge have been deleted.");
        }

        private void Seed()
        {
            _badgesRepository.AddBadgeDictionaryEntry(1150, new Badge(1150, "Smith", new List<string>() { "A5", "B7", "B9", "C10"}));
            _badgesRepository.AddBadgeDictionaryEntry(1151, new Badge(1151, "Jefferson", new List<string>() { "A6", "B7", "C10" }));
            _badgesRepository.AddBadgeDictionaryEntry(1152, new Badge(1152, "Johnson", new List<string>() { "A5", "A6", "B7" }));
        }
    }
}
