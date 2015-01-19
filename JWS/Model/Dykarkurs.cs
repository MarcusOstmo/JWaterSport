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
        /// Return tidDykarkurs och dykinstruktör
        /// </summary>
        /// <returns>tidDykarkurs och dykinstruktör</returns>
        public string getTidDykarkursOchDykinstruktör()
        {
            return this.dykinstruktör + "   " + this.tidDykarkurs;
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
        /// Set tidDykarkurs och dykinstruktör
        /// </summary>
        /// <param name="Telefon">Kundens valda kurstid och dykinstruktör</param>
        public void setTidDykarkursOchDykinstruktör(string TidDykarkurs, string Dykinstruktör)
        {
            this.tidDykarkurs = TidDykarkurs;
            this.dykinstruktör = Dykinstruktör;
        }
    }
}
