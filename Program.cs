using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KitaplikProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string secim;
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi     **  Yabancı Kitaplar Kategorisi         **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri         **  7-Tuna Kolavuzu: Jules Verne        **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri           **  8-Bir Kuzey Macerası: Jack London   **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip  **  9-Altıncı Koğuş: Arton Çehov        **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O. Atay   **  10-Kumarbaz: Dostoyevski            **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: H. Yücel **  11-İki Şehrin Hikayesi: C. Dickens  **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S. Ali      **  12-Vişne Bahçesi: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5- Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlem numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if(islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istedğiniz kitabın numarasını giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Çalıkuşu: 12 TL"); break;
                    case "2": Console.WriteLine("Yaban: 14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar: 11 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden: 8 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf: 13 TL"); break;
                    case "7": Console.WriteLine("Tuna Kılavuzu: 17 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 15 TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş: 8 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10 TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi: 19 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi: 18 TL"); break;
                    default: Console.WriteLine("Hatalı sayı girdiniz, numarayı kontrol ediniz"); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversite: ");
                universite = Console.ReadLine();

                string dosya = @"C:\Users\Yaren\Desktop\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyad:" + soyad);
                sw.WriteLine("Üniversite: " + universite);
                sw.Close();

            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();

            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Yaren\Desktop\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while(metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                //burası kitap arşivi olacak
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
            }
            if (islem == '5')
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Alacağınız kitabın numarası: ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamFiyat = toplamFiyat + 12;
                    }
                    else if (secim == "2")
                    {
                        toplamFiyat = toplamFiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamFiyat = toplamFiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamFiyat = toplamFiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamFiyat = toplamFiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamFiyat = toplamFiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamFiyat = toplamFiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplamFiyat = toplamFiyat + 15;
                    }
                    else if (secim == "9")
                    {
                        toplamFiyat = toplamFiyat + 8;
                    }
                    else if (secim == "10")
                    {
                        toplamFiyat = toplamFiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplamFiyat = toplamFiyat + 19;
                    }
                    else if (secim == "12")
                    {
                        toplamFiyat = toplamFiyat + 18;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak ister misiniz: ");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                            break;                                      
                }
                Console.WriteLine("Toplam tutar: " + toplamFiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while(sayi != tahmin)
                {
                    Console.Write("Sayı giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha küçük ");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha büyük ");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Sayıyı bildiniz");
                        break;
                    }
                       
                }

            }
            Console.Read();
        }
    }
}
