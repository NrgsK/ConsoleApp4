using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class yazilimci : calisan
    {

        public string diller;
        public yazilimci(int id , string name , string lastname) : base(id,name,lastname) 
        {
             this.diller = diller;
        }
        public void formatAt(string isletim_sistemi) 
        {
            Console.WriteLine(getname() + "suanda" + " " + isletim_sistemi + "İşletim sistemine format atıyor...");
        }

    }
}
