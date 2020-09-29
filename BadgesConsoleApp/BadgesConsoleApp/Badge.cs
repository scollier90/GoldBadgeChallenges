using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesConsoleApp
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string BadgeName { get; set; }
        public List<string> DoorList { get; set; }

        public Badge() { }

        public Badge(int badgeID, string badgeName, List<string> doorNames)
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            DoorList = doorNames;
        }
        public Badge(int badgeID, string badgeName)
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            DoorList = new List<string>();
        }
    }
}
