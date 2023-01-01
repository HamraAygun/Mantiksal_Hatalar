using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try   //Hata alması muhtemel olan alan buraya eklenir.
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
        }

        catch (Exception ex)  //Hata yakalandığında ne yapılmak istendği yazılan alan.
        {
            Console.WriteLine("Hata:" + ex.Message.ToString());
        }
        finally  //Koşuldan bağımsız çalışmasını istediğimiz alan.
        {
            Console.WriteLine("İşlem tamamlandı.");
        }


        try
        {
            int a = int.Parse(null);
                
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine(ex);
        }



        try
        {
            int a = int.Parse("Test");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil.");
            Console.WriteLine(ex);
        }




        try
        {
            int a = int.Parse("-20000000000");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
            Console.WriteLine(ex);
        }

        finally 
        {
            Console.WriteLine("İşlem başarıyla tamamlandı.");
        }
    }
}