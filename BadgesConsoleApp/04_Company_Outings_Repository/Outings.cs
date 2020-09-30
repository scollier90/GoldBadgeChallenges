using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Repository
{
    public class Golf
    {
        public string GolfName { get; set; }
        public int GolfPeopleAttending { get; set; }
        public DateTime GolfDateOfEvent { get; set; }
        public decimal GolfCostPerPerson { get; set; }
        public decimal GolfTotalCost { get { return GolfPeopleAttending * GolfCostPerPerson; } }

        public Golf() { }
        public Golf(string golfName, int golfPeopleAttending, DateTime golfDateofEvent, decimal golfCostPerPerson)
        {
            GolfName = golfName;
            GolfPeopleAttending = golfPeopleAttending;
            GolfDateOfEvent = golfDateofEvent;
            GolfCostPerPerson = golfCostPerPerson;
        }
    }
    public class Bowling
    {
        public string BowlingName { get; set; }
        public int BowlingPeopleAttending { get; set; }
        public DateTime BowlingDateOfEvent { get; set; }
        public decimal BowlingCostPerPerson { get; set; }
        public decimal BowlingTotalCost { get { return BowlingPeopleAttending * BowlingCostPerPerson; } }

        public Bowling() { }
        public Bowling(string bowlingName, int bowlingPeopleAttending, DateTime bowlingDateofEvent, decimal bowlingCostPerPerson)
        {
            BowlingName = bowlingName;
            BowlingPeopleAttending = bowlingPeopleAttending;
            BowlingDateOfEvent = bowlingDateofEvent;
            BowlingCostPerPerson = bowlingCostPerPerson;
        }
    }
    public class Park
    {
        public string ParkName { get; set; }
        public int ParkPeopleAttending { get; set; }
        public DateTime ParkDateOfEvent { get; set; }
        public decimal ParkCostPerPerson { get; set; }
        public decimal ParkTotalCost { get { return ParkPeopleAttending * ParkCostPerPerson; } }

        public Park() { }
        public Park(string parkName, int parkPeopleAttending, DateTime parkDateofEvent, decimal parkCostPerPerson)
        {
            ParkName = parkName;
            ParkPeopleAttending = parkPeopleAttending;
            ParkDateOfEvent = parkDateofEvent;
            ParkCostPerPerson = parkCostPerPerson;
        }
    }
    public class Concert
    {
        public string ConcertName { get; set; }
        public int ConcertPeopleAttending { get; set; }
        public DateTime ConcertDateOfEvent { get; set; }
        public decimal ConcertCostPerPerson { get; set; }
        public decimal ConcertTotalCost { get { return ConcertPeopleAttending * ConcertCostPerPerson; } }

        public Concert() { }
        public Concert(string concertName, int concertPeopleAttending, DateTime concertDateofEvent, decimal concertCostPerPerson)
        {
            ConcertName = concertName;
            ConcertPeopleAttending = concertPeopleAttending;
            ConcertDateOfEvent = concertDateofEvent;
            ConcertCostPerPerson = concertCostPerPerson;
        }
    }
}

