using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWS.Model
{
    class Kund
    {
        //medlemsvariabler
        private string förnamn;
        private string efternamn;
        private string adress;
        private string telefon;
        private string kund;
        private string fulltPaketTid;
        private bool fulltPaket;
        private string dykinstruktör;
        private string tidDykarkurs;
         
       

        // default konstruktor
        public Kund()
        {
            this.förnamn = "null";
            this.efternamn = "null";
            this.adress = "null";
            this.telefon = "null";
            this.fulltPaketTid = "null";
            this.fulltPaket = false;
            this.tidDykarkurs = "null";
            this.dykinstruktör = "null";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Förnamn">Kundens förnamn</param>
        /// <param name="Efternamn">Kundens efternamn</param>
        /// <param name="Adress">Kundens adress</param>
        /// <param name="Telefon">Kundens telefonnummer</param>
        /// <param name="FulltPaketTid">Kundens pakettid</param>
        /// <param name="FulltPaket">Kunden bokat Fullt Paket</param>
        public Kund(string Förnamn, string Efternamn, string Adress, string Telefon, string FulltPaketTid, bool FulltPaket, string TidDykarkurs, string Dykinstruktör)
        {
            this.förnamn = Förnamn;
            this.efternamn = Efternamn;
            this.adress = Adress;
            this.telefon = Telefon;
            this.fulltPaketTid = FulltPaketTid;
            this.fulltPaket = FulltPaket;
            this.tidDykarkurs = TidDykarkurs;
            this.dykinstruktör = Dykinstruktör;
        }

        #region Get
        /// <summary>
        /// Return förnamn
        /// </summary>
        /// <returns>förnamn</returns>
        public string getFörnamn()
        {
            return this.förnamn;
        }

        /// <summary>
        /// Return efternamn
        /// </summary>
        /// <returns>efternamn</returns>
        public string getEfternamn()
        {
            return this.efternamn;
        }

        /// <summary>
        /// Return kund
        /// </summary>
        /// <returns>kund</returns>
        public string getKund()
        {
            return this.kund;
        }


        /// <summary>
        /// Return adress
        /// </summary>
        /// <returns>adress</returns>
        public string getAdress()
        {
            return this.adress;
        }

        /// <summary>
        /// Return telefon
        /// </summary>
        /// <returns>telefon</returns>
        public string getTelefon()
        {
            return this.telefon;
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

        #endregion 

        #region Set
        /// <summary>
        /// Set förnamn
        /// </summary>
        /// <param name="Förnamn">Kundens förnamn</param>
        public void setFörnamn(string Förnamn)
        {
            this.förnamn = Förnamn;
        }

        /// <summary>
        /// Set efternamn
        /// </summary>
        /// <param name="Efternamn">Kundens efternamn</param>
        public void setEfternamn(string Efternamn)
        {
            this.efternamn = Efternamn;
        }

        /// <summary>
        /// Set Adress
        /// </summary>
        /// <param name="Adress">Kundens adress</param>
        public void setAdress(string Adress)
        {
            this.adress = Adress;
        }

        /// <summary>
        /// Set telefon
        /// </summary>
        /// <param name="Telefon">Kundens telefonnummer</param>
        public void setTelefon(string Telefon)
        {
            this.telefon = Telefon;
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

        #endregion

       /* public override string ToString()
        {
            string response = this.förnamn + "\n" + this.efternamn + "\n" + this.adress + "\n" + this.telefon + "\n" + this.fulltPaket;

            return response;
        }
        */
    }
}
