using JWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWS.Controler
{
    class JavaWaterSportList
    {
        private List<Kund> myKund;

        public KundList()
        {
            myKund = new List<Kund>();
        }

        public void Add(Kund item)
        {
            myKund.Add(item);
        }

        public void Remove(Kund item)
        {
            myKund.Remove(item);
        }

        public Kund Get(int index)
        {
            return myKund.ElementAt(index);
        }

        public int Count()
        {
            return myKund.Count();
        }


        public Kund FindKund(string kund)
        {
            for (int index = 0; index < myKund.Count; index++)
            {
                if (myKund[index].getKund() == kund)
                {
                    return myKund[index];
                }
            }
            return null;
        }
    }
}
