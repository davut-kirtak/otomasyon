using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class main_page : Form
    {
        private string gelenVeri;

        public main_page(string gelenVeri)
        {
            InitializeComponent();
            CenterToScreen();
            for (int i = 0; i < 24; i++)
            {
                Button button = new Button();
                button.Text = "Masa" + " " + (i + 1).ToString();
                button.Width = flowLayoutPanel1.Width * 1 / 5;
                button.Height = flowLayoutPanel1.Height * 1 / 7;
                button.BackColor = Color.Black;
                button.ForeColor = Color.White;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;
            }
            void Button_Click(object sender, EventArgs e)
            {
                if (gelenVeri == "waiter")
                {
                    order_page newForm = new order_page();
                    newForm.Show();
                    this.Hide();
                    string table = (sender as Button).Text;
                    string[] tablesNumber = table.Split(' ');
                    newForm.label2.Text = tablesNumber[1];
                }
                
                else
                {
                    paying_page form = new paying_page();
                    string table = (sender as Button).Text;
                    string[] tablesNumber = table.Split(' ');
                    form.lblTableNumber.Text =tablesNumber[1];
                    form.Show();
                    this.Hide();
                }
                
            }

            this.gelenVeri = gelenVeri;
        }

        private void main_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new login_page();
            form.Show();
            this.Hide();
        }

        private void main_page_Load_1(object sender, EventArgs e)
        {

        }
    }
}