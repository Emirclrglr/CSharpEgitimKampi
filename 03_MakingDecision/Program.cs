﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfe Şifreyi Giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, avg;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avg = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + avg);

            //if (avg > 0 & avg <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (avg > 50 & avg <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (avg > 70 & avg <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (avg > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;

            //Console.WriteLine("1. Sayının 2. Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int num = int.Parse(Console.ReadLine());    

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek");
            //}
            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Fasülye Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - Ezogelin Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margaritha");
            //    Console.WriteLine("3 - Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Trileçe");
            //    Console.WriteLine("2 - Kazandibi");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;

            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;

            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;

            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;

            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;

            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;

            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;

            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;

            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;

            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;

            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;

            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;

            //    default:
            //        Console.WriteLine("Geçerli bir ay girmediniz");
            //        break;


            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int num1, num2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz. ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz. ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion


            Console.Read();
        }
    }
}