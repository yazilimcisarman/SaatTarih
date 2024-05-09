using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaatTarih
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;

            Console.WriteLine(tarih);
            //Sadece Tarih
            Console.WriteLine(tarih.ToShortDateString());
            //Sadece saat
            Console.WriteLine(tarih.ToShortTimeString());
            //SAdece Yıl
            Console.WriteLine("Yıl: " +tarih.Year);
            //Sadece Ay
            Console.WriteLine("Ay: " + tarih.Month);
            //SAdece Gün
            Console.WriteLine("Gün: " + tarih.Day);
            //Sadece Saat
            Console.WriteLine("Saat: " + tarih.Hour);
            //Sadece Dakika 
            Console.WriteLine("Dakika: " + tarih.Second);
            //Sadece Saniye 
            Console.WriteLine("Saniye: " + tarih.Second);

            //
            Console.WriteLine(tarih.Day + "." + tarih.Month+"."+tarih.Year);

            Console.ReadLine();
        }
    }
}
