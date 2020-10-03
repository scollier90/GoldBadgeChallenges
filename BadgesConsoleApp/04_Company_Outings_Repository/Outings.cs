using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Repository
{
    public class Outing
    {
        public enum OutingType
        {
            Golf = 1,
            Bowling = 2,
            Park = 3,
            Concert = 4
        }
        public string OutingName { get; set; }
        public int OutingPeopleAttending { get; set; }
        public DateTime OutingDateOfEvent { get; set; }
        public decimal OutingCostPerPerson { get; set; }
        public decimal OutingTotalCost { get { return OutingPeopleAttending * OutingCostPerPerson; } }
        public OutingType TypeOfOuting { get; set; }



        public Outing() { }
        public Outing(string outingName, int outingPeopleAttending, DateTime outingDateofEvent, decimal outingCostPerPerson, OutingType typeOfOuting)
        {
            OutingName = outingName;
            OutingPeopleAttending = outingPeopleAttending;
            OutingDateOfEvent = outingDateofEvent;
            OutingCostPerPerson = outingCostPerPerson;
            TypeOfOuting = typeOfOuting;
        }
    }
}

