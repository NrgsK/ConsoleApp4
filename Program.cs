using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Çalışan uygulamasına hoş geldiniz....");
            Console.WriteLine("1-Yazılımcı işlemleri..");
            Console.WriteLine("2-Yönetici işlemleri..");
            Console.WriteLine("3-Çıkış için Q ya basın...");

            string secilenislem=Console.ReadLine();

            while (true)
            {
                if (secilenislem == "q")
                {
                    Console.WriteLine("Programdan cıkış...");
                    break;
                }
                else if (secilenislem == "1")
                {
                    yazilimci yazilimci=new yazilimci(1,"ACAR","BABA");
                    Console.WriteLine("Yazilimci İşlemi Seçimiz...");
                    Console.WriteLine("1-Format At");
                    Console.WriteLine("2-Yazılımcının Bilgilerini Göster...");
                }
            }



            



        }
    }
}
