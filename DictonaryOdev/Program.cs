using System;
using System.Collections.Generic;

namespace DictonaryOdev
{
    class MyDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Takım = new Dictionary<int, string>();
            Takım.Add(1903, "BEŞİKTAŞ");
            Takım.Add(1905, "galatasaray");
            Takım.Add(1907, "fenerbahçe");
            Takım.Add(1963, "bursaspor");
            Takım.Add(1925, "göztepe");
            Takım.Add(1966, "trabzonspor");
            Takım.Add(1967, "KOCAELİSPOR");
            Takım.Add(1923, "gençlerbirliği");
            Takım.Add(1986, "malatyaspor");
            Console.Write("Takımınızın Kuruluş Yılını Giriniz:");
            int Yılı = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Takım[Yılı]);
            }
            catch
            {
                Console.WriteLine("Bu yıla ait takım bilgisi bulunamadı.");
            }
        }
    }
}
