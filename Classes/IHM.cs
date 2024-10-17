using Billeterie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeterie.Classes
{
    internal class IHM
    {

        #region Propriété

        public List<Client> Clients { get; set; } = new();
        public List<Evenement> Evenements { get; set; } = new();
        public List<Lieu> Lieu { get; set; } = new();


        #endregion


        #region Methods

        public void MenuIHM()
        {
            Console.Clear();
            Console.WriteLine("=== Menu Billeterie === \n\n" +
                "1-- Client \n" +
                "2-- Billet \n" +
                "3-- Evenement \n" +
                "4-- Lieu \n" +
                "0-- Quitter");

            Console.Write("Que voulez vous faire: ");
            int Choice = int.Parse(Console.ReadLine() ?? "0");


            switch (Choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    ClientMenu();
                    break;
            }

        }


        public void ClientMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Menu Client === \n\n" +
                "1-- Réserver un billet \n" +
                "0-- Retour");

            Console.Write("Que voulez vous faire: ");
            int Choice = int.Parse(Console.ReadLine() ?? "0");


            switch (Choice)
            {
                case 0:
                    MenuIHM();
                    break;
                case 1:
                    ReserveUnBillet();
                    break;
            }

        }

        public void ReserveUnBillet()
        {
            Console.Clear();
            Client client = CreateClient();
            IEnumPlace place = AskForPlaceType();

            Evenement Event = Evenements[0];
            Billet billet = new Billet(Event.Billets.Count() + 1,client,Event,place);

            client.Billets.Add(billet);
            Clients.Add(client);

            Console.WriteLine($"Billet réservé avec succes {billet}");
            Thread.Sleep(5000);
            MenuIHM();
        }


        public Client CreateClient()
        { 
            Console.Clear();
            Console.WriteLine("=== Create a client === \n\n");

            Console.Write("\n Entrez votre nom : ");
            string Name = Console.ReadLine() ?? "";
            Console.Write("\n Entrez votre prénom : ");
            string Surname = Console.ReadLine() ?? "";
            Console.Write("\n Entrez votre rue : ");
            string Rue = Console.ReadLine() ?? "";
            Console.Write("\n Entrez votre ville : ");
            string Ville = Console.ReadLine() ?? "";
            Adresse adress = new Adresse(Rue, Ville);
            Console.Write("\n Entrez votre age: ");
            int Age = int.Parse(Console.ReadLine() ?? "18");
            Console.Write("\n Entrez votre num de tel : ");
            string PhoneNumber = Console.ReadLine() ?? "00 00 00 00 00";
            List<Billet> ListBillets = new();

            Client client = new Client(Surname, Name, adress, Age, PhoneNumber, ListBillets);

            return client;
        }

        public IEnumPlace AskForPlaceType()
        {
            Console.Clear();

            Console.WriteLine("What kind of place do you want ? \n\n" +
                "1-- Standar\n" +
                "2-- Gold \n" +
                "3-- VIP");

            Console.Write("Quel est vtojre choix: ");
            int Choice = int.Parse(Console.ReadLine() ?? "0");

            switch (Choice)
            {
                case 0: return IEnumPlace.Standar;
                case 1: return IEnumPlace.Gold;
                case 2: return IEnumPlace.Vip;
            }

            return IEnumPlace.Standar;
        }
        #endregion
    }
}
