using System;
using System.Collections.Generic;
using System.Text;

namespace Stringler_katarlar_desen_uygulamasi_
{
    class Katarlar
    {
    /// <summary>
    /// Desen oluşturucu1
    /// </summary>
    /// <param name="c">Karakter tanımı</param>
    /// <param name="n">Tekrar sayısı</param>
        public static void Desen1(char c='*', int n= 5)   // void olursa return değimi kullanmaya gerek yok.
        {
            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i)); // char ifadesi '' tek tırnaklı çift tırnak içine yazılır.
            }
        }
        /// <summary>
        /// Desen oluşturucu2
        /// </summary>
        /// <param name="c">Karakter</param>
        /// <param name="n">Döngü sayısını</param>
        public static void Desen2(char c='-', int n=4)
        {
            for (int i = n; i >= 0 ; i--)
                Console.WriteLine("{0}", new string(c, i));

            
        }

        public static void KarakterSeti(int baslangicIndisi=65, int bitisIndisi=90, int satirKarakterSayisi=5)
        {
            for (int i = baslangicIndisi; i <= bitisIndisi; i++)         // 32 den başlayıp 126ya kadar gitmeyi ifade ediyor. bu aralıkta klavyediki tüm karakterleri yazar.
            {
                Console.Write("{0,5}", (char)i);    //write yan yana yazdırır.  {0,5} rakalar arası boşluk
                if (i % satirKarakterSayisi == 0) 
                Console.WriteLine(); //5 Karakterde bir aşağıya satırı geçir.
            }
        }

    }
}
