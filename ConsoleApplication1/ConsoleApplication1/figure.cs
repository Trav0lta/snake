using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class figure
    {
        protected List<peint> plist;
        public void Drow()
        {
            foreach (peint p in plist)
            {
                p.Draw();
            }
        }
    }
}
