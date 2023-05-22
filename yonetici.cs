using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class yonetici : calisan
    {
        private int sorumluKisiSayisi;

        public yonetici (int id , string name , string lastname , int intsorumluKisiSayisi) : base(id , name , lastname)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamyap(int zamMiktar)
        {
            Console.WriteLine(getname() + " " + zamMiktar + " " + "TL çalışanlara zam yapıyor...");

        }

    }
}
