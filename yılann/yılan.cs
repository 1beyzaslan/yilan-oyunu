using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yılann
{
    internal class yılan
    {
        public int X = 1 , Y = 1;
        public char chr = 'S';
        public int skor = 0;

             //her yeni yılanı çizdirmeden önce bi öncekini sil ekranı siliyoruz ama o zmn da yem giidyor o vakit yemi de tekrar çizdirmem lazım


       public void Ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(chr);

         }
    

       public void hareketEt(ConsoleKeyInfo basilantus)
         {
            if (basilantus.Key == ConsoleKey.RightArrow)
                X++;
            else if (basilantus.Key == ConsoleKey.LeftArrow)
                X--;
            else if (basilantus.Key == ConsoleKey.UpArrow)
                Y--;
            else if (basilantus.Key == ConsoleKey.DownArrow)
                Y++;
           
            //oyun alanı x:[1,30] , y:[1,20] bunları geçmişse oyun alanına taşı

            if (Y == 21)
                Y = 1;

            if (X == 31)
                X = 1;

            if (Y == 0)
                Y = 20;

            if (X == 0)
                X = 30;

        }


        public bool yemiyedimi (yem oanki)
         //yılan yemi yediyse oyunda tekrar yem üretmek için kulllancaz.kontrol yapıyoruz suan
        {
            bool sonuc = false;
            if((X == oanki.X)  && (Y == oanki.Y))
            {
                skor++;
                sonuc = true;
            }
            return sonuc;
        }

        public void skoryaz()
        {
            Console.SetCursorPosition(1, 22);//sütünü 1 tapı 22 olan yerde skor yazsın konum pozisyonu şeyi
            Console.WriteLine("skor : " + skor);


        }
    }




}
