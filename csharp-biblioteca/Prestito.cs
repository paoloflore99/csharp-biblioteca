using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public int Id { get; set; }
        public string Utente { get; set; }
        public string finePrestito { get; set; }

        public Prestito(int id, string utente , string finePrestito)
        {
            this.Id = id;
            this.Utente = utente;
            this.finePrestito = finePrestito;
        }
    }
}
