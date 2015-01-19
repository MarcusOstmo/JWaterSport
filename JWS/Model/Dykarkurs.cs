using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWS.Model
{
    class Dykarkurs
    {
        private string datum;
        private string tidDykarkurs;
        private string dykinstruktör;

        public Dykarkurs()
        {
            this.datum = "null";
            this.tidDykarkurs = "null";
            this.dykinstruktör = "null";
        }

        public Dykarkurs(string Datum, string TidDykarkurs, string Dykinstruktör)
        {
            this.datum = Datum;
            this.tidDykarkurs = TidDykarkurs;
            this.dykinstruktör = Dykinstruktör;
        }

        /// <summary>
        /// Return datum
        /// </summary>
        /// <returns>datum</returns>
        public string getDatum()
        {
            return this.datum;
        }

        /// <summary>
        /// Return tidDykarkurs
        /// </summary>
        /// <returns>tidDykarkurs</returns>
        public string getTidDykarkurs()
        {
            return this.tidDykarkurs;
        }

        /// <summary>
        /// Return dykinstruktör
        /// </summary>
        /// <returns>dykinstruktör</returns>
        public string getDykinstruktör()
        {
            return this.dykinstruktör;
        }

        /// <summary>
        /// Set datum
        /// </summary>
        /// <param name="Telefon">Kundens valda dykinstruktör</param>
        public void setDatum(string Datum)
        {
            this.datum = Datum;
        }

        /// <summary>
        /// Set tidDykarkurs 
        /// </summary>
        /// <param name="Telefon">Kundens valda kurstid</param>
        public void setTidDykarkurs(string TidDykarkurs)
        {
            this.tidDykarkurs = TidDykarkurs;
        }

        /// <summary>
        /// Set dykinstruktör
        /// </summary>
        /// <param name="Telefon">Kundens valda dykinstruktör</param>
        public void setDykinstruktör(string Dykinstruktör)
        {
            this.dykinstruktör = Dykinstruktör;
        }
    }
}
