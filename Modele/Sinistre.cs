using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace monitor.Modele
{
    public class Sinistre
    {
        public int? TAC_CODE { get; set; }
        public DateTime DateCreation { get; set; }
        public int EtatDemande { get; set; }
        public string libelle { get; set; }
        public int NatureDemande { get; set; }
        public string libelleLong { get; set; }
        public string Immatriculation { get; set; }
        public string contactMail { get; set; }
        public string sin_lieu_ville { get; set; }

    }
}