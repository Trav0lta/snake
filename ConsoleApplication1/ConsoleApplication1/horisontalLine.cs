using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class horisontalLine : figure
    {
        public horisontalLine(int xleft, int xright, int y, char sym)
         {
             plist = new List<peint>();
             for(int x = xleft; x <= xright; x++)
             {
                 peint p = new peint(x, y, sym );
                 plist.Add( p );
             }
         }
    }
}
