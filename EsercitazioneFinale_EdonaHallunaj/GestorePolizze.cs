// See https://aka.ms/new-console-template for more information
using EsercitazioneFinale_EdonaHallunaj.Models;
using EsercitazioneFinale_EdonaHallunaj.Repository;

internal class GestorePolizze
{
    static IRepositoryCliente RepCliente = new RepositoryCliente();
    static IRepositoryPolizza RepPolizza = new RepositoryPolizza();
    internal static bool Menù()
    {
        Console.WriteLine("Benvenuto in Gestore Polizze Assicurative!");
        Console.WriteLine("1. Inserisci un nuovo cliente");
        Console.WriteLine("2. Modifica polizza assicurativa esistente");
        Console.WriteLine("3. Stampare polizze esistenti nel database");
        int scelta = -1;
        Console.Write("Scelta ->");
        bool verifica = Int32.TryParse(Console.ReadLine(), out scelta);
        while (scelta > 5 || scelta < 0 || verifica == false)
        {
            Console.WriteLine("Inserisci un valore corretto");
            verifica = Int32.TryParse(Console.ReadLine(), out scelta);
        }
        return GestireScelta(scelta);
    }

    private static bool GestireScelta(int scelta)
    {
        bool continua = true;
        switch (scelta)
        {
            case 1:
                AggiungiCliente();
                break;
            case 2:
                AggiungiPolizza();
                break;
            case 3:
                StampaPolizze();
                break;
            default:
                continua = false;
                Console.WriteLine("Arrivederci");
                break;
        }
        return continua;
    }

    static void AggiungiCliente()
    {
        Console.Write("Codice dipendente: ");
        string codice = Console.ReadLine();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("Indirizzo:");
        string indirizzo = Console.ReadLine();

        Cliente cliente = new Cliente()

        {
            CodiceFiscale = codice,
            Nome = nome,
            Cognome = cognome,
            Indirizzo = indirizzo,

        };

        RepCliente.Create(cliente);
        Console.WriteLine("Cliente aggiunto");

    }
    private static void AggiungiPolizza()
    {
        Console.Write("Data Stipula: ");
        DateTime data;
        bool verificadata = DateTime.TryParse(Console.ReadLine(), out data);
        Console.Write("Importo: ");
        float? importo = float.Parse(Console.ReadLine());
        Console.Write("Rata Mensile: ");
        float? rata= float.Parse(Console.ReadLine());
        Console.Write("Codice Fiscale Cliente:");
        string codice = Console.ReadLine();

        Polizza polizza = new Polizza()

        {
            DataStipula = data,
            ImportoAssicurato = importo,
            RataMensile = rata,
            CodiceFiscale= codice
            

        };

        RepPolizza.Create(polizza);
        Console.WriteLine("Polizza aggiunta");

    }

    private static void StampaPolizze()
    {
        throw new NotImplementedException();
    }
}   

    

