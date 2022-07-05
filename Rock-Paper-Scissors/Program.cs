using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1.Kullanıcıya seçmek istediği tercihi sorduk ([r]ock - [p]aper - [s]cissors)
            *  2.Seçimi kontrol ediniz
            *  3.Random oluşturunuz
            *      random = 0 => bilgisayar seçeneği taş
            *      random = 1 => bilgisayar seçeneği kağıt
            *      random = 2 => bilgisayar seçeneği makas
            *  4.Kazananı yazdırınız
            *  5.Tekrar oynamak ister misiniz sorusunu sorun
            *  6.Skor tutunuz
            *  7.Oyun sürdükçe skoru güncelleyiniz
            */

            Console.WriteLine("TAŞ - KAĞIT - MAKAS OYUNU");

            int skorUser = 0;
            int skorPC = 0;
            int oynananEl = 0;

        basla:
            Console.WriteLine("Taş için [R],  kağıt içim [P],  makas için [S] seçiminizi yazıp ENTER' a basarak yapınız");
            string secimX = Console.ReadLine();
            char secimChr = ' ';

            while (secimX != "R" && secimX != "P" && secimX != "S")
            {
                Console.WriteLine("Tekrar Taş için [R],  kağıt içim [P],  makas için [S] seçiminizi yazıp ENTER' a basarak yapınız");
                secimX = Console.ReadLine();
            }

            secimChr = Convert.ToChar(secimX);

            Random rnd = new Random();

            int secimPC = rnd.Next(0, 3);

            if (secimChr == 'R' && secimPC == 2 || secimChr == 'P' && secimPC == 0 || secimChr == 'S' && secimPC == 1)
            {
                Console.WriteLine("Tebrikler, kazandınız");
                skorUser++;
                oynananEl++;
            }
            else if (secimChr == 'R' && secimPC == 0 || secimChr == 'P' && secimPC == 1 || secimChr == 'S' && secimPC == 2)
            {
                Console.WriteLine("Berabere kaldınız");
                oynananEl++;
            }
            else
            {
                Console.WriteLine("Malesef, kaybettiniz");
                skorPC++;
                oynananEl++;
            }

            Console.WriteLine("Oynanan el: " + oynananEl);
            Console.WriteLine("Kazanılan el: " + skorUser);
            Console.WriteLine("Kaybetilen el: " + skorPC);

            Console.WriteLine("Tekrar oynamak ister misiniz? E / H");
            if (Console.ReadLine() == "E")
            {
                goto basla;
            }
            Console.WriteLine("Oyun Bitti");
            Console.Read();
        }
    }
}
