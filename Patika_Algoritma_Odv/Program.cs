using System;
using System.Linq;

namespace Patika_Algoritma_Odv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            /*Console.WriteLine("Kaç sayı girmek istersiniz: ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz ");

            }
            int[] sayilar = new int[n];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out sayilar[i]) || sayilar[i] <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                    Console.WriteLine($"{i + 1}. sayıyı giriniz: ");
                }
            }
            Console.WriteLine("Cift sayilar: ");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            } */

            /* Soru2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            int n = 0, m = 0;
            while(n<=0 || m <= 0)
            {
                Console.WriteLine("Lütfen pozitif iki sayı giriniz n,m :");
                int.TryParse(Console.ReadLine(), out n);
                int.TryParse(Console.ReadLine(), out m);
                if (n<=0 || m<=0)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen tekrar deneyin.");
                }
            }
            int[] sayilar = new int[n];
            for(int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{i + 1}. sayıyı giriniz: ");
                    if(int.TryParse(Console.ReadLine(), out sayilar[i]) && sayilar[i] > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Geçersiz giriş! Lütfen tekrar deneyin. ");
                }
            }
            Console.WriteLine($"Girilen sayılardan {m}'e tam bölünen veya eşit olanlar: ");
            foreach(int sayi in sayilar)
            {
                if(sayi %m == 0)
                {
                    Console.WriteLine(sayi);
                }
                else
                {
                    Console.WriteLine("Hiçbir sayı bölünmedi. ");
                    break;
                }
            }
            Console.ReadKey(); */

            // Soru3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            /*Console.WriteLine("Lütfen bir sayı giriniz: ");
            int n = 0;
            while (n <= 0)
            {
                int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı giriniz: ");
                }
            }
            string[] kelimeler = new string[n];
            for(int i=0; i < n; i++)
            {
                string kelime = "";
                while(string.IsNullOrWhiteSpace(kelime) || kelime.Any(char.IsDigit))
                {
                    Console.WriteLine($"{i + 1}. kelimeyi giriniz: ");
                    kelime = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(kelime))
                    {
                        Console.WriteLine("Geçersiz giriş lütfen tekrar deneyin. ");
                    }
                    else if (kelime.Any(char.IsDigit))
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen sadece harf giriniz. ");
                    }
                }
                kelimeler[i] = kelime;
            }
            Console.WriteLine("Girilen kelimeler sondan başa doğru: ");
            for(int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.ReadKey(); */
            //Soru4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
           /*Console.WriteLine("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            int kelimeSayisi = cumle.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            string kucukHarfler = cumle.ToLower();
            string sadeceHarfler = string.Concat(kucukHarfler.Where(char.IsLetter));
            int harfSayisi = sadeceHarfler.Length;
            Console.WriteLine($"Cümlede toplam {kelimeSayisi} kelime ve {harfSayisi} harf bulunmaktadır.");*/
        }
    }
    }

