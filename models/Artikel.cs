using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Artikel
    {
        public int ArtikelId { get; set; }
        public string Bezeichnung { get; set; }
        // Weitere Eigenschaften
        public int BelegId { get; set; }
        public virtual Beleg Beleg { get; set; }
    }
}
