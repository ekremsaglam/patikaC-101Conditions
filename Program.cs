using System;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (6<time && time <11){
                Console.WriteLine("Günaydın");
            }
            else if (time <18 ){
                Console.WriteLine("İyi günler");
            }
            else if (time>18 ){
                Console.WriteLine("İyi geceler");
            }
            string sonuc;
            //sonuc=time<18 ? "iyi günler" : "İyi geceler";

            sonuc = time<11 && time>=6 ? "Günaydın" : time<=18 ? "İyi Günler" : "İyi Geceler"; 
            Console.WriteLine(sonuc);
        }
    }
}
