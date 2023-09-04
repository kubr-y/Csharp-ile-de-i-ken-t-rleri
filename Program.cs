
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1="20";
            int sayi1=20;
            string yenideger= str1+ sayi1.ToString();
        Console.WriteLine(yenideger);

        int yenideger2= sayi1+ Convert.ToInt32(str1);
        Console.WriteLine(yenideger2);





           string dt1=DateTime.Now.ToString("dd.MM.yyyy");
           Console.WriteLine(dt1);

           string dt2= DateTime.Now.ToString("HH.mm");
           Console.WriteLine(dt2);

           

        }
    }
}