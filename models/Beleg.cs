using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Beleg
    {
        public int BelegId { get; set; }
        public DateTime Datum { get; set; }
        // Weitere Eigenschaften
        public int BenutzerId { get; set; }
        public virtual Benutzer Benutzer { get; set; }
        public virtual ICollection<Artikel> Artikel { get; set; }
    }
}
