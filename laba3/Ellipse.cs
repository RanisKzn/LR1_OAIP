﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace laba3
{
    class Ellipse: Figure
    {
        public Ellipse (int x, int y, int w,int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;

        }
        public Ellipse()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;

        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse (Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoweTo(int x, int y)
        {
            
        }
    }
}
