using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Environ_Dev_Logiciels
{
    class Entreprise
    {
        private String nameEntreprise;

        public String NameEntreprise
        { get; set; }

        private String locality;

        public String Locality
        { get; set; }

        public Entreprise(String nameEntreprise, String locality)
        {
            NameEntreprise = nameEntreprise;
            Locality = locality;
        }

        public override string ToString()
        {
            return "Nom de l'entreprise : " + NameEntreprise + "\r\n Localité : " + Locality + "\r\n";
        }


    }
}
