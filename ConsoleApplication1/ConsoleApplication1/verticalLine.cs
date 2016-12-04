using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class verticalLine : figure
    {
        public verticalLine(int x, int yap, int ydown, char sym)
        {
            plist = new List<peint>();
            for (int y = yap; y <= ydown; y++)
            {
                peint p = new peint(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
