using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class horisontalLine
    {
        List<peint> plist;

         public horisontalLine(int xleft, int xright, int y, char sym)
         {
             plist = new List<peint>();
             for(int x = xleft; x <= xright; x++)
             {
                 peint p = new peint(x, y, sym );
                 plist.Add( p );
             }
         }
         
       /* public horisontalLine()
        {
            plist = new List<peint>();
            peint p1 = new peint(4, 4, '*');
            peint p2 = new peint(5, 4, '*');
            peint p3 = new peint(6, 4, '*');
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
        }*/




        public void Drow()
        {
            foreach(peint p in plist)
            {
                p.Draw();
            }
        }


    }
}
