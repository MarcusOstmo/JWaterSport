using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWS.Model
{
    class Dykarutrustning
    {
        private string fulltPaketTid;
        private bool fulltPaket;

        // default konstruktor
        public Dykarutrustning()
        {
            this.fulltPaketTid = "null";
            this.fulltPaket = false;
        }

      
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="FulltPaketTid">Kundens pakettid</param>
        /// <param name="FulltPaket">Kunden bokat Fullt Paket</param>
        public Dykarutrustning(string FulltPaketTid, bool FulltPaket)
        {
            this.fulltPaketTid = FulltPaketTid;
            this.fulltPaket = FulltPaket;
        }

        /// <summary>
        /// Return fullt paket(Ja/Nej) och pakettid
        /// </summary>
        /// <returns>fulltPaket(Ja/Nej) och pakettid</returns>
        public string getFulltPaketOchPakettid()
        {
            if (fulltPaket == true)
            {
                return "Ja   " + this.fulltPaketTid;
            }

            else
            {
                return "Nej  " + this.fulltPaketTid;
            }
        }

        /// <summary>
        /// Set FulltPaket och Pakettid
        /// </summary>
        /// <param name="StortPaket">Om kunden har bokat stort paket och tiden kunden hyr ett paket</param>
        public void setFulltPaketOchPakettid(bool FulltPaket, string FulltPakettid)
        {
            this.fulltPaket = FulltPaket;
            this.fulltPaketTid = FulltPakettid;
        }

    }
}
