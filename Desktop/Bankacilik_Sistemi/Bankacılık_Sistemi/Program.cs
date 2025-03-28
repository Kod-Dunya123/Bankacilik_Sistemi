using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mobil uygulamamıza giriş yaptınız lütfen önce kaydolun");
            Console.WriteLine("lütfen isminizi girin");
            string isim1 = Console.ReadLine();
            Console.WriteLine("lütfen soyisminizi girin");
            string soyisim = Console.ReadLine();
            Console.WriteLine(isim1 + soyisim + "bey lütfen doğum tarihinizi girin");
            int gun = Convert.ToInt32(Console.ReadLine());
            int ay = Convert.ToInt32(Console.ReadLine());
            int yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{gun}/{ay}/{yil}");
            Console.WriteLine(isim1+ " bey lütfen parolanız oluşturun");
            string ilkparola = Console.ReadLine();
            int toppara = 20000000;
            string parola = ilkparola;
            Console.WriteLine(isim1+ " bey lütfen şifreyi tekrar girin");
            string sifregir = Console.ReadLine();
            int girishakki = 3;
            int işlem;
            int para;
            int fatura;
            int çekpara;
            int kalanpara;
            bool çikis = true;
            while (çikis && girishakki > 0)
            {
                if (sifregir == parola)
                {
 
                    Console.WriteLine("sayın "+ isim1+ " hoşgeldiniz lütfen yapmak istediğiniz işlemin karşılığına gelen sayıyı tuşlayın");
                    Console.WriteLine("para çekmek için 1 i");
                    Console.WriteLine("parayatırmak için 2 yi");
                    Console.WriteLine("havale etmek için 3 ü");
                    Console.WriteLine("para transveri için 4 ü ");
                    Console.WriteLine("fatura ödemeleri için 5 i tulayın");
                    Console.WriteLine("uygulamadan çıkmak istiyrosanız 6 yı tuşlayn");
                    Console.WriteLine("lütfen yapacağınız işleme göre tuş takımını kullanın");
                    işlem = Convert.ToInt32(Console.ReadLine());
                    switch (işlem)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Yükleme animasyonu başlıyor...");
                                for (int i = 0; i <= 20; i++)
                                {
                                    Console.SetCursorPosition(0, 1); 
                                    Console.Write("[");
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write("#"); 
                                    }
                                    Console.Write(new string(' ', 20 - i));
                                    Console.Write("]");
                                    Console.WriteLine($" {i * 5}%");
                                    Thread.Sleep(200);  
                                    if (i == 20)
                                    {
                                        for (int k = i; k >= 0; k--)
                                        {
                                            Console.SetCursorPosition(0, 1);
                                            Console.Write("[");
                                            for (int j = 0; j < k; j++)
                                            {
                                                Console.Write("#");
                                            }

                                            Console.Write(new string(' ', 20 - k));
                                            Console.Write("]");
                                            Console.WriteLine($" {k * 5}%");
                                            Thread.Sleep(100);
                                        }
                                    }
                                }                                
                                Console.SetCursorPosition(0, 1);
                                Console.WriteLine("[####################] 100% Yükleme Tamamlandı!");
                                Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                Console.WriteLine("lütfen nekadar para çekeceğinizi girin");
                                çekpara = Convert.ToInt32(Console.ReadLine());
                                if (çekpara > toppara)
                                {
                                    Console.WriteLine("bakiyeniz yetersiz");
                                }
                                else
                                {
                                    kalanpara = toppara - çekpara;
                                    Console.WriteLine("hesabınızdan " + çekpara + " tl çektiniz kalan paranız " + kalanpara);
                                }
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Yükleme animasyonu başlıyor...");
                                for (int i = 0; i <= 20; i++)
                                {
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write("[");
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write("#");
                                    }
                                    Console.Write(new string(' ', 20 - i));
                                    Console.Write("]");
                                    Console.WriteLine($" {i * 5}%");
                                    Thread.Sleep(200);
                                    if (i == 20)
                                    {
                                        for (int k = i; k >= 0; k--)
                                        {
                                            Console.SetCursorPosition(0, 1);
                                            Console.Write("[");
                                            for (int j = 0; j < k; j++)
                                            {
                                                Console.Write("#");
                                            }

                                            Console.Write(new string(' ', 20 - k));
                                            Console.Write("]");
                                            Console.WriteLine($" {k * 5}%");
                                            Thread.Sleep(100);
                                        }
                                    }
                                }
                                Console.SetCursorPosition(0, 1);
                                Console.WriteLine("[####################] 100% Yükleme Tamamlandı!");
                                Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                Console.WriteLine("ne kadar yatırmak istediğiniz miktarı girin");
                                para = Convert.ToInt32(Console.ReadLine());
                                para += toppara;
                                Console.WriteLine("bakiyeniz:" + para);
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("Yükleme animasyonu başlıyor...");
                                for (int i = 0; i <= 20; i++)
                                {
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write("[");
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write("#");
                                    }
                                    Console.Write(new string(' ', 20 - i));
                                    Console.Write("]");
                                    Console.WriteLine($" {i * 5}%");
                                    Thread.Sleep(200);
                                    if (i == 20)
                                    {
                                        for (int k = i; k >= 0; k--)
                                        {
                                            Console.SetCursorPosition(0, 1);
                                            Console.Write("[");
                                            for (int j = 0; j < k; j++)
                                            {
                                                Console.Write("#");
                                            }

                                            Console.Write(new string(' ', 20 - k));
                                            Console.Write("]");
                                            Console.WriteLine($" {k * 5}%");
                                            Thread.Sleep(100);
                                        }
                                    }
                                }
                                Console.SetCursorPosition(0, 1);
                                Console.WriteLine("[####################] 100% Yükleme Tamamlandı!");
                                Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                Console.WriteLine("lütfen havale edeceğiniz kişinin ismini girin");
                                string isim = Console.ReadLine();
                                Console.WriteLine("lütfen havale edeceğiniz miktarı girin");
                                para = Convert.ToInt32(Console.ReadLine());
                                if (toppara > para)
                                {
                                    Console.WriteLine(isim, " adlı kişiye " + para + "miktarında havale para gönderildi");
                                }
                                else
                                {
                                    Console.WriteLine("bakiyeniz yetersiz");
                                }
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Console.WriteLine("Yükleme animasyonu başlıyor...");
                                for (int i = 0; i <= 20; i++)
                                {
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write("[");
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write("#");
                                    }
                                    Console.Write(new string(' ', 20 - i));
                                    Console.Write("]");
                                    Console.WriteLine($" {i * 5}%");
                                    Thread.Sleep(200);
                                    if (i == 20)
                                    {
                                        for (int k = i; k >= 0; k--)
                                        {
                                            Console.SetCursorPosition(0, 1);
                                            Console.Write("[");
                                            for (int j = 0; j < k; j++)
                                            {
                                                Console.Write("#");
                                            }

                                            Console.Write(new string(' ', 20 - k));
                                            Console.Write("]");
                                            Console.WriteLine($" {k * 5}%");
                                            Thread.Sleep(100);
                                        }
                                    }
                                }
                                Console.SetCursorPosition(0, 1);
                                Console.WriteLine("[####################] 100% Yükleme Tamamlandı!");
                                Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                Console.WriteLine("lütfen trasnfer edeceğiniz cihaza gönderilen 6 hanseini girin girin");
                                string kod = Console.ReadLine();
                                if (kod.Length == 6)
                                {
                                    Console.WriteLine("kod başarılı");
                                    Console.WriteLine("lütfen transfer edeceğiniz miktarı girin");
                                    para = Convert.ToInt32(Console.ReadLine());
                                    if (toppara > para)
                                    {
                                        Console.WriteLine(kod + " adlı kişiye " + para + " miktarında transfer para gönderildi");
                                    }
                                    else
                                    {
                                        Console.WriteLine("bakiyeniz yetersiz");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("kod başarısız lütfen tekrar deneyin");
                                }
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Yükleme animasyonu başlıyor...");
                                for (int i = 0; i <= 20; i++)
                                {
                                    Console.SetCursorPosition(0, 1);
                                    Console.Write("[");
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write("#");
                                    }
                                    Console.Write(new string(' ', 20 - i));
                                    Console.Write("]");
                                    Console.WriteLine($" {i * 5}%");
                                    Thread.Sleep(200);
                                    if (i == 20)
                                    {
                                        for (int k = i; k >= 0; k--)
                                        {
                                            Console.SetCursorPosition(0, 1);
                                            Console.Write("[");
                                            for (int j = 0; j < k; j++)
                                            {
                                                Console.Write("#");
                                            }

                                            Console.Write(new string(' ', 20 - k));
                                            Console.Write("]");
                                            Console.WriteLine($" {k * 5}%");
                                            Thread.Sleep(100);
                                        }
                                    }
                                }
                                Console.SetCursorPosition(0, 1);
                                Console.WriteLine("[####################] 100% Yükleme Tamamlandı!");
                                Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                Console.WriteLine("hangi faturayı ödemek istiyorsunuz");
                                Console.WriteLine("su faturası için 1 i ");
                                Console.WriteLine("doğalgaz faturası için 2 yi");
                                Console.WriteLine("araba sigortası için 3 ü");
                                Console.WriteLine("cebe tl yüklemek için 4 ü ");
                                Console.WriteLine("elektirik faturası için 5 i ");
                                Console.WriteLine("odun için 6 yı");
                                Console.WriteLine("kömür için 7 yi tuşlayın");
                                Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                fatura = Convert.ToInt32(Console.ReadLine());
                                switch (fatura)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen ödiyeceğiniz su faturasının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen ödiyeceğiniz doğalgaz faturasının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen ödiyeceğiniz araba sigortasının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen ödiyeceğiniz ceb tl faturasının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen ödiyeceğiniz elektirik faturasının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen aldığınız kışlık odun miktarının fiyatının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("%%%%%%%%%%%%%%%-------_________-------%%%%%%%%%%");
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            Console.WriteLine("lütfen aldığınız kışlık odun miktarının fiyatının tutarını girin");
                                            çekpara = Convert.ToInt32(Console.ReadLine());
                                            kalanpara = toppara - çekpara;
                                            Console.WriteLine(çekpara + " tutarında ki tl miktarı hesabınızdan tahsil edildi kalan paranız: " + kalanpara);
                                            Console.WriteLine("%%%%%%%%%%%%%%%///////////\\\\\\\\\\\\%%%%%%%%%%");
                                            break;
                                        }
                                }
                                break;
                            }

                        case 6:
                            {
                                Console.WriteLine("çıkmak istiyorsanız lütfen size verilen 'aT122' kodu kullanarak uygulamadan çıkın");
                                string cod = Console.ReadLine();
                                if (cod == "aT122")
                                {
                                    çikis = false;
                                    Console.WriteLine("uygulamadan çıktınız , bizi tercih ettiğiniz için teşekkürlerimizi sunarız");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("lütfen tekrar deneyin");

                                }
                                break;
                            }

                    }
                }
                else if (sifregir != parola)
                {
                    Console.WriteLine("yanlış şifre veya parola girdiniz lütfen tekrar deneyin");
                    girishakki--;

                    if (girishakki > 0)
                    {
                        Console.WriteLine("kalan girişhakkınız: " + girishakki);
                        sifregir = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("giriş hakkınız kalmadı lütfen daha sonra tekrar deneyiniz");
                        break;
                    }
                }
            }
        }
    }
}
