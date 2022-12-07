/// kullanıcı bilgilerini isteme

namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            string kadi, sifre;
            Console.WriteLine("Kullanıcı Adını Giriniz:");
            kadi = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            sifre = Console.ReadLine();
            if (kadi == "admin" && sifre == "123")
                Console.WriteLine("HOŞGELDİNİZ!!");
            else 
            {
                Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
            }
                

            Console.ReadKey();

























        }
    }
}