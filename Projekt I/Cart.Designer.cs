namespace Projekt_I
{
    partial class Cart
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
            this.data_grid_table_cart = new System.Windows.Forms.DataGridView();
            this.button_return_cart = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.txt_delete_cart = new System.Windows.Forms.TextBox();
            this.button_delete_order_cart = new System.Windows.Forms.Button();
            this.button_delete_order = new System.Windows.Forms.Button();
            this.txt_delete_order_cart = new System.Windows.Forms.TextBox();
            this.button_refresh_cart = new System.Windows.Forms.Button();
            this.button_buy = new System.Windows.Forms.Button();
            this.receipt_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_table_cart
            // 
            this.data_grid_table_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_table_cart.Location = new System.Drawing.Point(12, 113);
            this.data_grid_table_cart.Name = "data_grid_table_cart";
            this.data_grid_table_cart.RowHeadersWidth = 51;
            this.data_grid_table_cart.RowTemplate.Height = 24;
            this.data_grid_table_cart.Size = new System.Drawing.Size(533, 325);
            this.data_grid_table_cart.TabIndex = 0;
            this.data_grid_table_cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_table_cart_CellClick);
            // 
            // button_return_cart
            // 
            this.button_return_cart.Location = new System.Drawing.Point(557, 8);
            this.button_return_cart.Name = "button_return_cart";
            this.button_return_cart.Size = new System.Drawing.Size(159, 102);
            this.button_return_cart.TabIndex = 1;
            this.button_return_cart.Text = "Sklep";
            this.button_return_cart.UseVisualStyleBackColor = true;
            this.button_return_cart.Click += new System.EventHandler(this.button_return_cart_Click_1);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(557, 173);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Usuń:";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // txt_delete_cart
            // 
            this.txt_delete_cart.Location = new System.Drawing.Point(638, 173);
            this.txt_delete_cart.Name = "txt_delete_cart";
            this.txt_delete_cart.Size = new System.Drawing.Size(100, 22);
            this.txt_delete_cart.TabIndex = 3;
            // 
            // button_delete_order_cart
            // 
            this.button_delete_order_cart.Location = new System.Drawing.Point(392, 8);
            this.button_delete_order_cart.Name = "button_delete_order_cart";
            this.button_delete_order_cart.Size = new System.Drawing.Size(159, 99);
            this.button_delete_order_cart.TabIndex = 4;
            this.button_delete_order_cart.Text = "Zamówienia";
            this.button_delete_order_cart.UseVisualStyleBackColor = true;
            this.button_delete_order_cart.Click += new System.EventHandler(this.button_delete_order_cart_Click);
            // 
            // button_delete_order
            // 
            this.button_delete_order.Location = new System.Drawing.Point(557, 200);
            this.button_delete_order.Name = "button_delete_order";
            this.button_delete_order.Size = new System.Drawing.Size(112, 56);
            this.button_delete_order.TabIndex = 5;
            this.button_delete_order.Text = "Usuń Zamówienie:";
            this.button_delete_order.UseVisualStyleBackColor = true;
            this.button_delete_order.Click += new System.EventHandler(this.button_delete_order_Click);
            // 
            // txt_delete_order_cart
            // 
            this.txt_delete_order_cart.Location = new System.Drawing.Point(671, 201);
            this.txt_delete_order_cart.Name = "txt_delete_order_cart";
            this.txt_delete_order_cart.Size = new System.Drawing.Size(45, 22);
            this.txt_delete_order_cart.TabIndex = 6;
            // 
            // button_refresh_cart
            // 
            this.button_refresh_cart.Location = new System.Drawing.Point(227, 9);
            this.button_refresh_cart.Name = "button_refresh_cart";
            this.button_refresh_cart.Size = new System.Drawing.Size(159, 98);
            this.button_refresh_cart.TabIndex = 7;
            this.button_refresh_cart.Text = "Odśwież";
            this.button_refresh_cart.UseVisualStyleBackColor = true;
            this.button_refresh_cart.Click += new System.EventHandler(this.button_refresh_cart_Click);
            // 
            // button_buy
            // 
            this.button_buy.Location = new System.Drawing.Point(12, 10);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(209, 98);
            this.button_buy.TabIndex = 8;
            this.button_buy.Text = "Kup";
            this.button_buy.UseVisualStyleBackColor = true;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // receipt_label
            // 
            this.receipt_label.AutoSize = true;
            this.receipt_label.Location = new System.Drawing.Point(586, 301);
            this.receipt_label.Name = "receipt_label";
            this.receipt_label.Size = new System.Drawing.Size(46, 17);
            this.receipt_label.TabIndex = 9;
            this.receipt_label.Text = "label1";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receipt_label);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.button_refresh_cart);
            this.Controls.Add(this.txt_delete_order_cart);
            this.Controls.Add(this.button_delete_order);
            this.Controls.Add(this.button_delete_order_cart);
            this.Controls.Add(this.txt_delete_cart);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_return_cart);
            this.Controls.Add(this.data_grid_table_cart);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_table_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_return_cart;
        public System.Windows.Forms.DataGridView data_grid_table_cart;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox txt_delete_cart;
        private System.Windows.Forms.Button button_delete_order_cart;
        private System.Windows.Forms.Button button_delete_order;
        private System.Windows.Forms.TextBox txt_delete_order_cart;
        private System.Windows.Forms.Button button_refresh_cart;
        private System.Windows.Forms.Button button_buy;
        private System.Windows.Forms.Label receipt_label;
    }
}