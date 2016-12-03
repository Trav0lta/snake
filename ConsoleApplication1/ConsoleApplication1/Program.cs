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
            verticalLine linne = new verticalLine(10, 2, 8, '=');
            linne.Drow();
            horisontalLine line = new horisontalLine(5, 10, 8, '+');
            line.Drow();
            
            /*horisontalLine line = new horisontalLine();
            line.Drow();*/

          
            Console.ReadLine();
          }
            

        }
    }
