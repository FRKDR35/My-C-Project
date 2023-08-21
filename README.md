# My-C-Project
This is a C# project of my own making. It contains a calculator, a personal information pool, a percentage calculator, and a conscription age calculator for Turkey. In the future, my goal is to connect the personal pool within this project to an online database. This is my first project!
Here are the source codes of my first project, written using C#:



using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {            
            string ad,  kim, ism, yism;
            long  tlno;
            int dyil, yas, sec, sayi1, sayi2, sonuc;
            char islem;    
            for (; ; )
            {               
                Console.Title = "Anasayfa";
                Console.WriteLine("1-Yüzdelik Bulma");
                Console.WriteLine("2-Askerlik Durumu");
                Console.WriteLine("3-Hesap Makinesi");
                Console.WriteLine("4-Kişi Bilgileri");
                Console.WriteLine("0-PROGRAMI KAPATIR");
                Console.WriteLine("Seçiminiz");
                sec = Convert.ToInt32(Console.ReadLine());
                Console.Clear();               
                if (sec == 1612)
                {
                    sec = 5;
                }          
                switch (sec)              
                {
           case 1:
                        {
                            Console.Title = "Yüzdelik Bulma, Çıkmak için 0000 yazınız!";
                            Console.WriteLine("sayıyı giriniz");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (sayi1 == 0000)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("yüzdeliği giriniz");
                            sayi2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            {
                                sonuc = (sayi1 / 100) * sayi2;
                                Console.WriteLine("{0}", sonuc);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
           case 3:
                        {
                        Console.Title = "Hesap Makinesi  Çıkmak için 0000 yazınız!";
                        Console.WriteLine("İlk sayıyı giriniz");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                            if (sayi1 == 0000)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        Console.WriteLine("İkinci sayıyı giriniz");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Yapmak istediğiniz işlemi yazınız (+,-.*./), işleminiz ortalama ise '.' koyunuz.");
                        islem = Convert.ToChar(Console.ReadLine());
                            Console.Clear();                           
                        if (islem == '.')
                        {
                                Console.Title = "Ortalama Bulma";
                            sonuc = (sayi1 + sayi2) / 2;
                            Console.WriteLine("{0}  {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        else if (islem == '+')
                        {
                                Console.Title = "Toplama";
                            sonuc = sayi1 + sayi2;
                            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        else if (islem == '-')
                        {
                                Console.Title = "Çıkarma";
                                sonuc = sayi1 - sayi2;
                            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        else if (islem == '*')
                        {
                                Console.Title = "Çarpma";
                                sonuc = sayi1 * sayi2;
                            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        else if (islem == '/')
                        {
                                Console.Title = "Bölme";
                                sonuc = sayi1 / sayi2;
                            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc);
                        }
                        else
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }                     
                    case 2:
                    {
                        Console.WriteLine("Askerlik Yaşı Hesaplama");
                        ad = Console.ReadLine();
                            if (ad == "")
                            {
                                Console.Clear();
                                break;
                            }
                        Console.WriteLine("Doğum yılını gir");
                        dyil = Convert.ToInt16(Console.ReadLine());
                        yas = 2022 - dyil;
                        if (yas >= 20) Console.WriteLine("{0} sen Askere gidebiirsin.", ad);
                        else
                            Console.WriteLine("{0} senin yaşın tutmuyor.", ad);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    case 5:
                        {
                            Console.Clear();
                            string asec;
                            string sil;
                            Console.Title = "ADMİN PANELİ";
                            Console.WriteLine("Merhaba Omerfrkder!");
                            Console.WriteLine("1-Kişi Silme");
                            Console.WriteLine("2-Kişi Düzenleme");
                            Console.WriteLine("3-Kayıtlı Kişileri görme");
                            Console.WriteLine("4-Anasayfaya dön");
                            asec = Console.ReadLine();
                            Console.Clear();
                            if (asec == "1")
                            {
                                Console.WriteLine("Silmek istediğiniz kişinin ismini giriniz!");
                                sil = Console.ReadLine();
                                string bsil = sil.ToUpper();
                                string sdosya =  bsil;
                                System.IO.File.Delete("DataBase\\" + sdosya);
                                Console.WriteLine("Kişi Silme Başarılı");
                                Console.Clear();

                            }

                            else if (asec == "2")
                            {                                
                                Console.WriteLine("Düzenlemek istediğiniz kişinin ismini giriniz");
                                string duz= Console.ReadLine();
                                string bduz = duz.ToUpper();
                                Console.Clear();
                                FileStream fsf = new FileStream(bduz, FileMode.Open, FileAccess.ReadWrite);
                                Console.Clear();
                                Console.WriteLine("Lütfen düzenlemek istediğin kişinin ismini ve soyismini yaz");
                                ism = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Telefon numarasını gir");
                                tlno = Convert.ToInt64(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Mesleğini söyle");
                                kim = Console.ReadLine();
                                Console.Clear();
                                string bbism = ism.ToUpper();
                                StreamWriter sww = new StreamWriter(fsf);
                                sww.WriteLine(bbism);
                                sww.WriteLine("Telefon Numarası: {0} ", tlno);
                                sww.WriteLine("Mesleği: {0} ", kim);
                                Console.WriteLine("Kişi düzenleme başarılı!!");
                                Console.Clear();
                                sww.Close();
                                fsf.Close();
                            }
                            else if (asec == "3")
                            {
                                Console.Clear();
                                List<string> dosyaIsimleri = Directory.GetFiles(@"DataBase\\").Select(Path.GetFileName).ToList();

                                foreach (string dosya in dosyaIsimleri)
                                {
                                    Console.WriteLine(dosya);
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }                           
                            break;
                        }
                    case 4:
                        {                           
                            string yazi;                                                                                                         
                            Console.WriteLine("Kişinin İsmi ve Soyismini giriniz.");
                            ad = Console.ReadLine();
                            if (ad == "")
                            {
                                Console.Clear();
                                break;
                            }
                            string dosyaadi = "DataBase\\" + ad;
                            string bad = ad.ToLower();                          
                            string dataBasePath = "DataBase";
                            Directory.CreateDirectory(dataBasePath);
                            File.SetAttributes(dataBasePath, File.GetAttributes(dataBasePath) & ~FileAttributes.Hidden);
                            if (File.Exists (dosyaadi)){
                               StreamReader sr = new StreamReader("DataBase\\" + ad, Encoding.UTF8);
                               yazi = sr.ReadLine();                               
                                Console.Clear();
                                Console.Title = bad;
                                while (yazi != null)
                                       {
                                        Console.Title = bad;
                                       Console.WriteLine(yazi);
                                       yazi = sr.ReadLine();                                   
                                      }
                                sr.Close();
                                Console.ReadKey();
                                Directory.CreateDirectory(dataBasePath);
                                File.SetAttributes(dataBasePath, File.GetAttributes(dataBasePath) | FileAttributes.Hidden);
                                Console.Clear();
                            }
                            else                                                                                       
                            if (bad == ("ömer faruk der"))
                            {
                                Console.Clear ();
                                Console.WriteLine("Yapımcı");
                                Console.WriteLine("Telefon Numarası: 0530 296 24 04");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else if (bad == ("serkan öner"))
                            {
                                Console.Clear ();
                                Console.Title = "Serkan Öner";
                                Console.WriteLine("Yapımcının Öğretmeni");
                                Console.WriteLine("Telefon Numarası: 0506 304 80 50");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }                                                 
                            else 
                            {                               
                                Console.Clear();                                                             
                                Console.WriteLine("Sen sistemde yoksun eklememi ister misin?");
                                Console.WriteLine("İstiyorsan 'E' istemiyorsan 'H' yaz");
                                yism = Console.ReadLine();
                                string yyism = yism.ToUpper();
                                if (yyism == "E") 
                                {
                                    Directory.CreateDirectory(dataBasePath);
                                    File.SetAttributes(dataBasePath, File.GetAttributes(dataBasePath) & ~FileAttributes.Hidden);
                                    Console.Clear();
                                    Console.WriteLine("Lütfen ismini ve soyismini yaz");
                                    ism = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Telefon numaranı gir");
                                    tlno = Convert.ToInt64(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Mesleğini söyle");
                                    kim = Console.ReadLine();
                                    Console.Clear();
                                    string bism = ism.ToLower();                                  
                                    FileStream fs = new FileStream(bism, FileMode.OpenOrCreate, FileAccess.ReadWrite);                                  
                                    Console.WriteLine("KİŞİ BİLGİLERİ EKLEME BAŞARILI!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);                                   
                                    sw.WriteLine (bism);
                                    sw.WriteLine("Telefon Numarası: {0} ", tlno);                                  
                                    sw.WriteLine("Mesleği: {0} ", kim);                                  
                                    sw.Close();                                   
                                    fs.Close();
                                    File.Move(bism, Path.Combine(@"DataBase", bism));
                                    Directory.CreateDirectory(dataBasePath); // Klasörü oluşturur (varsa geçerli klasörü kullanır)
                                    File.SetAttributes(dataBasePath, File.GetAttributes(dataBasePath) | FileAttributes.Hidden);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Peki");
                                    Console.ReadKey();
                                    Console.Clear();                                   
                                }                                                             
                            }
                            Directory.CreateDirectory(dataBasePath);
                            File.SetAttributes(dataBasePath, File.GetAttributes(dataBasePath) | FileAttributes.Hidden);
                            break;
                        }                       
                    }
                }
            }
        }
    }


