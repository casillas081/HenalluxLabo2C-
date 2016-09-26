using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Environ_Dev_Logiciels
{
    class ProfessionalContact : Person
    {

        private String profession;

        public String Profession
        { get; set; }

        private int telProfessional;

        public int TelProfessional
        { get; set; }

        private String adrMailProfessional;

        public String AdrMailProfessional
        { get; set; }

        private List<Entreprise> lstEntreprise = new List<Entreprise>();

        public List<Entreprise> LstEntreprise { get; set; }

        public ProfessionalContact(String name, String lastName, String profession,int telProfessional, String adrMailProfessional) : base(name, lastName)
        {
            Profession = profession;
            TelProfessional = telProfessional;
            AdrMailProfessional = adrMailProfessional;
        }

        public override string ToString()
        {
            return base.ToString() + "( " + TelProfessional + " )\r\n" + Profession + "\r\n" + AdrMailProfessional + "\r\n";
        }

        public override bool HasHisBirthday()
        {
            return false;
        }

        public void EntrepriseAdd(Entreprise entrepr)
        {
            LstEntreprise.Add(entrepr);
        }
    }
}
