using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {

        public string identificativo { get; set; }
        public string titolo { get; set; }
        public string anno { get; set; }
        public Dictionary<int, string> tags { get; set; } = new Dictionary<int, string>();
        public string scaffale { get; set; }
        public Dictionary<string, string> autore { get; set; } = new Dictionary<string, string>();
        public Documento() { }
         
    }
}
