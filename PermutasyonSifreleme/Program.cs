using System;
using System.Collections.Generic;
namespace PermutasyonSifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            string kelime;
            Console.WriteLine("Lütfen bir kelime giriniz");
            kelime = Console.ReadLine();
            kelime = kelime.ToUpper();
            int sayi = 7;          
            char[] kelimeler = kelime.ToCharArray();
            Random rnd = new Random();
            int[] karisiklar = { 2, 7, 5, 1,6, 4, 3 };
           
            List<char> dogrukarakterler = new List<char>();
            int deger = 0;
            foreach (var y in kelimeler)
            {
                foreach (var x in alfabe)
                {
                    if (x == y)
                    {
                        dogrukarakterler.Add(x);
                    }
                }
            }
            int kelimeuzunlugu = dogrukarakterler.Count;
            int kacabolunecek = kelimeuzunlugu / sayi;
            if (kelimeuzunlugu % sayi != 0)
            {
                for (int i = 0; i < (sayi - (kelimeuzunlugu % sayi)); i++)
                {
                    dogrukarakterler.Add('A');
                }
                kacabolunecek = kacabolunecek + 1;
            }
            List<char> sifreleme = new List<char>();
            for (int i = 0; i < kacabolunecek; i++)
            {
                for (int y = 0; y < sayi; y++)
                {
                    sifreleme.Add(dogrukarakterler[deger]);
                    deger = deger + 1;
                }
            }
           
            int selaminko = 0;
            char[] soncuk;
            soncuk = new char[dogrukarakterler.Count];
            int olay;
            int ekleme = 0;
            for (int i = 0; i < kacabolunecek; i++)
            {
                for (int z = 0; z < sayi; z++)
                {
                    olay = ekleme + karisiklar[z]-1;
                    soncuk[selaminko] = dogrukarakterler[olay];
                    selaminko = selaminko + 1;
                }
                ekleme = ekleme + sayi;
            }
            Console.Write("Permutasyon algoritamasına göre şifrelenmiş hali = ");
            foreach (var deneme in soncuk)
            {
                Console.Write(deneme);
            }
            Console.WriteLine("");
            char[] cozmekicin;
            int olaycozme = 0;
            cozmekicin = new char[soncuk.Length];
            int yardim = 0;
            int ekleme2 = 0;
            for (int i = 0; i < kacabolunecek; i++)
            {
                for (int z = 0; z < sayi; z++)
                {
                    olaycozme = ekleme2 + karisiklar[z]-1;
                    cozmekicin[olaycozme] = soncuk[yardim];
                    yardim = yardim + 1;
                }
                ekleme2 = ekleme2 + sayi;
            }
            Console.Write("Çözülmüş Hali = ");
            foreach (var x in cozmekicin)
            {
                Console.Write(x);
            }

        }
    }
}