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

        private void btnHello_Click(object sender, EventArgs e)
        {
            string UserName = tbName.Text.Trim();
            if (UserName.Length < 3)
            {
                MessageBox.Show("Введите имя пользователя:");
            }
            else
            {
                MessageBox.Show("Привет " + UserName);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void tbName_TextChanged(object sender, EventArgs e)
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

        }

        private void brush1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
