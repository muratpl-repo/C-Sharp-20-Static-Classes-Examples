using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61DersSikliklaKullanilanStaticSiniflar // NOT: STATIC SINIFTAKI HER SEY STATIC OLMAK ZORUNDADIR...
{                                               // Ancak static olmayan siniflarda static objeler veya metotlar kullanılabilir.
    class Program                               // Genelde static siniflar degisiklik gerekmeyen sabit matematiksel kullanimlar icin uygundur...
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 3, 1, -5, 3, 4, 5, 6, 12, 7 };
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Tersten yazdiriliyor...");

            Array.Reverse(sayilar); //Arraydeki ifadeleri tersten yazar...
            Array.Sort(sayilar); //Arraydeki ifadeleri kucukten buyuge gore siralar...
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
