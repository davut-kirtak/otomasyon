using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class order_page : Form
    {
        public event EventHandler<string> Button_Click;

        public order_page()
        {
            InitializeComponent();
            CenterToScreen();
            listView1.Columns.Add("Yemek İsmi", listView1.Width * 1 / 2);
            listView1.Columns.Add("Adeti", listView1.Width * 1 / 3);
            listView1.Columns.Add("Fiyatı", listView1.Width * 1 / 6);

        }
        public string MasaAdi;


        private void ButtonOlustur(int Count)
        {
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            var query = from item in db.food_list
                        select new { item.food_name, item.c_id };

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in query)
            {

                if (Count == item.c_id)
                {
                    Button button = new Button();
                    button.Text = item.food_name;
                    button.Width = flowLayoutPanel1.Width * 1 / 3;
                    button.Height = flowLayoutPanel1.Height * 1 / 3;
                    flowLayoutPanel1.Controls.Add(button);
                    button.Click += siparisiAl;
                }


            }

        }
        int price = 0;

        private void siparisiAl(object sender, EventArgs e)
        {
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            string buttonName = (sender as Button).Text;


            bool varMi = false;

            // ListView'da aynı ürün adını kontrol et
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == buttonName)
                {


                    varMi = true;

                    // Eğer ürün zaten varsa, adetini artır
                    int adet = Convert.ToInt32(item.SubItems[1].Text);
                    adet += 1;
                    item.SubItems[1].Text = adet.ToString();
                    item.SubItems[2].Text = (adet * price).ToString();

                    break;
                }
            }

            // Eğer ürün yoksa, yeni bir ListViewItem oluştur
            if (!varMi)
            {

                ListViewItem newItem = new ListViewItem(buttonName);


                var query = from item in db.food_list
                            select new { item.food_name, item.c_id, item.price };
                foreach (var item in query)
                {
                    if (buttonName == item.food_name)
                    {
                        price = item.price;
                        break;
                    }
                }
                newItem.SubItems.Add("1"); // Adet
                listView1.Items.Add(newItem);
                newItem.SubItems.Add(price.ToString());

            }







        }







        private void btnBreakfast_Click(object sender, EventArgs e)
        {

            ButtonOlustur(1);

        }

        private void btnLunch_Click(object sender, EventArgs e)
        {

            ButtonOlustur(2);

        }

        private void btnDinner_Click(object sender, EventArgs e)
        {

            ButtonOlustur(3);

        }

        private void btnSnack_Click(object sender, EventArgs e)
        {

            ButtonOlustur(4);

        }

        private void btnDessert_Click(object sender, EventArgs e)
        {

            ButtonOlustur(5);

        }

        private void btnSalad_Click(object sender, EventArgs e)
        {

            ButtonOlustur(6);

        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {

            ButtonOlustur(7);

        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {

            ButtonOlustur(8);

        }

        private void btnSeaFood_Click(object sender, EventArgs e)
        {

            ButtonOlustur(9);


        }

        private void btnVegetarian_Click(object sender, EventArgs e)
        {

            ButtonOlustur(10);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new main_page("waiter");
            form.Show();
            this.Hide();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            DbOtomasyon2Entities2 db = new DbOtomasyon2Entities2();
            var query = from item in db.food_list
                        select new { item.food_name, item.food_id };
            var query2 = from item2 in db.orders2
                         select new { item2.food_id,item2.table_id,item2.piece};
            foreach (ListViewItem item1 in listView1.Items)
            {
                int foodId = 0;
                int piece = 0;

                // İlgili yemek adına sahip olan food_list öğesini bul
                var matchingFood = db.food_list.FirstOrDefault(item => item.food_name == item1.Text);

                if (matchingFood != null)
                {
                    foodId = matchingFood.food_id;
                    piece = Convert.ToInt32(item1.SubItems[1].Text);

                    // Diğer işlemler...
                    orders2 o = new orders2();
                    o.table_id = Convert.ToInt32(label2.Text);
                    o.food_id = foodId;
                    o.piece = piece;

                    try
                    {
                        db.orders2.Add(o);
                        db.SaveChanges();
                        // Olayları takip etmek ve gerekirse işlem yapmak için oId'i kullanabilirsiniz.
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {
                        // Hata durumunu incele
                        var innerException = ex.InnerException?.InnerException;

                        if (innerException is System.Data.SqlClient.SqlException sqlException)
                        {
                            if (sqlException.Number == 2627) // 2627: Violation of PRIMARY KEY constraint
                            {
                                // Primary key ihlali, burada gerekli işlemleri yapabilirsiniz.
                                Console.WriteLine("Violation of PRIMARY KEY constraint.");
                            }
                        }
                        else
                        {
                            // Diğer hata durumları için gerekli işlemleri yapabilirsiniz.
                            Console.WriteLine($"DbUpdateException: {ex.Message}");
                        }

                    }





                }

            }


            listView1.Items.Clear();
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main_page form = new main_page("waiter");
            form.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }

        }


    }
}