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

  
    public partial class Form1 : Form
    {

        int _x;
        int _y;


        bool _mouseClicked = false;

        Color SelectedColor
        {
            get { return Color.Red; }
        }

        int SelectedSize
        {
            get { return trackBar1.Value*2; }
        }

        Brush _selectedBrush;














        void CreateBlank(int width, int height)
        {
            var OldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (OldImage != null)
            {
                OldImage.Dispose();
            }

        }
        Color DefaultColor
        {
            get { return Color.White; }
        }
        public Form1()
        {
            InitializeComponent();

            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

     

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Brush2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new RandBrush(SelectedColor, SelectedSize);
        }

        private void brush1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }
            _selectedBrush.Draw(pictureBox1.Image as Bitmap , _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Brush4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Circle(SelectedColor, SelectedSize);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
