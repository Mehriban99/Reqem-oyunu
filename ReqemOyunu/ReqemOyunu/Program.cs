using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqemOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int texmin=0, saygac=0;

            Random myNum = new Random();
            int reqem = myNum.Next(0, 100);

            Console.WriteLine("Zehmet olmasa reqem daxil edin (0-100)");

            while(texmin != reqem)
            {
                saygac++;
                texmin = Convert.ToInt32(Console.ReadLine());
                if(texmin > reqem)
                {
                    Console.WriteLine("Zehmet olmasa {0}-dan daha kicik reqem daxil edin", texmin);
                }
                else if(texmin < reqem) {
                    Console.WriteLine("Zehmet olmasa {0}-dan daha boyuk reqem daxil edin", texmin);
                }
            }
            Console.WriteLine("Tebrikler, siz {0} defeye dogru cavabi tapdiniz", saygac);
            Console.ReadKey();
        }
    }
}
