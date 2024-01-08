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
   
    public partial class login_page : Form
    {
       
        public login_page()
        {
            InitializeComponent();
            CenterToScreen();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = "";
            bool check = false;
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            
            var query = from item in db.employees
                        select new { item.user_name, item.password, item.type };
            foreach (var item in query.ToList())
            {

                if (textBox1.Text.Trim() == item.user_name.Trim() && textBox2.Text.Trim() == item.password.Trim())
                {
                    type = item.type.Trim();
                    MessageBox.Show("başarılı");

                    if (item.type.Trim() != "chef")
                    {

                        Form form = new main_page(type);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form form = new kitchen();
                        form.Show();
                        this.Hide();
                    }
                    check = true;
                    break;

                }


                

            }
            
            if ( !check )
            {
                MessageBox.Show("bilgileriniz hatalı");
            }
               
                
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
