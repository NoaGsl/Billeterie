using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeterie.Classes
{
    internal class Lieu : Adresse
    {
        #region Propriété
        public int Capacite { get; set; }
        #endregion

        #region Constructeur
        public Lieu(int capacite, string rue, string ville) : base(rue, ville)
        {
            Capacite = capacite;
        }
        #endregion
    }
}
