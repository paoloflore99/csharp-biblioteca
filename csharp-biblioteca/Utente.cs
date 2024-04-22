using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Telefono { get; set; }


        public Utente()
        { 
        
        } 

        public void RegistrazioneUtente(string Cognome , string Nome , string Email , string Password , int Telefono )
        {
            if (!Email.Contains("@"))
            {
                Console.WriteLine("inserire la @");
                Email = Console.ReadLine();
            }

            this.Cognome = Cognome;
            this.Nome = Nome;

            this.Password = Password;
            this.Telefono = Telefono;
            Console.WriteLine("ti sei reggistrato");
        }

    }
}
//reggistrazione utente 