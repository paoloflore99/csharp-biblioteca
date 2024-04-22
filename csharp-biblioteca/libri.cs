using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{/*
    internal class libri : Documento
    {
        public int Pagine {  get; set; }
        //public string Autore { get; set; }

              //mi da errore su libri per identificativo , ma non ho trovato soluzione 
        public libri(string identificativo, string titolo, int anno, string scaffale, string autoreNome, string autoreCognome)
        {
            //this.Pagine = Pagine;
            //this.Autore = Autore;
            //List<string> autore = new List<string> { };
            this.identificativo = identificativo;
            this.titolo = titolo;
            this.anno = anno;
            this.scaffale = scaffale;
            this.autoreNome = autoreNome;
            this.autoreCognome = autoreCognome;
            //perche prende solo anno e scaffale 



        }
    }*/


    internal class libri : Documento
    {
        public int Pagine { get; set; }

        public libri(string identificativo, string titolo, int anno, string scaffale, string autoreNome, string autoreCognome)
            : base(identificativo, titolo, anno, scaffale, autoreNome, autoreCognome)
        {
           
        }
    }
}
