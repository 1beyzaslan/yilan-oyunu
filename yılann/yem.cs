using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yılann
{
    internal class yem //BAK SINIFI YAPTIK İÇİNE TANIMLANACAK İFADELERİ YAZ
    {
        public int X , Y;
        public char chr = '*';

        public void uret() //yemi üreticez sonra da başka metot tanımlayıp çizdiricez.
        {
            Random sayiGen = new Random();
            X = sayiGen.Next(1, 31);
            Y = sayiGen.Next(1, 21);
            // yılan her yemi yediğinde yılan sınııfnda yemin tekrar üretilmesini yılan sağlayacak.


        }

        public void Ciz()
        {
            Console.SetCursorPosition(X,Y);
            Console.WriteLine(chr);
        }
    }
}
