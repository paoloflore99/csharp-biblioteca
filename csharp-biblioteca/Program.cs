namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            Utente NuovoUtente = new Utente();
            Console.WriteLine("inserisci cognome");
            string cognome =Console.ReadLine();
            Console.WriteLine("inserisci nome");
            string nome = Console.ReadLine();
            Console.WriteLine("inserisci email");
            string email = Console.ReadLine();
            Console.WriteLine("crea la tua password");
            string password = Console.ReadLine();
            Console.WriteLine("numero del telefono");
            int telefono =Convert.ToInt32( Console.ReadLine());

            NuovoUtente.RegistrazioneUtente(cognome , nome , email ,password, telefono);

            
           // Documento documento = new Documento("identificativo1234" , "one pice" , 1998 , "" , "flore" , "paolo");


            Dictionary<string, string> autore = new Dictionary<string, string>();
            autore["nome"] = "mario";
            autore["cognome"] = "rossi";

            Console.WriteLine($"nome aure {autore["nome"]} {autore["cognome"]} ");
        } 
    }
}
