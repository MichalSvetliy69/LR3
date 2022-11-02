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
    internal class Transparent : Brush
    {
        int[,] mass;
        int W, H;
        public Transparent(Color BrushColor, int size,int W,int H) : base(BrushColor, size)
        {
            this.W = W;
            this.H = H;
            this.mass = new int[W, H];
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    this.mass[i, j] = 0;
                }
            }
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    try
                    {
                        if (mass[x0, y0] != 1)
                        {


                            try
                            {
                                Color ImColor = image.GetPixel(x0, y0);
                                int R = ImColor.R;
                                int G = ImColor.G;
                                int B = ImColor.B;
                                int R1 = BrushColor.R;
                                int G1 = BrushColor.G;
                                int B1 = BrushColor.B;
                                int R2 = (R + R1) / 2;
                                int G2 = (G + G1) / 2;
                                int B2 = (B + B1) / 2;
                                ImColor = Color.FromArgb(100, R2, G2, B2);
                                image.SetPixel(x0, y0, ImColor);

                            }
                            catch (Exception)
                            {


                            }
                            mass[x0, y0] = 1;

                        }
                    }
                    catch (Exception)
                    {


                    }
                    
                }

            }
            
        }


        

        public void Zero()
        {
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    mass[i, j] = 0;
                }
            }
        }

    }
}
