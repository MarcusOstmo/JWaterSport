using JWS.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWS
{
    class ListProvider
    {
        KundList kList;

        public static KundList getKundLista()
        {
            if (kList != null)
                return kList;
            else
                kList = new KundList();

            return kList;

        }
    }
}
