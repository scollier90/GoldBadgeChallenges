using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Repository
{
    public class OutingsRepository
    {
        private List<Golf> _golfOutingList = new List<Golf>();
        private List<Bowling> _bowlingOutingList = new List<Bowling>();
        private List<Park> _parkOutingList = new List<Park>();
        private List<Concert> _concertOutingList = new List<Concert>();

        //Add Outings
        public void AddGolfOuting(Golf newOuting)
        {
            _golfOutingList.Add(newOuting);
        }
        public void AddBowlingOuting(Bowling newOuting)
        {
            _bowlingOutingList.Add(newOuting);
        }
        public void AddParkOuting(Park newOuting)
        {
            _parkOutingList.Add(newOuting);
        }
        public void AddConcertOuting(Concert newOuting)
        {
            _concertOutingList.Add(newOuting);
        }

        //Read Outing Lists
        public List<Golf> GetBowlingOutingList()
        {
            return _golfOutingList;
        }
        public List<Bowling> GetGolfOutingList()
        {
            return _bowlingOutingList;
        }
        public List<Park> GetParkOutingList()
        {
            return _parkOutingList;
        }
        public List<Concert> GetConcertOutingList()
        {
            return _concertOutingList;
        }

        //Helper method
        private Type[] FindOutingByType()
        {
            foreach()
        }
    }
}
