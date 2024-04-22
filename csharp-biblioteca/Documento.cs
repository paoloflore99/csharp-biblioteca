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
        public int anno { get; set; }
        //public Dictionary<int, string> tags { get; set; } = new Dictionary<int, string>();
        public string scaffale { get; set; }
        //public Dictionary<string, string> autore { get; set; } = new Dictionary<string, string>();
        //public List<string> autore = new List<string> { };
        public string autoreNome { get; set; }
        public string autoreCognome { get; set; }




        public Documento(string identificativo , string titolo ,int anno , string scaffale , string autoreNome , string autoreCognome ) 
        {
            this.identificativo = identificativo;
            this.titolo = titolo;
            this.anno = anno;
           // this.tags = tags;
            this.scaffale = scaffale;
            //this.autore.Add(autore);
            this.autoreNome = autoreNome;
            this.autoreCognome = autoreCognome;

            //this.autore.Add("nome", nomeAutore);
            //this.autore.Add("cognome", cognomeAutore);

        }

        //"marco polo" , "frabrizio " , "autere misterioso "
        
    }


}
