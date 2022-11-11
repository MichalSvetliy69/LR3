using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW1
{
    internal class Eraser: Brush
    {
        static Bitmap ActualBmp;

        public static void ReloadBmp(Bitmap bmp)
        {
            ActualBmp = bmp;
        }
        public Eraser(Color BrushColor, int size) : base(BrushColor, size)
        {

        }



        public override void Draw(Bitmap image, int x, int y)
        {
            Random rnd = new Random();
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {

                        if (x0 > 0 & y0 > 0 & x0 < W & y0 < H)
                        {
                            image.SetPixel(x0, y0, ActualBmp.GetPixel(x0,y0));
                        }






                }

            }
        }
    }
}
