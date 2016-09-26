using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Environ_Dev_Logiciels
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact contactPrivate1 = new PrivateContact("Schepmans", "Christophe", 0493654401, "christ.schepmans@hotmail.com", new DateTime(1994, 09, 08));
            PrivateContact contactPrivate2 = new PrivateContact("Williams", "Serena", 1172427703, "serena.williams@live.com", new DateTime(1981, 09, 26));

            System.Console.WriteLine("Debut des Contacts Privé\r\n");
            System.Console.WriteLine(contactPrivate1);
            System.Console.WriteLine(contactPrivate2);
            System.Console.WriteLine("Fin des Contacts Privé\r\n");

            //ProfessionalContact contactProfessional1 = new ProfessionalContact("Daniel", "Antoine", "Independant", 0677987014, "antoine.daniel@gmail.com");
            //ProfessionalContact contactProfessional2 = new ProfessionalContact("Clark", "Ken", "Consultant", 0474569825, "Ken.Clark@gmail.com");
            //ProfessionalContact contactProfessional3 = new ProfessionalContact("Wayne", "Bruce", "Consultant", 0496857126, "wayne.bruce@gmail.com");

            Entreprise entreprise1 = new Entreprise("Henallux", "Namur");
            Entreprise entreprise2 = new Entreprise("SainteMarie", "Huy");

            //contactProfessional2.EntrepriseAdd(entreprise1);
            //contactProfessional2.EntrepriseAdd(entreprise2);

            List<ProfessionalContact> lstProfessional = new List<ProfessionalContact>()
            {
                new ProfessionalContact("Daniel", "Antoine", "Independant", 0677987014, "antoine.daniel@gmail.com"),
                new ProfessionalContact("Clark", "Ken", "Consultant", 0474569825, "Ken.Clark@gmail.com"),
                new ProfessionalContact("Wayne", "Bruce", "Consultant", 0496857126, "wayne.bruce@gmail.com"),
            };

            lstProfessional[1].EntrepriseAdd(entreprise1);

            var contactProfessionalIndependant = from contactProfessional in lstProfessional
                                                 where contactProfessional.Profession == "Independant"
                                                 select contactProfessional;

            if (contactProfessionalIndependant != null)
            {
                System.Console.WriteLine("Debut des Contacts Professionel Independant\r\n");
                //System.Console.WriteLine(contactProfessional1);
                //System.Console.WriteLine(contactProfessional2);
                //System.Console.WriteLine(contactProfessional3);
                foreach(var contactProfessional in contactProfessionalIndependant)
                {
                    System.Console.WriteLine(contactProfessional);
                }

                System.Console.WriteLine("Fin des Contacts Professionel Independant\r\n");
            }

            var contactProfessionalConsultantEntrep1 = lstProfessional.Where(contactEntreprise => contactEntreprise.LstEntreprise.Exists(entrepriseName => entrepriseName.NameEntreprise == "Henallux"));

            if(contactProfessionalConsultantEntrep1 != null)
            {
                System.Console.WriteLine("Debut des Contacts Professionel consultant a Henallux\r\n");
                foreach(var contactConsultantHenallux in contactProfessionalConsultantEntrep1)
                {
                    System.Console.WriteLine(contactConsultantHenallux);
                }

                System.Console.WriteLine("Fin des Contacts Professionel consultant a Henallux\r\n");
            }

            System.Console.Read();
        }
    }
}
