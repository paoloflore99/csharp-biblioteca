using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class biblioteca
    {

        //aggiungo la lista dei libri , utenti e prestiti 
        //e metto la ricerca 

        private List<Documento> _documents = new List<Documento>();
        private List<Utente> utenti = new List<Utente>();
        private List<Prestito> presttito = new List<Prestito>();


        public void AggiungoDocumento(Documento documento)
        {
            _documents.Add(documento);
        }

        public void AggiungiUtente(Utente nuovoutente)
        {
           utenti.Add(nuovoutente);
        }

        public void aggiungiPrestiti(Prestito nuovoprestito)
        {
            presttito.Add(nuovoprestito);
        }

        //ricercq utente 
        //ricerca titolo

        public Documento CercaDocumentoCodice(string codice)
        {
           
        }
    }
    }

}

