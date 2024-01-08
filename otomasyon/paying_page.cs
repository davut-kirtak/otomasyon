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
    public partial class paying_page : Form
    {
        public paying_page()
        {
            InitializeComponent();
            CenterToScreen();
            lstPayment.Columns.Add("Table Number", lstPayment.Width * 1 / 4);
            lstPayment.Columns.Add("Food Name ", lstPayment.Width * 1 / 4);
            lstPayment.Columns.Add("Piece", lstPayment.Width * 1 / 4);
            lstPayment.Columns.Add("Price", lstPayment.Width * 1 / 4);

        }

        private void paying_page_Load(object sender, EventArgs e)
        {
            
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            var query = from item in db.food_list
                        select new { item.food_name, item.food_id,item.price };
            var query2 = from item2 in db.payment2
                         select new { item2.food_id, item2.table_id, item2.piece };
            foreach (var item2 in query2)
            {
                foreach (var item in query)
                {
                    if (item.food_id == item2.food_id)
                    {
                        if (item2.table_id == Convert.ToInt32(lblTableNumber.Text))
                        {
                            ListViewItem newItem = new ListViewItem(item2.table_id.ToString());
                            lstPayment.Items.Add(newItem);
                            newItem.SubItems.Add(item.food_name.ToString());
                            newItem.SubItems.Add(item2.piece.ToString());
                            newItem.SubItems.Add((item.price*item2.piece).ToString());

                        }



                    }

                }
            }
            int total = 0;
            foreach(ListViewItem item in lstPayment.Items)
            {
                total += Convert.ToInt32(Convert.ToInt32(item.SubItems[3].Text));
            }
            lblTotal.Text ="Total: "+ total.ToString();
        }

        private void bckBttn_Click(object sender, EventArgs e)
        {
            main_page form = new main_page("cashier");
            form.Show();
            this.Hide();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            using (var context = new DbOtomasyon2Entities2())
            {
                int selectedTableId = Convert.ToInt32(lblTableNumber.Text); // Silinecek table_id'yi belirleyin, bu değeri kendi projenizin mantığına göre ayarlayın.

                // Sadece belirli bir table_id'ye sahip olan verileri sorgula
                var recordsToDelete = context.payment2.Where(x => x.table_id == selectedTableId).ToList();

                if (recordsToDelete.Count > 0)
                {
                    context.payment2.RemoveRange(recordsToDelete);
                    context.SaveChanges();

                    
                    MessageBox.Show($"{selectedTableId} Numaralı Masa'nın Hesabı Nakit Olarak Ödendi.");
                    lblTotal.Text = "";
                    int total = 0;  
                    lstPayment.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"{selectedTableId}Numaralı Masa'ya Ait Sipariş Yoktur.");
                }
            }

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            using (var context = new DbOtomasyon2Entities2())
            {
                int selectedTableId = Convert.ToInt32(lblTableNumber.Text); // Silinecek table_id'yi belirleyin, bu değeri kendi projenizin mantığına göre ayarlayın.

                // Sadece belirli bir table_id'ye sahip olan verileri sorgula
                var recordsToDelete = context.payment2.Where(x => x.table_id == selectedTableId).ToList();

                if (recordsToDelete.Count > 0)
                {
                    context.payment2.RemoveRange(recordsToDelete);
                    context.SaveChanges();

                    MessageBox.Show($"{selectedTableId} Numaralı Masa'nın Hesabı Kart ile Ödendi.");
                    lstPayment.Items.Clear();
;                    lblTotal.Text = "";
                    int total = 0;
                }
                else
                {
                    MessageBox.Show($"{selectedTableId}Numaralı Masa'ya Ait Sipariş Yoktur.");
                }
            }
        }
    }
}
