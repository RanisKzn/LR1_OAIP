using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Square : Rectangle
    {
          public Square (int x, int y, int w) : base (x,y,w,w)
        {
            
        }
          public Square()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;

        }
    }
}
