using System;

namespace Stringler_katarlar_desen_uygulamasi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Katarlar.Desen1();
            Katarlar.Desen1('!');
            Katarlar.Desen1('?', 10); // ('hangi desen', kaç kere)

            Katarlar.Desen2();
            Katarlar.Desen2('!');
            Katarlar.Desen2('?', 10); // ('hangi desen', kaç kere)

            Katarlar.KarakterSeti();
            Katarlar.KarakterSeti(128, 255);
            Katarlar.KarakterSeti(128, 255,10);


        }
    }
}
