using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Benutzer
    {
        public int BenutzerId { get; set; }
        public string? Name { get; set; }
        // Weitere Eigenschaften
        public virtual ICollection<Beleg>? Belege { get; set; }
    }
}
