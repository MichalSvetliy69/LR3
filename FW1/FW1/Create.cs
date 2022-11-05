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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }


        public string Name
        {
            get
            {
                string text = textBox1.Text;
                return text;
            }
            set
            {
                
            }

        }




     
        public int W
        {
            get
            {
                try
                {
                    string text = textBox2.Text;
                    int value = Convert.ToInt32(text);
                    return value;
                }
                catch (Exception)
                {

                    return 0;
                }
                
            }
        }

        public int H
        {
            get
            {

                try
                {
                    string text = textBox3.Text;
                    int value = Convert.ToInt32(text);
                    return value;
                }
                catch (Exception)
                {

                    return 0;
                }
               
            }
        }

        bool _canceled = true;
        public bool Canceled
            { get { return _canceled; }  }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _canceled = false;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Enter(object sender, EventArgs e)
        {
            
        }
        private void Create_FormClosing(object sender, FormClosingEventArgs e)// событие закрытия формы
        {
            if (e.CloseReason == CloseReason.UserClosing)//Проверяем причину закрытия
            {
                Application.Exit();//здесь делаете что надо
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
