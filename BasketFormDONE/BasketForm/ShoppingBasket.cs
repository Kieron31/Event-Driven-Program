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

namespace BasketForm
{
    public partial class ShoppingBasket : Form
    {
        public ShoppingBasket()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShoppingBasket_KeyDown);
        }

        private void Exit_Click(object sender, EventArgs e)
        //Simply closes the form
        {
            Close();
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        //Reads data that has been entered and adds it to the listview
        {
            string price = Price.Text;
            string quantity = Quantity.Text;
            string product = ProductName.Text;
            int quantInt = Convert.ToInt32(quantity);
            decimal priceDec;
            bool isNumeric = decimal.TryParse(price, out priceDec);
            if (isNumeric != true)
            {
                MessageBox.Show("Enter a valid price.");
                Price.Text = "";
            }
            else
            {
                priceDec = Convert.ToDecimal(price);
                if (!decimal.TryParse(price, out decimal value) || !decimal.TryParse(quantity, out decimal value2M) || quantInt < 1 || priceDec < 0)
                //checks if valid price and quantity have been entered
                {

                    MessageBox.Show("Enter a valid price/quantity.");
                    Price.Text = "";
                    Quantity.Value = 0;

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(product))
                    {
                        MessageBox.Show("Please Enter a product name.");
                    }
                    else
                    {
                        var item = new ListViewItem(product);
                        item.SubItems.Add(quantity);
                        item.SubItems.Add(price);
                        basket.Items.Add(item);

                        ProductName.Clear();
                        Quantity.Value = 0;
                        Price.Clear();
                        UpdateTotalCost();
                    }
                }

            }
        }

        private void removeSelected_Click(object sender, EventArgs e)
        //Simple function to remove selected product from basket
        {
            for (int i = 0; i < basket.Items.Count; i++)
            {
                if (basket.Items[i].Selected)
                {
                    basket.Items[i].Remove();
                    i--;
                }
            }
            UpdateTotalCost();
        }

        private void ClearBasket_Click(object sender, EventArgs e)
        //simple function to clear the basket and set total cost to 0
        {
            basket.Items.Clear();
            TotalCost.Text = "0";
        }

        private void EditSelected_Click(object sender, EventArgs e)
        //opens edit form and populates boxes with selected product information
        {
            if (basket.SelectedItems.Count != 0)
            //checks if a product has been selected when edit is clicked, otherwise errors
            {

                EditDLG frm = new EditDLG(this);  //opens the new edit form
                frm.productName = basket.Items[basket.SelectedItems[0].Index].SubItems[0].Text;
                frm.productQuan = basket.Items[basket.SelectedItems[0].Index].SubItems[1].Text;
                frm.productPrice = basket.Items[basket.SelectedItems[0].Index].SubItems[2].Text;
                frm.Show();


                UpdateTotalCost();


            }
            else
            {
                MessageBox.Show("Please Select a product!");
            }
        }




        private void SaveOrder_Click(object sender, EventArgs e)
        {


            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //prompts the user asking where they want to save the file using a file explorer

            saveFileDialog1.Filter = "TXT files|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    //writes a .txt file with the data using stream writer to where ever the user specified
                    {
                        StringBuilder line = new StringBuilder();
                        foreach (ListViewItem item in basket.Items)
                        {
                            line.Clear();
                            for (int i = 0; i < item.SubItems.Count; i++)
                            {
                                if (i > 0)
                                    line.Append("|");
                                line.Append(item.SubItems[i].Text);
                            }
                            writer.WriteLine(line);
                        }
                    }
                    myStream.Close();
                }
            }
        }

        private void UpdateTotalCost()  //function to update total cost when the user: edits, adds or removes a product
        {
            decimal basketTotal = 0;
            for (int i = 0; i < basket.Items.Count; i++)
            {
                basketTotal += decimal.Parse(basket.Items[i].SubItems[1].Text) * decimal.Parse(basket.Items[i].SubItems[2].Text);
            }
            string basketTotal2 = Convert.ToString(basketTotal);
            TotalCost.Text = basketTotal2;
        }

        private void LoadOrder_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"Documents";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            using (var sr = new System.IO.StreamReader(myStream))
                            // Wrapped it up in a using statement so it is disposed of automagically
                            {
                                basket.Items.Clear();
                                string line = string.Empty;
                                while ((line = sr.ReadLine()) != null) // Loop while there is more data to read
                                {
                                    string[] lineItems = line.Split('|'); // Split only the single line

                                    ListViewItem lv = new ListViewItem();
                                    lv.Text = lineItems[0];
                                    lv.SubItems.Add(lineItems[1]);
                                    lv.SubItems.Add(lineItems[2]);
                                    basket.Items.Add(lv);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            UpdateTotalCost();
        }

        private void ShoppingBasket_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void ShoppingBasket_KeyDown(object sender, KeyEventArgs e)
        { //When CTRL+S Is pressed on the keyboard, this function will run (save to text file)
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                SaveOrder.PerformClick();
            }
        }
    }
}
