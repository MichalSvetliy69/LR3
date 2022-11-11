using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FW1
{


    public partial class Form1 : Form
    {

        Image image1;


        int ImW, ImH;
        string MyBrush;

        int _x;
        int _y;


        bool _mouseClicked = false;

        Color MyColor;
        Color SelectedColor
        {
            get { return MyColor; }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }

        Brush _selectedBrush;














        void CreateBlank(int width, int height)
        {

            try
            {
                var OldImage = pictureBox1.Image;
                var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                ImW = bmp.Width;
                ImH = bmp.Height;
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
            catch (Exception)
            {

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
            Brush.GetSize(pictureBox1.Width, pictureBox1.Height);
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
            MyBrush = "RandBrush";
        }

        private void brush1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
            MyBrush = "QuadBrush";
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
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            _mouseClicked = false;
            try
            {
                if (MyBrush == "Transparent") /*_selectedBrush.ToString() == "FW1.Transparent*/
                {
                    
                    _selectedBrush = new Transparent(SelectedColor, SelectedSize);
                }
            }
            catch (Exception)
            {


            }


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
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":

                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

            image1 = Image.FromFile(filePath);
            pictureBox1.Image = Image.FromFile(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            CreateBlank(pictureBox1.Image.Width, pictureBox1.Image.Height);
            pictureBox1.Image = Image.FromFile(filePath);
            Brush.H = pictureBox1.Image.Height;
            Brush.W = pictureBox1.Image.Width;



        }

        private void Brush4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Circle(SelectedColor, SelectedSize);
            MyBrush = "Circle";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Create form = new Create();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
                ImW = form.W;
                ImH = form.H;
                Brush.W = form.W;
                Brush.H = form.H;
            }

            


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyColor = Color.Black;
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                  
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyColor = Color.Blue;
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                    
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyColor = Color.Green;
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                    
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyColor = Color.Red;
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                   
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyColor = Color.Yellow;
            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                    
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyColor = Color.White;

            switch (MyBrush)
            {
                case "Circle":
                    _selectedBrush = new Circle(MyColor, SelectedSize);
                    break;
                case "QuadBrush":
                    _selectedBrush = new QuadBrush(MyColor, SelectedSize);
                    break;
                case "RandBrush":
                    _selectedBrush = new RandBrush(MyColor, SelectedSize);
                    break;
                case "Transparent":
                    
                    _selectedBrush = new Transparent(MyColor, SelectedSize);
                    break;
                case "Eraser":

                    _selectedBrush = new Eraser(Color.White, SelectedSize);
                    break;


                default:
                    break;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (image1 == null)
            {
                _selectedBrush = new Circle(Color.White, SelectedSize);
                MyBrush = "Eraser";
            }
            else
            {
                MyBrush = "Eraser";
                Bitmap bmp19 = (Bitmap)image1;
                Eraser.ReloadBmp(bmp19);
                _selectedBrush = new Eraser(Color.White, SelectedSize);
            }


        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                Image image = pictureBox1.Image;
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Brush3_Click(object sender, EventArgs e)
        {
            
            _selectedBrush = new Transparent(MyColor, SelectedSize);
            MyBrush = "Transparent";

        }


    }
}
