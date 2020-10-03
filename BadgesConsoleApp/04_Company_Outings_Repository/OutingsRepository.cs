using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Company_Outings_Repository
{
    public class OutingsRepository
    {
        private List<Outing> _listOfOutings = new List<Outing>();

        //Add Outings
        public bool AddOuting(Outing newOuting)
        {
            if (newOuting == null)
            {
                return false;
            }

            int initialCount = _listOfOutings.Count;
            _listOfOutings.Add(newOuting);

            if(initialCount < _listOfOutings.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Read Outing Lists
        public List<Outing> GetOutingList()
        {
            return _listOfOutings;
        }

        public decimal GetTotalOutingCost()
        {
            decimal grandTotal = 0.0m;

            foreach (Outing outing in _listOfOutings)
            {
                grandTotal += outing.OutingTotalCost;
            }
            return grandTotal;
        }

        public decimal GetTypeTotalCost(int outingType)
        {
            List<Outing> outingTypeList = new List<Outing>();
            decimal typeGrandTotal = 0.0m;
            foreach (Outing outing in _listOfOutings)
            {
                if ((int)outing.TypeOfOuting == outingType)
                {
                    outingTypeList.Add(outing);
                }
            }
            foreach(Outing cost in outingTypeList)
            {
                typeGrandTotal += cost.OutingTotalCost;
            }
            return typeGrandTotal;
        }
    }
}
