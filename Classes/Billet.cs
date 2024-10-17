using Billeterie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeterie.Classes
{
    internal class Billet
    {
        #region Propriété
        public int NumeroPlace { get; set; }
        public Client Client { get; set; }
        public Evenement Evenement { get; set; }
        public IEnumPlace TypePlace { get; set; }
        #endregion



        #region Constructeur
        public Billet(int numeroPlace, Client client, Evenement evenement, IEnumPlace typePlace)
        {
            NumeroPlace = numeroPlace;
            Client = client;
            Evenement = evenement;
            TypePlace = typePlace;
        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"Ce billet appartient à {Client.Nom}, {Client.Prenom} pour l'évenement {Evenement.Nom} qui se déroulera le {Evenement.Date}";
        }



        #endregion


    }
}
