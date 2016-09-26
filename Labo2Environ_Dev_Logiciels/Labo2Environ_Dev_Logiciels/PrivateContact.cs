using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2Environ_Dev_Logiciels
{
    class PrivateContact : Person
    {
        private int telPrivate;

        public int TelPrivate
        { get; set; }
        private String adrMailPrivate;

        public String AdrMailPrivate
        {get;set;}

        private DateTime birthday;

        public DateTime Birthday
        {get;set;}
        
        public PrivateContact(String name, String lastName, int telPrivate, String adrMailPrivate, DateTime birthday) : base(name,lastName)
        {
            TelPrivate = telPrivate;
            AdrMailPrivate = adrMailPrivate;
            Birthday = birthday;
        }

        public PrivateContact(String name, String lastName,int telPrivate, String adrMailPrivate)  : base(name,lastName)
        {
            TelPrivate = telPrivate;
            AdrMailPrivate = adrMailPrivate;
        }

        public override string ToString()
        {
            String ch = base.ToString() + "(" + TelPrivate + ")" + "\r\n" + AdrMailPrivate + "\r\n";
            ch += (HasHisBirthday()) ? "Bon anniversaire\r\n" : " \r\n";
            return ch;
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == Birthday.Month && DateTime.Today.Day == Birthday.Day);
        }
    }
}
