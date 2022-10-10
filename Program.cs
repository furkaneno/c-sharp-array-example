using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_array_ornekk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mevcut = 0;

            Console.Write("Sınıf mevcudunu Girin : ");

            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] ogrenciisim = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write(" Öğrenci Adını Girin : ");
                ogrenciisim[i] = Console.ReadLine();
            }

            string[] ogrencinumara = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write(" Öğrenci numara Girin : ");
                ogrencinumara[i] = Console.ReadLine();
            }

            string[] ogrencimail = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write(" Öğrenci mail Girin : ");
                ogrencimail[i] = Console.ReadLine();
            }

            Console.WriteLine("aranan kisi no yu girin");

            string aranan = Console.ReadLine();

            int no  = Array.IndexOf(ogrencinumara, aranan.ToString());

            Console.WriteLine(" Aranan Kişi : {0}\n numarasi: {1}\n E-mail: {2}", ogrenciisim[no], ogrencinumara[no], ogrencimail[no]);
            

            Console.ReadKey();

        }
    }
}
