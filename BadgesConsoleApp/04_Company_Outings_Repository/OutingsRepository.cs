using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Repository
{
    public class OutingsRepository
    {
        private List<Golf> golfOutingList = new List<Golf>();
        private List<Bowling> bowlingOutingList = new List<Bowling>();
        private List<Park> parkOutingList = new List<Park>();
        private List<Concert> concertOutingList = new List<Concert>();

        public bool AddGolfOuting(Golf )
        {

            int initialCount = golfOutingList.Count;
            golfOutingList.Add()

            if (initialCount < golfOutingList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
