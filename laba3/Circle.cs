using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Circle: Ellipse
    {
          public Circle (int x, int y, int w,int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = w;

        }
        public Circle()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
    }
}
