using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productsText = "Ürünler";
            var addToCartButtonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten Çıkar";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[] { "Laptop", "Masaüstü PC", "Klavye" };
            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}
            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }


        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Öncelikle bir eleman seçmelisiniz.");
            }
            
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncellikle bir ürün seçmelisiniz");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }

        }
    }
}
