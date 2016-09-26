using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Environ_Dev_Logiciels
{
    public abstract class Person
    {
        private String name;
        private String lastName;
        public String Name { get; set; }
        public String LastName { get; set; }

        public Person(String name, String lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override String ToString()
        {
            return "Son prenom est : " + Name + "\r\nSon nom est : " + LastName;
        }

        public abstract bool HasHisBirthday();
    }
}
