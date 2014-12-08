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
       

        //default konstructor
        public Kund()
        {
            this.förnamn = "null";
            this.efternamn = "null";
            this.adress = "null";
            this.telefon = "null";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="Förnamn">Kundens förnamn</param>
        /// <param name="Efternamn">Kundens efternamn</param>
        /// <param name="Adress">Kundens adress</param>
        /// <param name="Telefon">Kundens telefonnummer</param>
        public Kund(string Förnamn, string Efternamn, string Adress, string Telefon)
        {
            this.förnamn = Förnamn;
            this.efternamn = Efternamn;
            this.adress = Adress;
            this.telefon = Telefon;
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
        #endregion
    }
}
