using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeing4
{
    class Notitie
    {

        
        public string Opschrift { get; set; }
        public Notitie(string opschrijft)
        {
            Opschrift = opschrijft;
        }

        public void Bijschrijven(string bijschrijft)
        {

            Opschrift += bijschrijft;
        }

    }
}
