using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yılann
{
    internal class Program
    {
        static void Main(string[] args)
        {  /* 
            bu kodları denedik çalışıyor mu dşye cok da önemli değil asıl yer şimdi aşağısı
            yem y = new yem();
            y.uret();
           //buradan silmeyip alta ekleme yapmasaydım yılandan sda clear yaptıktan sonra
           //yemi de sildiği için çizmesi gerekiyor.


            yılan snake = new yılan();
            snake.Ciz();
            y.Ciz();
            */

            yılan snake = new yılan();
            yem yem = new yem();

            yem.uret();
            ConsoleKeyInfo basilantus;

            do//esc ye basılana kadar devm edecek bu döngü
            {

                basilantus = Console.ReadKey();//basıla tuşu oku anlamında kullanılıyor.
                snake.hareketEt(basilantus);
                snake.Ciz();
                yem.Ciz();

                if(snake.yemiyedimi(yem) == true)
                {
                    yem.uret();
                    snake.Ciz();
                }
            
                snake.skoryaz();




            } while (basilantus.Key != ConsoleKey.Escape);//esc ye basmadıgın sürece anlamında yani while içine şartı bu şekil koşuyor.




        }
    }
}
