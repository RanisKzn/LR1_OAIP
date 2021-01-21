using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class ShapeContainer
    {
        public static List<Figure> figurelist;
        public ShapeContainer()
        {
            figurelist = new List<Figure>();

        }
        public static void AddFigure(Figure figure)
        {
            figurelist.Add(figure);
        }
     }
        
}
