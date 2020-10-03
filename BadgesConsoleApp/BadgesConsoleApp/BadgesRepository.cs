using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsoleApp
{
    public class BadgesRepository
    {
        //Create
        private Dictionary<int, Badge> badgeDictionary = new Dictionary<int, Badge>();

        public bool AddBadgeDictionaryEntry(int badgeID, Badge newBadge)
        {
            Badge addBadge = GetBadgeByID(badgeID);

            if (addBadge != null)
            {
                return false;
            }

            int initialCount = badgeDictionary.Count;
            badgeDictionary.Add(badgeID, newBadge);

            if (initialCount < badgeDictionary.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddDoorOnBadgeList(string addDoorName, int badgeID)
        {
            Badge addDoor = GetBadgeByID(badgeID);

            if(GetBadgeByID(badgeID) == null)
            {
                return false;
            }
            else
            {
                addDoor.DoorList.Add(addDoorName);
                return true;
            }
        }
        //Read
        public List<Badge> ViewAllBadgeData()
        {
            List<Badge> badgeList = new List<Badge>();
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                badgeList.Add(badge.Value);
            }
            return badgeList;
        }

        public bool RemoveDoorOnBadge(string removeDoorName, int badgeID)
        {
            Badge oldBadge = GetBadgeByID(badgeID);

            if(GetDoorList(badgeID) == null)
            {
                return false;
            }
            
            foreach(string door in oldBadge.DoorList)
            {
                if (door == removeDoorName)
                {
                    oldBadge.DoorList.Remove(removeDoorName);
                    return true;
                }
            }
            return false;
        }

        //Delete All Doors
        public bool DeleteAllDoorsOnBadge(int badgeID)
        {
            Badge deleteDoors = GetBadgeByID(badgeID);

            if (deleteDoors == null)
            {
                return false;
            }

            deleteDoors.DoorList.Clear();
            return true;
        }

        //Delete Badge
        public bool DeleteBadgeDictionaryEntry(int badgeID)
        {
            Badge deleteBadge = GetBadgeByID(badgeID);

            if (deleteBadge == null)
            {
                return false;
            }

            int initialCount = badgeDictionary.Count;
            badgeDictionary.Remove(badgeID);

            if (initialCount > badgeDictionary.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        private Badge GetBadgeByID(int badgeID)
        {
            foreach (Badge badge in badgeDictionary.Values)
            {
                if (badge.BadgeID == badgeID)
                {
                    return badge;
                }
            }
            return null;
        }
        public List<string> GetDoorList(int badgeID)
        {
            Badge viewDoors = GetBadgeByID(badgeID);
            if (viewDoors == null)
            {
                return null;
            }
            else
            {
                return viewDoors.DoorList;
            }
        }
    }
}
