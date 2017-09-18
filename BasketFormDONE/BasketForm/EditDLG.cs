using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketForm
{
    public partial class EditDLG : Form
    {
        private ShoppingBasket BasketForm;  
        public EditDLG(ShoppingBasket EditForm)
        {
            BasketForm = EditForm;
            InitializeComponent();
        }

        public string productName = "";
        public string productQuan = "";
        public string productPrice = "";

        private void EditDLG_Load(object sender, EventArgs e) //populates the box with these values by default 
        {
            decimal productQuant = Convert.ToDecimal(productQuan); 
            prodName.Text = productName;
            prodQuant.Value = productQuant;
            prodPrice.Text = productPrice;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)  //takes the values from the items and passes it back
        {
            decimal priceDec;
            int quantInt = Convert.ToInt32(prodQuant.Value);
            bool isNumeric = decimal.TryParse(prodPrice.Text, out priceDec);
            if (isNumeric != true)
            {
                MessageBox.Show("Enter a valid price");
                prodPrice.Text = "";
            }
            else
            {
                if (!int.TryParse(prodQuant.Text, out int value) || !decimal.TryParse(prodPrice.Text, out decimal value2) || quantInt < 1 || priceDec < 0)
                {

                    MessageBox.Show("Enter a valid price/quantity");

                }
                else
                {
                    BasketForm.basket.Items[BasketForm.basket.SelectedItems[0].Index].SubItems[0].Text = prodName.Text;
                    BasketForm.basket.Items[BasketForm.basket.SelectedItems[0].Index].SubItems[1].Text = prodQuant.Text;
                    BasketForm.basket.Items[BasketForm.basket.SelectedItems[0].Index].SubItems[2].Text = prodPrice.Text;
                    decimal basketTotal = 0;
                    for (int i = 0; i < BasketForm.basket.Items.Count; i++)
                    {
                        basketTotal += decimal.Parse(BasketForm.basket.Items[i].SubItems[2].Text) * decimal.Parse(BasketForm.basket.Items[i].SubItems[1].Text);
                    }
                    string basketTotal2 = Convert.ToString(basketTotal);
                    BasketForm.TotalCost.Text = basketTotal2;
                    Close();
                }
            }
        }
    }
}
