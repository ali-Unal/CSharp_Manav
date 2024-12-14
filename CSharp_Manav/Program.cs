namespace CSharp_Manav
{
    internal class Program
    {
        static List<string> manav_urunler = new List<string>();

        static List<string> manav_sebzeler = new List<string>();

        static List<int> manav_kilolar = new List<int>();
        static List<int> manav_sebze_kilo = new List<int>();

        static List<string> urunler = new List<string>() { "Elma", "Limon", "Armut", "Portakal", "Mandalina" };

        static List<string> sebzeler = new List<string>() { "Havuç", "Salatalık", "Domates", "Mantar", "Pırasa" };

        static int toplam = 0;

        static void Main(string[] args)
        {
            Toptanci(ref urunler, ref sebzeler, ref manav_urunler, ref manav_sebzeler, ref manav_kilolar, ref manav_sebze_kilo);

            Manav(ref urunler, ref sebzeler, ref manav_urunler, ref manav_sebzeler, ref manav_kilolar, ref manav_sebze_kilo);
        }
        static void Toptanci(ref List<string> urunler, ref List<string> sebzeler, ref List<string> manav_urunler, ref List<string> manav_sebzeler, ref List<int> manav_kilolar, ref List<int> manav_sebze_kilo)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("HALE HOŞGELDİNİZ\n\nMeyve için M, sebze için S'ye basınız");
                string hal_secim = Console.ReadLine().ToUpper();

                while (true)
                {
                    if (hal_secim == "M" || hal_secim == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Hatalı seçim. Seçeneklerden birini tuşlayın: ");
                        hal_secim = Console.ReadLine().ToUpper();
                    }
                }

                if (hal_secim == "M")
                {
                    while (true)
                    {
                        int i = 0;

                        Console.Clear();

                        Console.WriteLine("Meyveler:\n");

                        foreach (var item in urunler)
                        {
                            Console.WriteLine((i + 1) + " - " + item);
                            i++;
                        }

                        Console.Write("\nSeçmek istediğiniz ürünün numarasını girin: ");

                        if (int.TryParse(Console.ReadLine(), out int secim) == false)
                        {
                            Console.WriteLine("Geçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (secim < 1 || secim > urunler.Count)
                        {
                            Console.WriteLine("Geçersiz seçim. Ürün numaralarından birini seçtiğinize emin olun ve tekrar deneyin. Devam etmek için Enter'a basın");
                            Console.ReadLine();
                            continue;
                        }

                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Seçiminiz: " + urunler[secim - 1] + ", kaç kilo alacağınızı tuşlayın: ");

                            if (int.TryParse(Console.ReadLine(), out int kilo_secim) == false)
                            {
                                Console.WriteLine("\nGeçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                                Console.ReadLine();
                                continue;
                            }
                            else if (kilo_secim <= 0)
                            {
                                Console.WriteLine("\nGeçersiz seçim. Gerçek bir değer ile tekrar deneyin. Devam etmek için Enter'a basın...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Clear();

                            string secilen_urun = urunler[secim - 1];
                            int secilen_urun_numara = manav_urunler.IndexOf(secilen_urun);

                            if (manav_urunler.Contains(secilen_urun))
                            {
                                manav_kilolar[secilen_urun_numara] += kilo_secim;
                            }
                            else
                            {
                                manav_urunler.Add(urunler[secim - 1]);
                                manav_kilolar.Add(kilo_secim);
                            }

                            Console.WriteLine($"İşlem başarıyla gerçekleşti. Alınan ürün: {urunler[secim - 1]}, {kilo_secim} kg.\n\nBaşka bir isteğiniz var mı? E - H");
                            string son_secim = Console.ReadLine().ToUpper();

                            while (true)
                            {
                                if (son_secim == "E")
                                {
                                    break;
                                }
                                else if (son_secim == "H")
                                {
                                    return;
                                }
                                else
                                {
                                    Console.Write("Hatalı giriş. Seçeneklerden birini tuşlayın: ");
                                    son_secim = Console.ReadLine().ToUpper();
                                }
                            }
                            break;
                        }
                        break;
                    }
                    continue;
                }
                else
                {
                    while (true)
                    {
                        int i = 0;

                        Console.Clear();

                        Console.WriteLine("Meyveler:\n");

                        foreach (var item in sebzeler)
                        {
                            Console.WriteLine((i + 1) + " - " + item);
                            i++;
                        }

                        Console.Write("\nSeçmek istediğiniz ürünün numarasını girin: ");

                        if (int.TryParse(Console.ReadLine(), out int secim) == false)
                        {
                            Console.WriteLine("Geçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (secim < 1 || secim > sebzeler.Count)
                        {
                            Console.WriteLine("Geçersiz seçim. Ürün numaralarından birini seçtiğinize emin olun ve tekrar deneyin. Devam etmek için Enter'a basın");
                            Console.ReadLine();
                            continue;
                        }

                        while (true)
                        {

                            Console.Clear();
                            Console.Write("Seçiminiz: " + sebzeler[secim - 1] + ", kaç kilo alacağınızı tuşlayın: ");

                            if (int.TryParse(Console.ReadLine(), out int kilo_secim) == false)
                            {
                                Console.WriteLine("\nGeçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                                Console.ReadLine();
                                continue;
                            }
                            else if (kilo_secim <= 0)
                            {
                                Console.WriteLine("\nGeçersiz seçim. Gerçek bir değer ile tekrar deneyin. Devam etmek için Enter'a basın...");
                                Console.ReadLine();
                                continue;
                            }

                            Console.Clear();

                            string secilen_urun = sebzeler[secim - 1];
                            int secilen_urun_numara = manav_sebzeler.IndexOf(secilen_urun);

                            if (manav_sebzeler.Contains(secilen_urun))
                            {
                                manav_sebze_kilo[secilen_urun_numara] += kilo_secim;
                            }
                            else
                            {
                                manav_sebzeler.Add(sebzeler[secim - 1]);
                                manav_sebze_kilo.Add(kilo_secim);
                            }

                            Console.WriteLine($"İşlem başarıyla gerçekleşti. Alınan ürün: {sebzeler[secim - 1]}, {kilo_secim} kg.\n\nBaşka bir isteğiniz var mı? E - H");
                            string son_secim = Console.ReadLine().ToUpper();

                            while (true)
                            {
                                if (son_secim == "E")
                                {
                                    break;
                                }
                                else if (son_secim == "H")
                                {
                                    return;
                                }
                                else
                                {
                                    Console.Write("Hatalı giriş. Seçeneklerden birini tuşlayın: ");
                                    son_secim = Console.ReadLine().ToUpper();
                                }
                            }
                            break;
                        }
                        break;
                    }
                    continue;
                }
            }
        }
        static void Manav(ref List<string> urunler, ref List<string> sebzeler, ref List<string> manav_urunler, ref List<string> manav_sebzeler, ref List<int> manav_kilolar, ref List<int> manav_sebze_kilo)
        {
            List<string> musteri = new List<string>();
            List<int> musteri_kilo = new List<int>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Manav Reyonu\n\nMeyve için M, sebze için S'ye basınız\n");
                string manav_secim = Console.ReadLine().ToUpper();

                while (true)
                {
                    if (manav_secim == "M" || manav_secim == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Hatalı seçim. Seçeneklerden birini tuşlayın: ");
                        manav_secim = Console.ReadLine().ToUpper();
                    }
                }

                if (manav_secim == "M")
                {
                    if (manav_urunler.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Şu an reyonumuzda meyve bulunmamaktadır. Başka bir seçenek ile tekrar deneyin. Devam etmek için Enter'a basın...");
                        Console.ReadLine();
                        continue;
                    }

                    int i = 0;

                    Console.Clear();

                    Console.WriteLine("Meyveler:\n");

                    foreach (var item in manav_urunler)
                    {
                        Console.WriteLine((i + 1) + " - " + item + ", Kalan miktar: " + manav_kilolar[i] + " Kg.");
                        i++;
                    }

                    Console.Write("\nSeçmek istediğiniz ürünün numarasını girin: ");

                    if (int.TryParse(Console.ReadLine(), out int secim) == false)
                    {
                        Console.WriteLine("Geçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                        Console.ReadLine();
                        continue;
                    }
                    else if (secim < 1 || secim > manav_urunler.Count)
                    {
                        Console.WriteLine("Geçersiz seçim. Ürün numaralarından birini seçtiğinize emin olun ve tekrar deneyin. Devam etmek için Enter'a basın");
                        Console.ReadLine();
                        continue;
                    }

                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Seçiminiz: " + manav_urunler[secim - 1] + ", kaç kilo alacağınızı tuşlayın: ");

                        if (int.TryParse(Console.ReadLine(), out int kilo_secim) == false)
                        {
                            Console.WriteLine("\nGeçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (kilo_secim <= 0)
                        {
                            Console.WriteLine("\nGeçersiz seçim. Gerçek bir değer ile tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (kilo_secim > manav_kilolar[secim - 1])
                        {
                            Console.WriteLine("\nÜründen yeteri kadar bulunmamaktadır. Gösterilen miktarın altında bir miktar ile tekrar deneyiniz.\n\nDevam etmek için Enter'a basın...");
                            Console.ReadLine();
                            break;
                        }

                        Console.Clear();

                        string secilen_urun = manav_urunler[secim - 1];
                        int secilen_urun_numara = manav_urunler.IndexOf(secilen_urun);

                        if (musteri.Contains(secilen_urun))
                        {
                            musteri_kilo[secilen_urun_numara] += kilo_secim;
                        }
                        else
                        {
                            musteri.Add(manav_urunler[secim - 1]);
                            musteri_kilo.Add(kilo_secim);
                        }

                        manav_kilolar[secilen_urun_numara] -= kilo_secim;

                        Console.WriteLine($"İşlem başarıyla gerçekleşti. Sepete eklenen ürün: {manav_urunler[secim - 1]}, {kilo_secim} kg.\n\nBaşka bir isteğiniz var mı? E - H");
                        string son_secim = Console.ReadLine().ToUpper();

                        if (manav_kilolar[secilen_urun_numara] == 0)
                        {
                            manav_urunler.Remove(secilen_urun);
                            manav_kilolar.Remove(secilen_urun_numara);
                        }

                        while (true)
                        {
                            if (son_secim == "E")
                            {
                                break;
                            }
                            else if (son_secim == "H")
                            {
                                int j = 0;

                                Console.WriteLine("Aldığınız ürünler:\n");

                                foreach (var item in musteri)
                                {
                                    Console.WriteLine((j + 1) + " - " + item + ", " + musteri_kilo[j] + " kg");
                                    j++;
                                }
                                return;
                            }
                            else
                            {
                                Console.Write("Hatalı giriş. Seçeneklerden birini tuşlayın: ");
                                son_secim = Console.ReadLine().ToUpper();
                            }
                        }
                        break;
                    }
                    continue;
                }

                else if (manav_secim == "S")
                {
                    if (manav_sebzeler.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Şu an reyonumuzda sebze bulunmamaktadır. Başka bir seçenek ile tekrar deneyin. Devam etmek için Enter'a basın...");
                        Console.ReadLine();
                        continue;
                    }

                    int i = 0;

                    Console.Clear();

                    Console.WriteLine("Sebzeler:\n");

                    foreach (var item in manav_sebzeler)
                    {
                        Console.WriteLine((i + 1) + " - " + item + ", Kalan miktar: " + manav_sebze_kilo[i] + " Kg.");
                        i++;
                    }

                    Console.Write("\nSeçmek istediğiniz ürünün numarasını girin: ");

                    if (int.TryParse(Console.ReadLine(), out int secim) == false)
                    {
                        Console.WriteLine("Geçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                        Console.ReadLine();
                        continue;
                    }
                    else if (secim < 1 || secim > manav_sebzeler.Count)
                    {
                        Console.WriteLine("Geçersiz seçim. Ürün numaralarından birini seçtiğinize emin olun ve tekrar deneyin. Devam etmek için Enter'a basın");
                        Console.ReadLine();
                        continue;
                    }

                    while (true)
                    {
                        Console.Clear();
                        Console.Write("Seçiminiz: " + manav_sebzeler[secim - 1] + ", kaç kilo alacağınızı tuşlayın: ");

                        if (int.TryParse(Console.ReadLine(), out int kilo_secim) == false)
                        {
                            Console.WriteLine("\nGeçersiz seçim. Rakam olarak tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (kilo_secim <= 0)
                        {
                            Console.WriteLine("\nGeçersiz seçim. Gerçek bir değer ile tekrar deneyin. Devam etmek için Enter'a basın...");
                            Console.ReadLine();
                            continue;
                        }
                        else if (kilo_secim > manav_sebze_kilo[secim - 1])
                        {
                            Console.WriteLine("\nÜründen yeteri kadar bulunmamaktadır. Gösterilen miktarın altında bir miktar ile tekrar deneyiniz.\n\nDevam etmek için Enter'a basın...");
                            Console.ReadLine();
                            break;
                        }

                        Console.Clear();

                        string secilen_urun = manav_sebzeler[secim - 1];
                        int secilen_urun_numara = manav_sebzeler.IndexOf(secilen_urun);

                        if (musteri.Contains(secilen_urun))
                        {
                            musteri_kilo[secilen_urun_numara] += kilo_secim;
                        }
                        else
                        {
                            musteri.Add(manav_sebzeler[secim - 1]);
                            musteri_kilo.Add(kilo_secim);
                        }

                        manav_sebze_kilo[secilen_urun_numara] -= kilo_secim;

                        Console.WriteLine($"İşlem başarıyla gerçekleşti. Sepete eklenen ürün: {manav_sebzeler[secim - 1]}, {kilo_secim} kg.\n\nBaşka bir isteğiniz var mı? E - H");
                        string son_secim = Console.ReadLine().ToUpper();

                        if (manav_sebze_kilo[secilen_urun_numara] == 0)
                        {
                            manav_sebzeler.Remove(secilen_urun);
                        }

                        while (true)
                        {
                            if (son_secim == "E")
                            {
                                break;
                            }
                            else if (son_secim == "H")
                            {
                                int j = 0;

                                Console.WriteLine("Aldığınız ürünler:\n");

                                foreach (var item in musteri)
                                {
                                    Console.WriteLine((j + 1) + " - " + item + ", " + musteri_kilo[j] + " kg");
                                    j++;
                                }
                                return;
                            }
                            else
                            {
                                Console.Write("Hatalı giriş. Seçeneklerden birini tuşlayın: ");
                                son_secim = Console.ReadLine().ToUpper();
                            }
                        }
                        break;
                    }
                    continue;
                }
            }
        }
    }
}
