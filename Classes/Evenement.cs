using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeterie.Classes
{
    internal class Evenement
    {
        #region Propriété
        public string Nom { get; set; }
        public Lieu Lieu { get; set; }
        public DateTime Date { get; set; }
        public int Heure { get; set; }
        public int NombrePlace { get; set; }
        public List<Billet> Billets { get; set; }
        #endregion



        #region Constructor
        public Evenement(string nom, Lieu lieu, DateTime date, int heure, int nombrePlace, List<Billet> billets)
        {
            Nom = nom;
            Lieu = lieu;
            Date = date;
            Heure = heure;
            NombrePlace = nombrePlace;
            Billets = billets;
        }
        #endregion


        #region Methods
        public void RecupererBillets()
        {
            foreach (Billet billet in Billets)
            {
                Console.WriteLine(billet);
            }
        }


        #endregion

    }
}
