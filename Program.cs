using Billeterie.Classes;
using Billeterie.Classes.Enum;

Adresse adresse = new Adresse("Rue","ville");
Client client = new Client("Caudron","Hugo",adresse,19,"07 07 07 07 07",new());

Lieu lieu = new Lieu(500,"ruee","vilee");
DateTime eventDate = new DateTime(2024, 10, 17);
Evenement evenement = new Evenement("Event", lieu, eventDate, 12, 400, new());

Billet billet = new Billet( 1, client, evenement, IEnumPlace.Gold);

client.ReserverBillet(1,evenement,IEnumPlace.Gold);

IHM iHM = new IHM();
iHM.Evenements.Add(evenement);

iHM.MenuIHM();
