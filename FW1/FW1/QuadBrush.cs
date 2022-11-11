﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FW1
{
    internal class QuadBrush : Brush
    {
        public QuadBrush(Color BrushColor, int size): base(BrushColor, size)
        {

        }

        public override void Draw(Bitmap image,int x,int y)
        {
            for (int y0 = y - Size ; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if (x0 > 0 & y0 > 0 & x0 < W & y0 < H)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                       
                    

                }

            }
        }
    }
}
