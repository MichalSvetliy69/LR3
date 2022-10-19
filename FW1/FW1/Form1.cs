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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoX_Click(object sender, EventArgs e)
        {/*
            string UserName = tbName.Name.Text.Trim();
            if (UserName.Length < 3)
            {
                MessageBox.Show("Введите имя пользователя:");
            }
            else
            {
                MessageBox.Show("Привет " + UserName);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
