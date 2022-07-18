using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OnSaniyeGeriSayım_timer_
{
    internal class Program
    {
        private static int x = 10;
        private static Timer sayac = new Timer();
        static void Main(string[] args)
        {
            sayac.Interval = 1000;
            sayac.Elapsed += gerisayim;
            sayac.Start();
            Console.ReadKey();

        }
        private static void gerisayim(Object source , System.Timers.ElapsedEventArgs e)
        {
            x--;
            Console.Clear();
            Console.Write(x);


            if (x==0)
            {
                Console.Write(" süre bitti");
                sayac.Stop();

            }
            
        }
    }
}
