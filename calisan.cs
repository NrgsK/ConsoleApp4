using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class calisan
    {
        private int id;
        private string name;
        private string lastname;

        public calisan(int id, string name , string lastname)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
        }

        public int  getId()
        {
            return this.id;
        }

        public void setID()
        {
            this.id = id;        
        }

        public string getname()
        {
            return this.name;
        }

        public void setname(string name) 
        {
            this.name=name;
        }

        public string getLastname()
        {
            return this.lastname;
        }

        public void setlastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void bilgilerigoster()
        {
            Console.WriteLine("İD :" + this.id);
            Console.WriteLine("NAME : " + this.name);
            Console.WriteLine("LAST NAME : " + this.lastname);

        }


    }
}
