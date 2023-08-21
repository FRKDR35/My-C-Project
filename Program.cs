using System;
using System.Collections.Generic;
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
            
            string ad, isl, kim, ism, yism, ytxt;
            long  tlno;
            int dyil, yas, adet, sec, sayi1, sayi2, sonuc, yenis;
            char islem;
            char secim;
            //string dosya = @"deneme.txt";
            string v;

            char[] q;
          
            

            string   c, d, e, f, g, h, ı, i, j, k, l;
            long m, n, o, ö, p, r, s, ş, t, u, ü;


           // FileStream fs = new FileStream("deneme.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
          //  StreamReader sr = new StreamReader(fs);


          //  char[] b = new char[255];
           // sr.ReadBlock(b, 0, 20);
          //  v = Convert.ToString(b);
         //   fs.Close();
            for (; ; )

            {
                
               


                



                Console.WriteLine("1-Hesap Makinesi");
                Console.WriteLine("2-Askerlik Durumu");
                Console.WriteLine("3-Yüzdelik Bulma");
                Console.WriteLine("4-Kişi Bilgileri");
                Console.WriteLine("0-PROGRAMI KAPATIR");
                Console.WriteLine("Seçiminiz");
                sec = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
               




                switch (sec)
                    { 


           case 1:
                        {
                            Console.WriteLine("sayıyı giriniz");
                            sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
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
                        Console.WriteLine("İlk sayıyı giriniz");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("İkinci sayıyı giriniz");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Yapmak istediğiniz işlemi yazınız (+,-.*./), işleminiz ortalama ise '.' koyunuz.");
                        islem = Convert.ToChar(Console.ReadLine());
                            Console.Clear();

                        if (islem == '.')
                        {
                            
                            sonuc = (sayi1 + sayi2) / 2;
                            Console.WriteLine("{0}  {1} = {2}", sayi1, sayi2, sonuc);
                        }






                        else if (islem == '+')
                        {
                            sonuc = sayi1 + sayi2;
                            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, sonuc);

                        }
                        else if (islem == '-')
                        {
                            sonuc = sayi1 - sayi2;
                            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, sonuc);

                        }





                        else if (islem == '*')
                        {
                            sonuc = sayi1 * sayi2;
                            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sonuc);

                        }

                        else if (islem == '/')

                        {

                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc);

                        }
                            Console.ReadKey();
                            Console.Clear();

                            break;

                    }

                    case 2:
                    {




                        Console.WriteLine("isim yaz kim olduğunu bulalım");
                        ad = Console.ReadLine();
                        Console.WriteLine("Doğum yılını gir");
                        dyil = Convert.ToInt16(Console.ReadLine());
                        yas = 2022 - dyil;
                        if (yas >= 20) Console.WriteLine("{0} sen Askere gidebiirsin", ad);
                        else
                            Console.WriteLine("{0} senin yaşın tutmuyor.NAŞŞŞŞŞ", ad);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                    case 4:
                        {
                            string yytxt;

                            string dosya = @"deneme.txt";
                            FileStream ffs = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            StreamReader sr = new StreamReader(ffs);
                            string yazi = sr.ReadLine();




                            Console.WriteLine("Kişinin İsmi ve Soyismini giriniz.");
                            ad = Console.ReadLine();

                            if (ad == ("ömer faruk der"))
                            {
                                Console.WriteLine("Yapımcı");
                                Console.WriteLine("Telefon Numarası: 0530 296 24 04");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (ad == ("serkan öner"))
                            {
                                Console.WriteLine("yardımcı yapımcı");
                                Console.WriteLine("Telefon Numarası: 0506 304 80 50");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (ad == ("kadir can tepret"))
                            {
                                Console.WriteLine("Geleceğin Torbacısı");
                                Console.WriteLine("Telefon Numarası: 0545 633 35 35");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (ad == ("berke demirbaş"))
                            {
                                Console.WriteLine("okul numaranı gir");

                                Console.WriteLine("Telefon Numarası: 0551 432 18 44");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            else if (ad == yazi) 

                            {
                                Console.Clear();

                                while (yazi != null)
                                {
                                    Console.WriteLine(yazi);
                                    yazi = Convert.ToString (sr.ReadLine());
                                }

                               // Console.WriteLine(yazi);
                               Console.ReadKey();
                                sr.Close();
                                ffs.Close();
                                Console.ReadKey();
                                Console.Clear ();
                               
                            }
                            
                            

                            else

                            {
                               

                                Console.Clear();
                             
                                
                                Console.WriteLine("Sen sistemde yoksun eklememi ister misin?");
                                Console.WriteLine("İstiyorsan 'E' istemiyorsan 'H' yaz");
                                yism = Console.ReadLine();
                               
                                if (yism == "E") 
                                {
                                      


                                    sr.Close();
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
                                    FileStream fs = new FileStream(dosya, FileMode.OpenOrCreate, FileAccess.ReadWrite) ;
                                    Console.WriteLine("KİŞİ BİLGİLERİ EKLEME BAŞARILI!");
                                    Console.ReadKey();
                                    Console.Clear();



                                    sr.Close();
                                    StreamWriter sw = new StreamWriter(fs);
                                    sw.WriteLine (ism);
                                    sw.WriteLine("Telefon Numarası: {0} ", tlno);
                                   // sw.WriteLine("Mesleği: {0}", kim);
                                    sw.WriteLine("Mesleği: {0} ", kim);
                                    sw.Close();
                                    ffs.Close();
                                    fs.Close();
                                }

                                else
                                {
                                    Console.WriteLine("Peki");
                                    Console.ReadKey();
                                    Console.Clear();
                                   

                                }
                                


                               

                            }
                            
                            
                            
                            
                            
                            break;
                        }





                    //Console.ReadKey();
                    //Console.Clear();
                    

                    }


                }


            }
        }
    }


