using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class kitchen : Form
    {

        public kitchen()
        {
            InitializeComponent();
            CenterToScreen();
            lstKitchen.Columns.Add("Table Number", lstKitchen.Width * 1 / 3);
            lstKitchen.Columns.Add("Food Name ", lstKitchen.Width * 1 / 3);
            lstKitchen.Columns.Add("Piece", lstKitchen.Width * 1 / 3);
            lstKitchen.Columns.Add("OrderId", lstKitchen.Width * 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();


            Form form = new login_page();
            form.Show();
            this.Hide();

        }



        private void kitchen_Load(object sender, EventArgs e)
        {
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            var query = from item in db.food_list
                        select new { item.food_name, item.food_id };
            var query2 = from item2 in db.orders2
                         select new { item2.food_id, item2.table_id, item2.piece, item2.o_id };
            foreach (var item2 in query2)
            {
                foreach (var item in query)
                {
                    if (item.food_id == item2.food_id)
                    {
                        ListViewItem newItem = new ListViewItem(item2.table_id.ToString());
                        lstKitchen.Items.Add(newItem);
                        newItem.SubItems.Add(item.food_name.ToString());
                        newItem.SubItems.Add(item2.piece.ToString());
                        newItem.SubItems.Add(item2.o_id.ToString());


                    }

                }
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            bool cheker = false;
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            var query = from item in db.food_list
                        select new { item.food_name, item.food_id };
            var query2 = from item2 in db.orders2
                         select new { item2.food_id, item2.table_id, item2.piece, item2.o_id };

            foreach (var item2 in query2)
            {
                if (lstKitchen.SelectedItems.Count > 0)
                {
                    cheker = true;
                    ListViewItem selectedItem = new ListViewItem();

                    foreach (ListViewItem selectedKitchenItem in lstKitchen.SelectedItems)
                    {
                        selectedItem = selectedKitchenItem;

                        if (item2.o_id.ToString() == selectedItem.SubItems[3].Text)
                        {
                            using (var db2 = new DbOtomasyon2Entities2())
                            {
                                payment2 t = new payment2();
                                t.table_id = item2.table_id;
                                t.food_id = item2.food_id;
                                t.piece = item2.piece;
                                db2.payment2.Add(t);

                                // İşlemleri gerçekleştirin
                                var x = db2.orders2.Find(item2.o_id);
                                db2.orders2.Remove(x);
                                db2.SaveChanges();
                            }
                        }
                    }
                }
            }

            lstKitchen.Items.Clear();

            if (lstKitchen.SelectedItems.Count < 1)
            {
                lstKitchen.Items.Clear();

                foreach (var item2 in query2)
                {
                    foreach (var item in query)
                    {
                        if (item.food_id == item2.food_id)
                        {
                            ListViewItem newItem = new ListViewItem(item2.table_id.ToString());
                            lstKitchen.Items.Add(newItem);
                            newItem.SubItems.Add(item.food_name.ToString());
                            newItem.SubItems.Add(item2.piece.ToString());
                            newItem.SubItems.Add(item2.o_id.ToString());
                        }
                    }
                }

                if (!cheker)
                {
                    MessageBox.Show("sipariş seçin");
                }
                else
                {
                    MessageBox.Show("sipariş hazırlandı");
                }
            }
        }
    }
    }
