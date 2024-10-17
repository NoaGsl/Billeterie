using Billeterie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeterie.Classes
{
    internal class Client
    {
        #region Propriétés
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }
        public int Age { get; set; }
        public string NumeroDeTelephone { get; set; }
        public List<Billet> Billets { get; set; }
        #endregion


        #region Constructeur
        public Client(string nom, string prenom, Adresse adresse, int age, string numeroDeTelephone, List<Billet> billets)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Age = age;
            NumeroDeTelephone = numeroDeTelephone;
            Billets = billets;
        }
        #endregion

        #region Methods

        public void ReserverBillet(int numeroPlace, Evenement evenement, IEnumPlace typePlace)
        {
            Billet billet = new Billet(numeroPlace, this, evenement, typePlace);
            Billets.Add(billet);
            evenement.Billets.Add(billet);
        }

        #endregion
    }
}
