using System;

class User
{
    // Kullanıcıya ait özellikler
    public double Boy { get; set; }
    public double Kilo { get; set; }
    public int Yas { get; set; }
    public string Cinsiyet { get; set; }

    
    public User(double boy, double kilo, int yas, string cinsiyet)
    {
        Boy = boy;
        Kilo = kilo;
        Yas = yas;
        Cinsiyet = cinsiyet;
    }

    
    public double BMI()
    {
        return Kilo / (Boy * Boy); 
    }
}

class Dietitian
{
    
    public static void DisplayBMIResults(User user)
    {
        
        double bmi = user.BMI();
        Console.WriteLine($"Kilo-Boy Endeksiniz (BMI): {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Durum: Zayıf");
            Console.WriteLine("Öneri: Daha fazla protein ve kalori almanız gerekebilir. Öğünlerinize sağlıklı yağlar ve kompleks karbonhidratlar ekleyin.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Durum: Normal kilolu");
            Console.WriteLine("Öneri: Dengeli bir beslenmeye devam edin. Bol su içmeye ve düzenli egzersiz yapmaya özen gösterin.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Durum: Fazla kilolu");
            Console.WriteLine("Öneri: Kalori alımınızı kontrol altına alarak, düşük yağlı ve düşük karbonhidratlı besinler tercih edin.");
        }
        else
        {
            Console.WriteLine("Durum: Obez");
            Console.WriteLine("Öneri: Bir diyetisyen ile düzenli olarak çalışarak kalori alımınızı azaltın ve düzenli egzersiz yapın.");
        }
    }

    
    public static void DisplayDietPlan(User user)
    {
        Console.WriteLine("\nÖnerilen Günlük Beslenme Programı:");

        if (user.BMI() >= 18.5 && user.BMI() < 24.9)
        {
            // Normal kilolu için öneriler
            Console.WriteLine("- Kahvaltı: Yulaf ezmesi, süt ve meyve");
            Console.WriteLine("- Ara Öğün: Bir avuç badem");
            Console.WriteLine("- Öğle: Tavuklu salata, yanında kepekli ekmek");
            Console.WriteLine("- Ara Öğün: Yoğurt ve bir dilim tam tahıllı ekmek");
            Console.WriteLine("- Akşam: Izgara somon, yanında buharda sebze");
        }
        else if (user.BMI() < 18.5)
        {
            // Zayıf kilolu için daha fazla kalori önerisi
            Console.WriteLine("- Kahvaltı: Peynirli tost, bir bardak süt");
            Console.WriteLine("- Ara Öğün: Bir dilim kek ve bir fincan kahve");
            Console.WriteLine("- Öğle: Kızarmış tavuk, patates püresi");
            Console.WriteLine("- Ara Öğün: Dondurma veya bir avuç fındık");
            Console.WriteLine("- Akşam: Spagetti bolognese");
        }
        else
        {
            // Fazla kilolu ve obez için düşük kalori önerisi
            Console.WriteLine("- Kahvaltı: Yumurta beyazı, domates, salatalık");
            Console.WriteLine("- Ara Öğün: Yeşil elma");
            Console.WriteLine("- Öğle: Izgara tavuk göğsü, yoğurt ve sebze salatası");
            Console.WriteLine("- Ara Öğün: Havuç ve salatalık çubukları");
            Console.WriteLine("- Akşam: Fırında sebze ve balık");
        }
    }
}

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Alg Beslenme ve Diyetisyenlik Sistemine Hoşgeldiniz...");
        Console.WriteLine("Lütfen boyunuzu (metre cinsinden) girin:");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen kilonuzu (kg cinsinden) girin:");
        double kilo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen yaşınızı girin:");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen cinsiyetinizi girin (Kadın/Erkek):");
        string cinsiyet = Console.ReadLine();

        
        User user = new User(boy, kilo, yas, cinsiyet);

        
        Dietitian.DisplayBMIResults(user);
        Dietitian.DisplayDietPlan(user);

        
        Console.WriteLine("Sağlıklı bir yaşam için önerilere uymanız önemlidir. Sağlığınızı ihmal etmeyin!");
        Console.WriteLine("Bu hayatta sağlığınızdan daha önemli hiç birşey yoktur.");
        

    }
}

