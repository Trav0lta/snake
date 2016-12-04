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
            horisontalLine Upline = new horisontalLine(0, 78, 0, '+');
            horisontalLine Downline = new horisontalLine(0, 78, 24, '+');
            verticalLine Leftline = new verticalLine(0, 0, 24, '+');
            verticalLine Rightline = new verticalLine(78, 0, 24, '+');
            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();

           
            peint p1 = new peint(4, 5, '#');
            p1.Draw();

            Console.ReadLine();
          }
        }
    }
