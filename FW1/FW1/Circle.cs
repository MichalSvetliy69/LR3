using System;
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
    internal class Circle :Brush
    {
        public Circle(Color BrushColor, int size) : base(BrushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int R = Size;
            
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                   


                    /*double dx = Convert.ToDouble(x);
                    double dy = Convert.ToDouble(y);*/
                    if (true)
                    {
                        try
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                        catch (Exception)
                        {


                        }
                    }



                }

            }
        }
    }
}
