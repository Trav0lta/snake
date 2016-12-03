using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            peint p1 = new peint(1, 3, '*');
            p1.Draw();


            peint p2 = new peint(4, 5, '#');
            p2.Draw();

            peint p3 = new peint(2, 4, '!');
            p3.Draw();

            peint p4 = new peint(3, 5, '$');
            p4.Draw();

            peint p5 = new peint(6, 8, '%');
            p5.Draw();

            peint p6 = new peint(8, 6, '^');
            p6.Draw();

            List<peint> plist = new List<peint>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);
            plist.Add(p5);
            plist.Add(p6);
            Console.ReadLine();
          }
            

        }
    }
