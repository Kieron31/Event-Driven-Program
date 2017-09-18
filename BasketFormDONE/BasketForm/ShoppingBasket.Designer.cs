namespace BasketForm
{
    partial class ShoppingBasket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingBasket));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddToBasket = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.EditSelected = new System.Windows.Forms.Button();
            this.ClearBasket = new System.Windows.Forms.Button();
            this.SaveOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.basket = new System.Windows.Forms.ListView();
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latest Price";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.SystemColors.Control;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(12, 42);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(173, 24);
            this.ProductName.TabIndex = 3;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.SystemColors.Control;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(217, 42);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(72, 24);
            this.Quantity.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.Control;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(332, 42);
            this.Price.MaxLength = 10;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(96, 24);
            this.Price.TabIndex = 6;
            // 
            // AddToBasket
            // 
            this.AddToBasket.BackColor = System.Drawing.SystemColors.Control;
            this.AddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBasket.Location = new System.Drawing.Point(453, 35);
            this.AddToBasket.Name = "AddToBasket";
            this.AddToBasket.Size = new System.Drawing.Size(92, 36);
            this.AddToBasket.TabIndex = 7;
            this.AddToBasket.Text = "Add";
            this.AddToBasket.UseVisualStyleBackColor = false;
            this.AddToBasket.Click += new System.EventHandler(this.AddToBasket_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelected.Location = new System.Drawing.Point(584, 75);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(92, 36);
            this.RemoveSelected.TabIndex = 8;
            this.RemoveSelected.Text = "Remove";
            this.RemoveSelected.UseVisualStyleBackColor = false;
            this.RemoveSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // EditSelected
            // 
            this.EditSelected.BackColor = System.Drawing.SystemColors.Control;
            this.EditSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSelected.Location = new System.Drawing.Point(566, 117);
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(123, 36);
            this.EditSelected.TabIndex = 9;
            this.EditSelected.Text = "Edit Selected";
            this.EditSelected.UseVisualStyleBackColor = false;
            this.EditSelected.Click += new System.EventHandler(this.EditSelected_Click);
            // 
            // ClearBasket
            // 
            this.ClearBasket.BackColor = System.Drawing.SystemColors.Control;
            this.ClearBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBasket.Location = new System.Drawing.Point(566, 159);
            this.ClearBasket.Name = "ClearBasket";
            this.ClearBasket.Size = new System.Drawing.Size(123, 36);
            this.ClearBasket.TabIndex = 10;
            this.ClearBasket.Text = "Clear Basket";
            this.ClearBasket.UseVisualStyleBackColor = false;
            this.ClearBasket.Click += new System.EventHandler(this.ClearBasket_Click);
            // 
            // SaveOrder
            // 
            this.SaveOrder.BackColor = System.Drawing.SystemColors.Control;
            this.SaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrder.Location = new System.Drawing.Point(545, 420);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(75, 36);
            this.SaveOrder.TabIndex = 18;
            this.SaveOrder.Text = "Save";
            this.SaveOrder.UseVisualStyleBackColor = false;
            this.SaveOrder.Click += new System.EventHandler(this.SaveOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Cost";
            // 
            // TotalCost
            // 
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.Location = new System.Drawing.Point(365, 471);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Size = new System.Drawing.Size(100, 24);
            this.TotalCost.TabIndex = 14;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(626, 420);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 36);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.65F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(508, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 213);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.basket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productColumn,
            this.quantityCol,
            this.priceCol});
            this.basket.FullRowSelect = true;
            this.basket.Location = new System.Drawing.Point(24, 92);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(462, 335);
            this.basket.TabIndex = 23;
            this.basket.UseCompatibleStateImageBehavior = false;
            this.basket.View = System.Windows.Forms.View.Details;
            // 
            // productColumn
            // 
            this.productColumn.Text = "Product";
            this.productColumn.Width = 257;
            // 
            // quantityCol
            // 
            this.quantityCol.Text = "Quantity";
            this.quantityCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityCol.Width = 100;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price (Per Item)";
            this.priceCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceCol.Width = 101;
            // 
            // LoadOrder
            // 
            this.LoadOrder.BackColor = System.Drawing.SystemColors.Control;
            this.LoadOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadOrder.Location = new System.Drawing.Point(584, 462);
            this.LoadOrder.Name = "LoadOrder";
            this.LoadOrder.Size = new System.Drawing.Size(75, 36);
            this.LoadOrder.TabIndex = 24;
            this.LoadOrder.Text = "Load";
            this.LoadOrder.UseVisualStyleBackColor = false;
            this.LoadOrder.Click += new System.EventHandler(this.LoadOrder_Click);
            // 
            // ShoppingBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(745, 516);
            this.Controls.Add(this.LoadOrder);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveOrder);
            this.Controls.Add(this.ClearBasket);
            this.Controls.Add(this.EditSelected);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddToBasket);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShoppingBasket";
            this.Text = "ShoppingBasket";
            this.Load += new System.EventHandler(this.ShoppingBasket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TextBox ProductName;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddToBasket;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button EditSelected;
        private System.Windows.Forms.Button ClearBasket;
        private System.Windows.Forms.Button SaveOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader quantityCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        public System.Windows.Forms.ListView basket;
        public System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.Button LoadOrder;
    }
}

